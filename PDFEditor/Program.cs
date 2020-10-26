using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = System.IO.Path;

namespace PDFEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sample.pdf");

            Console.WriteLine(ExtractTextFormPdf(filePath));
            Console.ReadKey();
        }

        

        public static string ExtractTextFormPdf(string pdfFileName)
        {

            StringBuilder text = new StringBuilder();
            try
            {
                PdfReader pdfReader = new PdfReader(pdfFileName);
                int pageNumber = pdfReader.NumberOfPages;
                for(int i=0 ; i<pageNumber ; i += 1)
                {
                    text.Append(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(pdfReader, i + 1));
                    int a = 1;
                }
                pdfReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return text.ToString();

        }


    }
}
