using System;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Model;

namespace TesteDoTesteWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
           // Get();

            Post();
          
        }
        /*Note que o parametro do Get pode ser usado no proprio link*/
        private static void Get()
        {/*//Criando uma requisição*/
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8081/fapen/login/ellen");
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseString);
        }
        /*Parametro do post é encapsulada . Usamos os mesmos dados existentes no objeto serializado*/
        private static void Post()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8081/fapen/login/acessar");
            var postData = "{ Id: 1, login: 'ellen', senha: 123 }";
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

    }
    
}
