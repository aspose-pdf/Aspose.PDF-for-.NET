using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class Encrypt
    {
        public static void Run()
        {
            // ExStart:Encrypt
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();
            // Open document
            Document document = new Document(dataDir+ "Encrypt.pdf");
            // Encrypt PDF
            document.Encrypt("user", "owner", 0, CryptoAlgorithm.RC4x128);
            dataDir = dataDir + "Encrypt_out.pdf";
            // Save updated PDF
            document.Save(dataDir);
            // ExEnd:Encrypt   
            Console.WriteLine("\nPDF file encrypted successfully.\nFile saved at " + dataDir);
        }
    }
}