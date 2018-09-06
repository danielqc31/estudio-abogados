using Dqc.Domain.Entities;
using Dqc.Infraestructure.EFCore.Repositories;

namespace EstudioAbogados.Infraestructure.EFCore.Repositories
{
    public abstract class EstudioAbogadosRepositoryBase<TEntity, TPrimaryKey>
        : RepositoryEFCoreBase<EstudioAbogadosDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntityBase<TPrimaryKey>
    {
        protected EstudioAbogadosRepositoryBase(EstudioAbogadosDbContext dbContext)
            : base(dbContext)
        {
        }

        // Métodos comunes para todos los repositorios
    }

    public abstract class EstudioAbogadosRepositoryBase<TEntity> : EstudioAbogadosRepositoryBase<TEntity, int>
        where TEntity : class, IEntityBase<int>
    {
        protected EstudioAbogadosRepositoryBase(EstudioAbogadosDbContext dbContext) : base(dbContext) { }
    }
}
