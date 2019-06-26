using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class DetermineCorrectPassword
    {
        public static void Run()
        {
            // ExStart:DetermineCorrectPassword
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();            
            // Load source PDF file
            PdfFileInfo info = new PdfFileInfo();
            info.BindPdf(dataDir + "IsPasswordProtected.pdf");
            // Determine if the source PDF is encrypted
            Console.WriteLine("File is password protected " + info.IsEncrypted);
            String[] passwords = new String[5] { "test", "test1", "test2", "test3", "sample" };
            for (int passwordcount = 0; passwordcount < passwords.Length; passwordcount++)
            {
                try
                {
                    Document doc = new Document(dataDir + "IsPasswordProtected.pdf", passwords[passwordcount]);
                    if (doc.Pages.Count > 0)
                        Console.WriteLine("Number of Page in document are = " + doc.Pages.Count);
                }
                catch (InvalidPasswordException)
                {
                    Console.WriteLine("Password = " + passwords[passwordcount] + "  is not correct");
                }
            }
            // ExEnd:DetermineCorrectPassword
            
        }
    }
}