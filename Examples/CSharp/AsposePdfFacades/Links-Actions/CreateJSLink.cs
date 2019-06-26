using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.LinksActions
{
    public class CreateJSLink
    {
        public static void Run()
        {
            // ExStart:CreateJSLink
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_LinksActions();
          
            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf( dataDir + "CreateApplicationLink.pdf");

            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 200, 200);

            // Create application link
            contentEditor.CreateJavaScriptLink("app.alert('Welcome to Aspose!');", rectangle, 1,  System.Drawing.Color.Red);

            // Save updated PDF
            contentEditor.Save( dataDir + "CreateJSLink_out.pdf");
            // ExEnd:CreateJSLink                                 
        }
    }
}