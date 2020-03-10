using System;
using System.IO;
namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio12();
        }
      
        static void Exercicio12()
        {
            string arquivo = @"C:\fapen\AulaFapen.txt";
            try
            {
                if (File.Exists(arquivo))
                {
                    string linha;
                    using (StreamReader reader = new StreamReader(arquivo))
                    {
                        linha = reader.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(arquivo))
                    {
                        writer.Write("Estamos utilizando a classe StreamWriter para escrever esse código! ");

                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception ex1)
            {
                throw ex1;
            }

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
