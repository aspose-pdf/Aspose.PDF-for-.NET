using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class ChangePassword
    {
        public static void Run()
        {
            // ExStart:ChangePassword
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();

            // Open document
            Document document = new Document(dataDir+ "ChangePassword.pdf", "owner");
            // Change password
            document.ChangePasswords("owner", "newuser", "newowner");
            dataDir = dataDir + "ChangePassword_out.pdf";
            // Save updated PDF
            document.Save(dataDir);
            // ExEnd:ChangePassword  
            Console.WriteLine("\nPDF file password changed successfully.\nFile saved at " + dataDir);
        }
    }
}