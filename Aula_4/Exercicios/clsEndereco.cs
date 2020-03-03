using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class clsEndereco:IEndereco
    {
        public string TipoEndereco { get; set; }
        public int ID { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
    }
}
