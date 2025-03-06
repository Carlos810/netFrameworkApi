using ConsumeWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace XML_API_CP.Controllers
{
    //[EnableCors(origins: "http://localhost:44325",headers:"*",  methods:"*")]
    public class ValuesController : ApiController
    {
        // GET api/values          

        [HttpPost]
        [Route("api/Persona")]
        public bool SearchByZipCode([FromBody] int CodigoPostal) 
        {
            int numero = 15;
            return true;
        }

    }
}
