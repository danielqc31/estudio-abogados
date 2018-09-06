using Dqc.Application.Services;
using EstudioAbogados.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstudioAbogados.Application.AbogadoApp
{
    public interface IAbogadoAppService : IApplicationService
    {
        Task<List<Abogado>> GetAll();

        Task<Abogado> GetById(int id);

        Task<Abogado> Register(Abogado abogado);
    }
}
