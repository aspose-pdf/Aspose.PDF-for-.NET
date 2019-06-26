using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Attachments
{
    public class DeleteAllAttachments
    {
        public static void Run()
        {
            // ExStart:DeleteAllAttachments
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Attachments();
            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "DeleteAllAttachments.pdf");

            // Delete attachments
            contentEditor.DeleteAttachments();

            // Save updated PDF
            contentEditor.Save(dataDir+ "DeleteAllAttachments_out.pdf");
            // ExEnd:DeleteAllAttachments            
        }
    }
}