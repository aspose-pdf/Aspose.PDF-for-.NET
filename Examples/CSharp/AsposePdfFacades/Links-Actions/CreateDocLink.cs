using System.IO;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.LinksActions
{
    public class CreateDocLink
    {
        public static void Run()
        {
            // ExStart:CreateDocLink
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_LinksActions();

            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf( dataDir + "CreateDocumentLink.pdf");

            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 200, 200);

            // Create application link
            contentEditor.CreatePdfDocumentLink(rectangle, dataDir + "RemoveOpenAction.pdf", 1, 4);

            // Save updated PDF
            contentEditor.Save( dataDir + "CreateDocLink_out.pdf");           
            // ExEnd:CreateDocLink
                     
        }
    }
}