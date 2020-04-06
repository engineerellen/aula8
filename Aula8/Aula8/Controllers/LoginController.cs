using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using BL;

namespace Aula8.Controllers
{
    [Route("fapen/login")]
    public class LoginController : Controller
    {
        // GET api/values
        // GET api/values
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            UsuarioBL usuBl = new UsuarioBL();

            List<Usuario> lstUsuario = usuBl.getUsuarios();
            return lstUsuario;
        }

        // GET fapen/login/5
        [HttpGet("{login}")]
        [Route("logar/{login}")]
        public string LerLogin(string login)
        {
            Usuario usu = new Usuario(login);
            UsuarioBL usuBl = new UsuarioBL();
            if (usuBl.ValidaLogin(usu))
            {
                return "Login valido";
            }
            return "Login invalido";
        }

        // POST api/values
        [HttpPost]
        [Route("validarLogin")]
        public string ValidarLogin([FromBody] Usuario usu)
        {
            UsuarioBL usuBl = new UsuarioBL();

            if (usuBl.ValidarLoginSenha(usu))
            {
                return "USuario valido";
            }
            return "Usuario invalido!";
        }

        // PUT fapen/usuario
        [HttpPut]
        public ActionResult<string> Put(int id, [FromBody] Usuario u)
        {
            UsuarioBL usuBl = new UsuarioBL();
            if (usuBl.InserirUsuario(u) > 0)
            {
                return "Inserido com sucesso!";
            }
            return "login nao inserido!";

            /* if (usuBl.AtualizarUsuario(u) > 0)
             {
                 return "Atualizado com sucesso!";
             }
             return "login nao inserido!";*/
        }

        // DELETE fapen/usuario/2
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<string>> Delete(int id)
        {
            int retorno = 0;
            if (id <= 0)
            {
                return new string[] { "Usuario inválido!" };
            }
            else
            {
                UsuarioBL usuBl = new UsuarioBL();
                retorno = usuBl.ExcluirUsuario(id);
                if (retorno > 0)
                {
                    return new string[] { "Usuario excluido com sucesso!" };
                }
                return new string[] { "Usuario não excluido!" };
            }
        }
    }
}
