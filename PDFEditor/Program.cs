using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = System.IO.Path;
using SpirePdf = Spire.Pdf;
using iTextSharpPdf = iTextSharp.text.pdf;
using Spire.Pdf;
using Spire.Pdf.General.Find;
using Spire.Pdf.Graphics;
using System.Drawing;
using Org.BouncyCastle.Asn1.Cmp;

namespace PDFEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pdfFileName = "sample.pdf";
            string sourceFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pdfFileName);
            string descFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pdfFileName.Replace(".", "_fixed."));

            PDFEdit pdfObj = new PDFEdit();
            pdfObj.ReplaceTextInPDF(sourceFile, descFile, "申請", "替代");

            string pdfFileName1 = "sample1.pdf";
            string sourceFile1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pdfFileName1);
            string descFile1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pdfFileName1.Replace(".", "_fixed."));

            PDFEdit pdfObj1 = new PDFEdit();
            pdfObj1.ReplaceTextInPDF(sourceFile1, descFile1, "政治", "交通");


            Console.ReadKey();


            //------------------------------------------------

            ///*
            // * 為了刪除 Evaluation Warning : The document was created with Spire.PDF for .NET.字串
            // * 第一次運行的時候運行SpireHelper.cs，修改Spire.License.dll中的密鑰
            // */
            ////PDFEditor.SpireHelper.ActivateMemoryPatching();

            //string pdfFileName = "sample.pdf";

            ////Console.WriteLine(ExtractTextFormPdf(filePath));
            //ReplaceTextOfPdf(pdfFileName);
        }

        //// using Spire.Pdf 達成替換字功能
        //public static void ReplaceTextOfPdf(string pdfFileName)
        //{
        //    string targetText = "申請";
        //    string replaceText = "替代";

        //    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pdfFileName);
        //    SpirePdf.PdfDocument file = new SpirePdf.PdfDocument();

        //    file.LoadFromFile(filePath);

        //    PdfBrush brush = new PdfSolidBrush(Color.Black);
        //    // 英文 font
        //    PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Arial", 12f, FontStyle.Regular));

        //    // 繁體中文 font
        //    PdfCjkStandardFont font1 = new PdfCjkStandardFont(PdfCjkFontFamily.MonotypeSungLight, 12f);

        //    //字的正方形框
        //    RectangleF rec;
        //    foreach (PdfPageBase eachPage in file.Pages)
        //    {
        //        PdfTextFindCollection collection = eachPage.FindText(targetText, TextFindParameter.IgnoreCase);

        //        foreach (PdfTextFind find in collection.Finds)
        //        {
        //            rec = find.Bounds;
        //            eachPage.Canvas.DrawRectangle(PdfBrushes.Yellow, rec);
        //            eachPage.Canvas.DrawString(replaceText, font1, brush, rec);
        //        }
        //    }

        //    file.SaveToFile(pdfFileName.Replace(".", "_fixed."));

        //}

        //public static string ExtractTextFormPdf(string pdfPath)
        //{

        //    StringBuilder text = new StringBuilder();
        //    try
        //    {
        //        iTextSharpPdf.PdfReader pdfReader = new iTextSharpPdf.PdfReader(pdfPath);
        //        int pageNumber = pdfReader.NumberOfPages;
        //        for (int i = 0; i < pageNumber; i += 1)
        //        {
        //            text.Append(iTextSharpPdf.parser.PdfTextExtractor.GetTextFromPage(pdfReader, i + 1));
        //        }
        //        pdfReader.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }

        //    return text.ToString();

        //}
    }
}
