using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using BL;

namespace Aula_7.Controllers
{
    [Route("fapen/produto")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        // GET fapen/produto
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET apen/produto/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //POST fapen/produto
       [HttpPost]
        public void Post([FromBody] Produto p)
        {

        }

        // PUT fapen/produto
        [HttpPut]
        public void Put(int id, [FromBody] Produto p)
        {
            ProdutoBL prodBL = new ProdutoBL();
            prodBL.AdicionarProduto(p);
        }

        // DELETE fapen/produto/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<string>> Delete(int id)
        {
            if (id <= 0)
            {
                return new string[] { "Produto inválido!" };
            }
            else
            {
                ProdutoBL prodBl = new ProdutoBL();
                prodBl.RemoverProduto(id);
                return new string[] { "Produto excluido com sucesso!" };
            }
        }
    }
}
