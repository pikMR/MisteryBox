using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using MisteryBoxDomain.Entities;
using MisteryBoxDomain.Services;
using System.Linq;
using System;
using MisteryBoxAPI.Crosscutting;

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
            //var _single = await _cocinaService.GetById(1);
            var dataCocina = _cocinaService.GetAll();
            var dataRopa = _ropaService.GetAll();
            var dataTecn = _tecnologiaService.GetAll();
            await Task.WhenAll(dataCocina, dataRopa, dataTecn);
            return Ok(dataCocina.Result.OrderBy(x => Guid.NewGuid())
                .ZipThree(dataRopa.Result.OrderBy(x => Guid.NewGuid())
                , dataTecn.Result.OrderBy(x => Guid.NewGuid())
                , (itemCocina, itemRopa, itemTech) => new { itemCocina, itemRopa, itemTech }));
        }

        public async Task<IHttpActionResult> ObtenerCajaMisteriosaV1()
        {
            var dataCocina = _cocinaService.GetAll();
            var dataRopa = _ropaService.GetAll();
            var dataTecn = _tecnologiaService.GetAll();
            await Task.WhenAll(dataCocina, dataRopa, dataTecn);
            List<Item> lista = new List<Item>();

            lista.AddRange(dataCocina.Result);
            lista.AddRange(dataRopa.Result);
            lista.AddRange(dataTecn.Result);
            return Ok(lista.OrderBy(x => Guid.NewGuid()).ToList());
        }

    }
}
