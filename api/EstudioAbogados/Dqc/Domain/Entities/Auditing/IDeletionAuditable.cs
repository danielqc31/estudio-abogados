using System;

namespace Dqc.Domain.Entities.Auditing
{
    public interface IDeletionAuditable
    {
        bool IsDeleted { get; set; }
        long? DeletionUserId { get; set; }
        DateTime? DeletionDate { get; set; }
    }
}
