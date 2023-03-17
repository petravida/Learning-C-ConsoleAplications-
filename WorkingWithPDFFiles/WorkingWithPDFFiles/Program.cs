using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WorkingWithPDFFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string novadatoteka = ($"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\PDFFolder");
            //if (!Directory.Exists(novadatoteka))
            //{
            //    Directory.CreateDirectory(novadatoteka);
            //}
            //PdfDocument myFile = new PdfDocument();
            //PdfPage myPage = new PdfPage();
            //myFile.AddPage(myPage);
            //XGraphics graph = XGraphics.FromPdfPage(myPage);
            //XFont latters = new XFont("Comics", 25);
            //XPoint place = new XPoint(35, 35);
            //graph.DrawString("Trying to make my first PDF document.", latters, XBrushes.BlueViolet, place);
            //string fileName = "MyFirstPDFFile.pdf";
            //myFile.Save($"{novadatoteka}\\{fileName}");
            //Process.Start(fileName);

            //Console.ReadLine();

            //string txtFile = File.ReadAllText($"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\textzaprobu.txt");


            string pdfConvert = $"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\pdfconvert1";
            if (!Directory.Exists(pdfConvert))
            {
                Directory.CreateDirectory(pdfConvert);
            }
            string convertFile = "texttopdf.txt";
            string path = $"{pdfConvert}\\{convertFile}";
            if (!File.Exists(path))
            {
                File.Create(path);
                var stream = File.Create(path);
                stream.Flush();
                stream.Close();

            }
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    StreamWriter write = new StreamWriter(fs);
                    write.WriteLine("In this tutorial, we have learned a very easy way to convert text into a PDF file. " +
                        "We have demonstrated examples with code. We have converted text to PDF, and we have also generated a " +
                        "PDF from a txt file. Moreover, we have also learned to add watermarks to our documents.\r\n\r\nThere " +
                        "are multiple useful and interesting features provided by IronPDF, but it is impossible to cover them all here. " +
                        "For more details, please click here.\r\n\r\nIronPDF is a part of the IronSoftware suite. IronSuite has an array " +
                        "of interesting products including IronXL, IronBarcode, IronOCR, and IronWebScraper. I can assure you that you " +
                        "will find all of these products helpful. You can save up to 250% by purchasing the complete IronSuite, as you " +
                        "can currently get all five products for the price of just two. For more details, please click here.\r\n\r\nI hope this article " +
                        "was understandable and easy to follow. For any queries, feel free to contact us.");
                    write.Flush();
                    write.Close();



                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            PdfDocument converttxtpdf = new PdfDocument();
            PdfPage conPage = new PdfPage();
            converttxtpdf.AddPage(conPage);
            string text = File.ReadAllText($"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\pdfconvert1\\texttopdf.txt");
            string fileName = "MyFirstPDFFile.pdf";

            XGraphics gr = XGraphics.FromPdfPage(conPage);
            XPoint po = new XPoint(35, 35);
            XFont font = new XFont("Comics", 20);
            XRect rec = new XRect(35, 35, conPage.Width - 100, conPage.Height - 100);
            XTextFormatter form = new XTextFormatter(gr);
            form.DrawString(text, font, XBrushes.BlueViolet, rec);

            converttxtpdf.Save($"{pdfConvert}\\{fileName}");
            Process.Start(fileName);







        }

    }
}
