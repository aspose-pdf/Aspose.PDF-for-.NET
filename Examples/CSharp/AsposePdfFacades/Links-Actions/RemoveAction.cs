using System.IO;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.LinksActions
{
    public class RemoveAction
    {
        public static void Run()
        {
            // ExStart:RemoveAction
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_LinksActions();
           
            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir + "RemoveOpenAction.pdf");

            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 200, 200);

            // Create application link
            contentEditor.RemoveDocumentOpenAction();

            // Save updated PDF
            contentEditor.Save( dataDir + "RemoveOpenAction_out.pdf");
            // ExEnd:RemoveAction                        
        }
    }
}