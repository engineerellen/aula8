using System;
using System.IO;
namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciaDiretorio();
        }

        static void GerenciaDiretorio()
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\MyDir");
            try
            {
                if (di.Exists)
                {
                    Console.WriteLine("Diretório já existente.");

                }
                else
                {
                    di.Create();
                    Console.WriteLine("Diretório Criado com sucesso!.");
                }

                di.Delete();
               Console.WriteLine("Diretório Excluiído com sucesso!.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        //PRecisa criar uma pasta e arquivo C:\fapen\teste.txt
        static void LeArquivo()
        {
            string arquivo = @"C:\fapen\teste.txt";

            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {

                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + "não foi localizado !");
            }
            Console.ReadKey();
        }
    }
}
