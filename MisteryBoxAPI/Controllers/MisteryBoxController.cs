using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MisteryBoxAPI.Controllers
{
    public class MisteryBoxController : ApiController
    {

        public async Task<IHttpActionResult> ObtenerCajaMisteriosa()
        {
            return Ok();
        }
    }
}
