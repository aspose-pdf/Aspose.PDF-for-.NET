using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Attachments
{
    public class AddAttachment
    {
        public static void Run()
        {
            // ExStart:AddAttachment
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Attachments();
            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "AddAttachment.pdf");

            // Add attachment
            contentEditor.AddDocumentAttachment(dataDir+ "test.txt", "Attachment Description");

            // Save updated PDF
            contentEditor.Save(dataDir+ "AddAttachment_out.pdf");
            // ExEnd:AddAttachment
        }
    }
}