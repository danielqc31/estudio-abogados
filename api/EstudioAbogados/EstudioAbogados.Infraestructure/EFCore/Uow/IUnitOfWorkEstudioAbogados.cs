using Dqc.Domain.Uow;
using EstudioAbogados.Domain.Repositories;

namespace EstudioAbogados.Infraestructure.EFCore.Uow
{
    public interface IUnitOfWorkEstudioAbogados : IUnitOfWork
    {
        IAbogadoRepository Abogado { get; }
    }
}
