using EstudioAbogados.Application.AbogadoApp;
using EstudioAbogados.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EstudioAbogados.Web.API.Controllers
{
    [Produces("application/json")]
    [Route("api/estudioabogados/abogado")]
    public class AbogadoController : Controller
    {
        private IAbogadoAppService _service;

        public AbogadoController(IAbogadoAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("items")]
        public async Task<IActionResult> GetAll()
        {
            var items = await _service.GetAll();

            return Ok(items);
        }

        [HttpGet]
        [Route("items/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var item = await _service.GetById(id);

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("items")]
        public async Task<IActionResult> Create([FromBody]Abogado abogado)
        {
            var resp = await _service.Register(abogado);

            return CreatedAtAction(nameof(GetById), new { id = resp.Id }, null);
        }
    }
}