using Dqc.Domain.Entities.Auditing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dqc.Infraestructure.EFCore.EntityConfigurations
{
    public abstract class AuditableEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : class, IAuditable
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(p => p.CreationUserId)
                .IsRequired();

            builder.Property(p => p.CreationDate)
                .IsRequired();

            builder.Property(p => p.LastModificacionUserId)
                .IsRequired(false);

            builder.Property(p => p.LastModificationDate)
                .IsRequired(false);
        }
    }

    public abstract class AuditableEntityTypeConfiguration : AuditableEntityTypeConfiguration<AuditableEntity>
    {

    }
}
