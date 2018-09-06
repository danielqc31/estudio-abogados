using Dqc.Domain.Entities.Auditing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dqc.Infraestructure.EFCore
{
    public abstract class DbContextBase : DbContext
    {
        protected DbContextBase(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            TrackChanges();

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            TrackChanges();

            return await base.SaveChangesAsync(cancellationToken);
        }

        private void TrackChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Deleted || e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                if (entry.State == EntityState.Deleted && entry.Entity is IDeletionAuditable)
                {
                    var deletionAuditable = entry.Entity as IDeletionAuditable;

                    entry.State = EntityState.Unchanged;

                    deletionAuditable.IsDeleted = true;
                    deletionAuditable.DeletionDate = DateTime.Now;
                }

                if (entry.Entity is IAuditable)
                {
                    var auditable = entry.Entity as IAuditable;
                    if (entry.State == EntityState.Added)
                    {
                        auditable.CreationDate = DateTime.Now;
                    }
                    else
                    {
                        auditable.LastModificationDate = DateTime.Now;
                    }
                }
            }
        }
    }
}
