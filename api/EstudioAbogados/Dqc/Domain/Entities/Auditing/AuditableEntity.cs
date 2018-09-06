using System;

namespace Dqc.Domain.Entities.Auditing
{
    public abstract class AuditableEntity<TPrimaryKey> : EntityBase<TPrimaryKey>, IAuditable
    {
        public virtual long CreationUserId { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual long? LastModificacionUserId { get; set; }
        public virtual DateTime? LastModificationDate { get; set; }
    }

    public abstract class AuditableEntity : AuditableEntity<int>, IEntityBase
    {
        
    }
}
