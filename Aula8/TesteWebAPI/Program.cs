using System;
using Model;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.IO;
using System.Text;


namespace TesteWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get();
            //Post();
            TestarHttpPut();
            //TestarHttpDelete();
        }

        /*Note que o parametro do Get pode ser usado no proprio link*/
        private static void Get()
        {/*//Criando uma requisição*/
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:44394/fapen/login/ellen");
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseString);
        }
        /*Parametro do post é encapsulada . Usamos os mesmos dados existentes no objeto serializado*/
        private static void Post()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://localhost:44394/fapen/login/validarLogin");
            var postData = "{ Id: 1, login: 'ellen', senha: 123, cod_cli:1 }";
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            Console.WriteLine("A resposta do método POST é: " + responseString);
        }

       
        static void TestarHttpPut()
        {
            using (var client = new HttpClient())
            {
                Usuario u = new Usuario {  Login = "ellen", Senha = "123" , Cod_Cli = 1};
                client.BaseAddress = new Uri("https://localhost:44394/fapen/login");
                var response = client.PutAsJsonAsync("login", u).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Usuario Inserido com sucesso");
                }
                else
                    Console.Write("Erro ao inserir usuario: " + response.ToString());
            }
        }

        static void TestarHttpDelete()
        {
            using (var client = new HttpClient())
            {
                string ID = "1";
                client.BaseAddress = new Uri("https://localhost:44394/fapen/login");
                var response = client.DeleteAsync("login/" + ID).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Usuario inserido com sucesso");
                }
                else
                    Console.Write("Erro ao inserir usuario");
            }
        }

    }
}
