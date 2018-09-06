using System.Threading.Tasks;

namespace Dqc.Domain.Uow
{
    public interface IUnitOfWork
    {
        void SaveChanges();

        Task SaveChangesAsync();
    }
}
