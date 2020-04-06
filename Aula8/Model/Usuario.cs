using System;

namespace Model
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Cod_Cli { get; set; }

        public Usuario(string login)
        {
            this.Login = login;
        }
        public Usuario()
        {
        }
    }
}
