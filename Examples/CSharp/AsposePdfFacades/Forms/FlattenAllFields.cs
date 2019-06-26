using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class FlattenAllFields
    {
        public static void Run()
        {
            // ExStart:FlattenAllFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form();
            // Open Document
            pdfForm.BindPdf(dataDir + "input.pdf");

            // Flatten fields
            pdfForm.FlattenAllFields();

            // Save output
            pdfForm.Save( dataDir + "FlattenAllFields_out.pdf");
            // ExEnd:FlattenAllFields
        }
    }
}