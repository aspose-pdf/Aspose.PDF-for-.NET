using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Attachments
{
    public class GetAttachmentNames
    {
        public static void Run()
        {
            // ExStart:GetAttachmentNames
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Attachments();
            // Open document
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "GetAttachmentNames.pdf");

            // Extract attachments
            pdfExtractor.ExtractAttachment();

            // Get attachment names
            System.Collections.IList attachmentNames = (System.Collections.IList)pdfExtractor.GetAttachNames();

            foreach (string attachmentName in attachmentNames)
                Console.WriteLine("Name : {0}", attachmentName);
            // ExEnd:GetAttachmentNames
            
        }
    }
}