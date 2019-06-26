using System;
using System.IO;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class EncryptFile
    {
        public static void Run()
        {
            // ExStart:EncryptFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
            // Create PdfFileSecurity object 
            PdfFileSecurity fileSecurity = new PdfFileSecurity();
            fileSecurity.BindPdf(dataDir + "Encrypt.pdf");
            // Encrypt file using 256-bit encryption
            fileSecurity.EncryptFile("user", "owner", DocumentPrivilege.Print, KeySize.x256, Algorithm.AES);
            fileSecurity.Save(dataDir + "Encrypt_out.pdf");
            // ExEnd:EncryptFile   
           
        }
    }
}