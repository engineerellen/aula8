using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TesteWebAPI.Controllers
{
    [Route("fapen/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET: api/Cliente
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cliente/5
        [HttpGet("{id}")]
        [Route("getCliente/{id}")]
        public string GetCliente(int id)
        {
            if (id == 5)
                return "Cliente Preferencial";
            else
                return "Cliente não preferencial";
        }

        // POST: fapen/Cliente/gravardados
        // POST api/values
        [HttpPost("{login}")]
        [Route("logar/{login}")]
        public string Logar([FromBody]string value)
        {
            return "OK";
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
