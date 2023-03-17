using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PRVI DIO


            //string firstFolder = $"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\newone";
            //if (!Directory.Exists(firstFolder))
            //{
            //    Directory.CreateDirectory(firstFolder);
            //}

            //string firstFile = "CreatedFile.txt";
            //string filePlace = $"{firstFolder}\\{firstFile}";
            //if (!File.Exists(filePlace))
            //{
            //    File.Create(filePlace);
            //    var stream = File.Create(filePlace);
            //    stream.Flush();
            //    stream.Close();
            //}
            //try
            //{
            //    using (FileStream fs = new FileStream(filePlace, FileMode.Open))
            //    {
            //        StreamWriter writer = new StreamWriter(fs);
            //        writer.Write("Need to write something.");
            //        writer.Flush();
            //        writer.Close();

            //        Console.WriteLine("Lines written to file successfully.");
            //    }
            //}

            //catch (Exception err)
            //{
            //    Console.WriteLine(err.Message);
            //}

            //Console.ReadLine();

            //DRUGI DIO
            //string text = File.ReadAllText($"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\newone\\CreatedFile.txt");
            //Console.WriteLine(text);
            //Console.ReadLine();



            //TRECI DIO



            //string FilePath = $"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\newone";
            //string secondFile = "CreatedFile1.txt";
            //string filePlace = $"{FilePath}\\{secondFile}";
            //if (!File.Exists(filePlace))
            //{
            //    File.Create(filePlace);
            //    var stream = File.Create(filePlace);
            //    stream.Flush();
            //    stream.Close();
            //}

            
            string inputFilePath = $"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\newone\\CreatedFile.txt";
            string outputFilePath = $"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\newone\\CreatedFile1.txt";


            using (FileStream inputFs = File.OpenRead(inputFilePath))
            using (StreamReader sr = new StreamReader(inputFs))
            {
                string text = sr.ReadToEnd();


                text = text.Replace("I need", "Again, I need");


                sr.Close();


                using (FileStream outputFs = File.Create(outputFilePath))
                using (StreamWriter sw = new StreamWriter(outputFs))
                {
                    sw.Write(text);


                    sw.Close();
                }
            }


        }


    }
}
