using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class GetFileInfo
    {
        public static void Run()
        {
            // ExStart:GetFileInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetFileInfo.pdf");
            // Get document information
            DocumentInfo docInfo = pdfDocument.Info;
            // Show document information
            Console.WriteLine("Author: {0}", docInfo.Author);
            Console.WriteLine("Creation Date: {0}", docInfo.CreationDate);
            Console.WriteLine("Keywords: {0}", docInfo.Keywords);
            Console.WriteLine("Modify Date: {0}", docInfo.ModDate);
            Console.WriteLine("Subject: {0}", docInfo.Subject);
            Console.WriteLine("Title: {0}", docInfo.Title);
            // ExEnd:GetFileInfo
        }
    }
}