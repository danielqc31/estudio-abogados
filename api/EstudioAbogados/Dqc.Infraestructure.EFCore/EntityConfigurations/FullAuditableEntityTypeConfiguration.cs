using Dqc.Domain.Entities.Auditing;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dqc.Infraestructure.EFCore.EntityConfigurations
{
    public abstract class FullAuditableEntityTypeConfiguration<TEntity> : AuditableEntityTypeConfiguration<TEntity>
        where TEntity : class, IFullAuditable
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.IsDeleted)
                .IsRequired();

            builder.Property(p => p.DeletionUserId)
                .IsRequired(false);

            builder.Property(p => p.DeletionDate)                
                .IsRequired(false);
        }
    }

    public abstract class FullAuditableEntityTypeConfiguration : FullAuditableEntityTypeConfiguration<FullAuditableEntity>
    {

    }
}
