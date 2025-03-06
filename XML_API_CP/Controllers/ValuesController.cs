using ConsumeWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using XML_API_CP.Models;
using XML_API_CP.Utils;

namespace XML_API_CP.Controllers
{
   
    public class ValuesController : ApiController
    {
        // GET api/values          
        [HttpPost]
        [Route("api/Persona")]
        public IHttpActionResult SearchByZipCode([FromBody] MXmlBody body) 
        {

            if (body.CodigoPostal == 0 )
            {
                return BadRequest("El código postal es requerido.");
            }

            int codigoPostal;
            if (!int.TryParse(body.CodigoPostal.ToString(), out codigoPostal))
            {
                return BadRequest("El código postal debe ser un número válido.");
            }

            List<MColoniaL> LColonias = CiudadesService.GetCities(codigoPostal);
            if (LColonias == null || !LColonias.Any())
                return NotFound();


            return Ok(LColonias);
        }

    }
}
