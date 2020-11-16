using System.Threading.Tasks;
using System.Web.Http;
using MisteryBoxDomain.Services;

namespace MisteryBoxAPI.Controllers
{
    public class MisteryBoxController : ApiController
    {

        private readonly IServiceCocina _cocinaService;
        private readonly IServiceRopa _ropaService;
        private readonly IServiceTecnologia _tecnologiaService;

        public MisteryBoxController(IServiceCocina cocinaService,IServiceRopa ropaService, IServiceTecnologia tecnologiaService)
        {
            _cocinaService = cocinaService;
            _ropaService = ropaService;
            _tecnologiaService = tecnologiaService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> ObtenerCajaMisteriosa()
        {
            return Ok();
        }
    }
}
