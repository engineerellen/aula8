using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebApplication1.Controllers
{
    [Route("fapen/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
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

    }
}