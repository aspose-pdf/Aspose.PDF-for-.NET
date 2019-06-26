using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class FillFormFieldF
    {
        public static void Run()
        {
            // ExStart:FillFormFieldF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            // Create Form Object
            Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form();

            // Open Document
            pdfForm.BindPdf(dataDir + "FormField.pdf");

            // Fill the field "textfield" with "Mike".
            pdfForm.FillField("textfield", "Mike");                    
            
            // Save updated file
            pdfForm.Save( dataDir + "FillFormFieldF_out.pdf");
            // ExEnd:FillFormFieldF
        }
    }
}