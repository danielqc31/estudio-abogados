using Dqc.Infraestructure.EFCore.Uow;
using EstudioAbogados.Domain.Repositories;
using EstudioAbogados.Infraestructure.EFCore.Repositories;

namespace EstudioAbogados.Infraestructure.EFCore.Uow
{
    public class UnitOfWorkEstudioAbogados : UnitOfWorkEFCore, IUnitOfWorkEstudioAbogados
    {
        IAbogadoRepository _abogado;
        public IAbogadoRepository Abogado
        {
            get
            {
                if (_abogado == null)
                {
                    _abogado = new AbogadoRepository((EstudioAbogadosDbContext)Context);
                }

                return _abogado;
            }
        }

        public UnitOfWorkEstudioAbogados(EstudioAbogadosDbContext context) : base(context)
        {

        }
    }
}
