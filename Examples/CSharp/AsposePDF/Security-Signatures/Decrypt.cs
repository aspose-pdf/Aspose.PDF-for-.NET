using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class Decrypt
    {
        public static void Run()
        {
            // ExStart:Decrypt
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();
            // Open document
            Document document = new Document(dataDir+ "Decrypt.pdf", "password");
            // Decrypt PDF
            document.Decrypt();
            dataDir = dataDir + "Decrypt_out.pdf";
            // Save updated PDF
            document.Save(dataDir);
            // ExEnd:Decrypt
            Console.WriteLine("\nPDF file decrypted successfully.\nFile saved at " + dataDir);
            
        }
    }
}