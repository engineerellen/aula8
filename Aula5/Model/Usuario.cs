using System;

namespace Model
{
    public class Usuario
    {
        public int ID { get; set; }
        public int Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


        public Usuario(string username)
        {
            this.Login = username;
        }
    }
}
