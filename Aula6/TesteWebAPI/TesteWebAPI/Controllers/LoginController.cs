using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace TesteWebAPI.Controllers
{
    [Route("fapen/login")]
    public class LoginController : Controller
    {
        // GET api/values
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET fapen/login/5
        [HttpGet("{login}")]
        [Route("logar/{login}")]
        public string LerLogin(string login)
        {
            Usuario usr = new Usuario(login);
            if (usr.Login == "ellen")
                return usr.Login + " : OK ";
            else
                return usr.Login + " : NOK ";
        }

        // POST api/values
        [HttpPost]
        [Route("acessar")]
        public string Acessar([FromBody] Usuario value)
        {
            if (value!= null)
            {
                Usuario usu = new Usuario(value.Login);
                if (value.Login == "ellen" && value.Senha == "123")
                {
                    return "OK";
                }
                else {
                    return "NOK";
                }
            }
            return "NOK - null";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
