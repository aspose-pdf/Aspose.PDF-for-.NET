using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class SetJSPushButton
    {
        public static void Run()
        {
            // ExStart:SetJSPushButton
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            FormEditor form = new FormEditor();
            // Open the document and create a FormEditor object
            form.BindPdf(dataDir + "input.pdf");
            // Set JavaScript
            form.SetFieldScript("pushbutton", "app.alert('Hello World!');");
            // Save update document
            form.Save(dataDir + "SetJSPushButton_out.pdf");
            // ExEnd:SetJSPushButton
        }        
    }
}