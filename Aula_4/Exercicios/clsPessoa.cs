using System;

namespace Exercicios
{
    public class clsPessoa
    {
        public int ID { get; set; }
        public clsTipoPessoa tpPessoa { get; set; }
        public clsEndereco Endereco { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
    }
}
