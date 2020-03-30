using System;
using Model;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace TesteWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestarHttpPut();
         TestarHttpDelete();
        }

        static void TestarHttpDelete()
        {
            using (var client = new HttpClient())
            {
                string produtoID = "1";
                client.BaseAddress = new Uri("https://localhost:44394/fapen/produto");
                var response = client.DeleteAsync("produto/"+produtoID).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");
            }
        }

        static void TestarHttpPut()
        {
            using (var client = new HttpClient())
            {
                Produto p = new Produto { ID = 1, Descricao = "Celular Xiaomi Mi 10", ValorUnitario = 3000.00 };
                client.BaseAddress = new Uri("https://localhost:44394/fapen/produto");
                var response = client.PutAsJsonAsync("produto", p).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Produto Inserido com sucesso");
                }
                else
                    Console.Write("Erro ao inserir produto: " + response.ToString());
            }
        }
    }
}
