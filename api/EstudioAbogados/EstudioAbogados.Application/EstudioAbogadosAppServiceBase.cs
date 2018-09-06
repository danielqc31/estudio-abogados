using Dqc.Application.Services;
using Dqc.Domain.Uow;
using EstudioAbogados.Infraestructure.EFCore.Uow;

namespace EstudioAbogados.Application
{
    public abstract class EstudioAbogadosAppServiceBase : ApplicationService
    {
        protected IUnitOfWorkEstudioAbogados _unitOfworkEstudioAbogados { get { return (IUnitOfWorkEstudioAbogados)UnitOfWork; } }

        protected EstudioAbogadosAppServiceBase(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
