using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class clsCliente:clsPessoa
    {
        public int ID { get; set; }
        public DateTime DtCadastro { get; set; }
        public double Renda { get; set; }
    }
}
