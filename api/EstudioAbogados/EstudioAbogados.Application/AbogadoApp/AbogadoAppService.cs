using EstudioAbogados.Domain;
using EstudioAbogados.Infraestructure.EFCore.Uow;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstudioAbogados.Application.AbogadoApp
{
    public class AbogadoAppService : EstudioAbogadosAppServiceBase, IAbogadoAppService
    {
        public AbogadoAppService(IUnitOfWorkEstudioAbogados unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<List<Abogado>> GetAll()
        {
            return await _unitOfworkEstudioAbogados.Abogado.GetAllListAsync();
        }

        public async Task<Abogado> GetById(int id)
        {
            var abogado = await _unitOfworkEstudioAbogados.Abogado.FirstOrDefaultAsync(id);

            return abogado;
        }

        public async Task<Abogado> Register(Abogado abogado)
        {
            abogado = await _unitOfworkEstudioAbogados.Abogado.InsertAsync(abogado);

            await _unitOfworkEstudioAbogados.SaveChangesAsync();

            return abogado;
        }
    }
}
