using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.WorkingDocument
{
    public class GetFileInfo
    {
        public static void Run()
        {
            // ExStart:GetFileInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();
            // Open document
            PdfFileInfo fileInfo = new PdfFileInfo(dataDir+ "GetFileInfo.pdf");
            // Get PDF information
            Console.WriteLine("Subject: {0}", fileInfo.Subject);
            Console.WriteLine("Title: {0}", fileInfo.Title);
            Console.WriteLine("Keywords: {0}", fileInfo.Keywords);
            Console.WriteLine("Creator: {0}", fileInfo.Creator);
            Console.WriteLine("Creation Date: {0}", fileInfo.CreationDate);
            Console.WriteLine("Modification Date: {0}", fileInfo.ModDate);
            // Find whether is it valid PDF and it is encrypted as well
            Console.WriteLine("Is Valid PDF: {0}", fileInfo.IsPdfFile);
            Console.WriteLine("Is Encrypted: {0}", fileInfo.IsEncrypted);
            // ExEnd:GetFileInfo
            
        }
    }
}