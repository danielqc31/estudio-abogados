using System;

namespace Dqc.Domain.Entities.Auditing
{
    public abstract class FullAuditableEntity<TPrimaryKey> : AuditableEntity<TPrimaryKey>, IFullAuditable
    {
        public virtual bool IsDeleted { get; set; }
        public virtual long? DeletionUserId { get; set; }
        public virtual DateTime? DeletionDate { get; set; }
    }

    public abstract class FullAuditableEntity : FullAuditableEntity<int>, IEntityBase
    {
        
    }
}
