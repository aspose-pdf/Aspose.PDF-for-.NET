using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class SetSubmitButtonURL
    {
        public static void Run()
        {
            // ExStart:SetSubmitButtonURL
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            FormEditor form = new FormEditor();
            // Open the document and create a FormEditor object
            form.BindPdf(dataDir + "input.pdf");
            // Set submit URL
            form.SetSubmitUrl("submitbutton", "http:// Www.aspose.com");
            // Save update document
            form.Save(dataDir + "SetSubmitButtonURL_out.pdf"); 
            // ExEnd:SetSubmitButtonURL
        }        
    }
}