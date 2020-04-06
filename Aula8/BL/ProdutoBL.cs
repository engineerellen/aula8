using System;
using System.Collections.Generic;
using System.IO;
using Model;

namespace BL
{
    public class ProdutoBL
    {
        public void AdicionarProduto(Produto p)
        {
            string arquivo = @"C:\fapen\Produto.txt";
            try
            {
                if (File.Exists(arquivo))
                {
                    string linha;
                    List<string> linhasArquivo = new List<string>();
                    using (StreamReader reader = new StreamReader(arquivo))
                    {
                        linha = reader.ReadLine();
                        if(linha!= null)
                        {
                            linhasArquivo.Add(linha);
                        }
                        
                    }
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(arquivo))
                    {
                        foreach (string line in linhasArquivo)
                        {
                            // If the line doesn't contain the word 'Second', write the line to the file.
                            if (!line.Contains(p.ID.ToString()))
                            {
                                file.WriteLine(p.ID + ";" + p.Descricao + ";" + p.ValorUnitario);
                            }
                        }
                        if(linhasArquivo.Count == 0)
                        {
                            file.WriteLine(p.ID + ";" + p.Descricao + ";" + p.ValorUnitario);
                        }
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(arquivo))
                    {
                        writer.Write(p.ID + ";" + p.Descricao + ";" + p.ValorUnitario);

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

        public void RemoverProduto(int idProduto)
        {
            string arquivo = @"C:\fapen\Produto.txt";
            try
            {
                if (File.Exists(arquivo))
                {
                    string strSearchText = idProduto.ToString();
                    string strOldText;
                    string newText = "";

                    StreamReader sr = File.OpenText(arquivo);
                    while ((strOldText = sr.ReadLine()) != null)
                    {
                        if (!strOldText.Contains(strSearchText))
                        {
                            newText += strOldText + Environment.NewLine;
                        }
                    }
                    sr.Close();
                    File.WriteAllText(arquivo, newText);
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
    }
}
