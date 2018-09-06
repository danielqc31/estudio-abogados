using System;

namespace Dqc.Domain.Entities.Auditing
{
    public interface IAuditable
    {
        long CreationUserId { get; set; }
        DateTime CreationDate { get; set; }
        long? LastModificacionUserId { get; set; }
        DateTime? LastModificationDate { get; set; }
    }
}
