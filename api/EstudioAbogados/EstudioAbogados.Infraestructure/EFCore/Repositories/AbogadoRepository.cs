using EstudioAbogados.Domain;
using EstudioAbogados.Domain.Repositories;

namespace EstudioAbogados.Infraestructure.EFCore.Repositories
{
    public class AbogadoRepository : EstudioAbogadosRepositoryBase<Abogado, int>, IAbogadoRepository
    {
        public AbogadoRepository(EstudioAbogadosDbContext context)
            : base(context)
        {
        }
    }
}
