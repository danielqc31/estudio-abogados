using Dqc.Domain.Uow;
using System.Threading.Tasks;

namespace Dqc.Infraestructure.EFCore.Uow
{
    public abstract class UnitOfWorkEFCore : UnitOfWorkBase
    {
        protected DbContextBase Context { get; }

        public UnitOfWorkEFCore(DbContextBase context)
        {
            Context = context ?? throw new DqcException("Context was not supplied");
        }

        public override void SaveChanges()
        {
            Context.SaveChanges();
        }

        public override async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
