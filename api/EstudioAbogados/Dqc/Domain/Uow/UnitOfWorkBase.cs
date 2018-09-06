using System.Threading.Tasks;

namespace Dqc.Domain.Uow
{
    public abstract class UnitOfWorkBase : IUnitOfWork
    {
        public abstract void SaveChanges();

        public abstract Task SaveChangesAsync();
    }
}
