using System;
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS
using System.Text;
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using iTextSharp.text.pdf.parser;

namespace BL
{
    /*
     * https://www.devmedia.com.br/criando-e-manipulando-arquivos-pdf-com-a-biblioteca-itextsharp-em-csharp/33392
     */
    public class PDF
    {
        public void CriarPDF()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();


            string caminho = @"C:\fapen\" + "CONTRATO.pdf";


            PdfWriter writer = PdfWriter.GetInstance(doc,
                new FileStream(caminho, FileMode.Create));
        }

        public void EscreverPDF()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            string caminho = @"C:\fapen\" + "NF.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14));

            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;

            //paragrafo.Font = new Font(Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
            paragrafo.Add("Nota Fiscal numero 1");

            doc.Add(paragrafo);

            doc.Close();
        }

        public void TextoGrande()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            string caminho = @"C:\fapen\" + "TextoGrande.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            Paragraph paragrafo = new Paragraph("", new Font(Font.NORMAL, 14));

            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;


            // paragrafo.Font = new Font(Font.NORMAL, 14,(int)System.Drawing.FontStyle.Regular);

            StringBuilder texto = new StringBuilder();
            texto.Append("O PDF (Portable Document Format)  é um formato de ");
            texto.AppendLine("arquivo, desenvolvido pela Adobe Systems em 1993, ");
            texto.AppendLine("para representar documentos de maneira independente do aplicativo,");
            texto.AppendLine(" do hardware e do sistema operacional usados para ");
            texto.AppendLine("criá-los. Um arquivo PDF pode descrever  documentos que contenham texto, ");
            texto.AppendLine("gráficos e imagens num formato independente ");
            texto.AppendLine("de dispositivo e resolução. ");
            texto.AppendLine("O PDF é um padrão aberto, e qualquer pessoa pode escrever aplicativos que ");
            texto.AppendLine("leiam ou escrevam neste padrão. ");
            texto.AppendLine("Há aplicativos gratuitos para Microsoft Windows, Apple Macintosh e Linux, ");
            texto.AppendLine("alguns deles distribuídos pela própria ");
            texto.AppendLine("Adobe e há diversos aplicativos sob licenças livres. ");
            texto.AppendLine("PDF pode ser traduzido para português como formato de documento portátil. ");
            texto.AppendLine("É possível gerar arquivos em PDF a partir de vários formatos de documentos, ");
            texto.AppendLine("como ODF (do LibreOffice) ou DOC (do Microsoft Word) e imagens, como Jpeg e PNG. ");
            texto.AppendLine("No entanto, a qualidade do foco ");
            texto.AppendLine("gerado, no que se refere à exibição do conteúdo, pode  variar de acordo com o ");
            texto.AppendLine("formato do arquivo matriz, a partir do ");
            texto.AppendLine("qual o PDF foi criado. Portanto, a escolha do formato  mais adequado pode ser um ");
            texto.AppendLine("esforço válido, principalmente em ");
            texto.AppendLine("se tratando de PDFs que contêm informações institucionais ou corporativas.");
            texto.AppendLine("Um bom método para conseguir o máximo de qualidade é  gerar PDFs diretamente ");
            texto.AppendLine("dos programas gráficos onde as peças ");
            texto.AppendLine("foram produzidas (ocos), por exemplo, Inkscape, Gimp, Scribus, Photoshop ");
            texto.AppendLine("(também da Adobe), Illustrator, Freehand ");
            texto.AppendLine("ou CorelDraw. Se o usuário não tem esses programas  ou não tem os arquivos fontes");
            texto.AppendLine(" do material em questão (SVG, XCF, ");
            texto.AppendLine("SLA, PSD, AI, FH* ou CDR), segue a lista com os  formatos mais populares e que ");
            texto.AppendLine("permitem alta qualidade ao serem ");
            texto.AppendLine("convertidos para PDF:");

            paragrafo.Add(texto.ToString());


            doc.Add(paragrafo);

            paragrafo = new Paragraph("", new Font(Font.NORMAL, 14));
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;

            // paragrafo.Font = new Font(Font.NORMAL, 14,(int)System.Drawing.FontStyle.Regular);
            paragrafo.Add(texto.ToString());
            doc.Add(paragrafo);

            doc.Close();

        }

        public string LerPDF()
        {
            string caminho = @"C:\fapen\" + "TextoGrande.pdf";
            using (PdfReader leitor = new PdfReader(caminho))
            {
                StringBuilder texto = new StringBuilder();

                for (int i = 1; i <= leitor.NumberOfPages; i++)
                {
                    texto.Append(PdfTextExtractor.GetTextFromPage(leitor, i));
                }

                return texto.ToString();
            }
        }
    }
}



