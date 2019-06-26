using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class SetFileInfo
    {
        public static void Run()
        {
            // ExStart:SetFileInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "SetFileInfo.pdf");

            // Specify document information
            DocumentInfo docInfo = new DocumentInfo(pdfDocument);

            docInfo.Author = "Aspose";
            docInfo.CreationDate = DateTime.Now;
            docInfo.Keywords = "Aspose.Pdf, DOM, API";
            docInfo.ModDate = DateTime.Now;
            docInfo.Subject = "PDF Information";
            docInfo.Title = "Setting PDF Document Information";

            dataDir = dataDir + "SetFileInfo_out.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:SetFileInfo
            Console.WriteLine("\nFile informations setup successfully.\nFile saved at " + dataDir);
            
        }
    }
}