using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public interface IEndereco
    {
        string TipoEndereco { get; set; }
        int ID { get; set; }
        string Cidade { get; set; }
        string Logradouro { get; set; }
        string Bairro { get; set; }
        string Complemento { get; set; }

    }
}
