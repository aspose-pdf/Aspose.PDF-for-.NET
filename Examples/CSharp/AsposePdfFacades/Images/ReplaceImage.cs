using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ReplaceImage
    {
        public static void Run()
        {
            // ExStart:ReplaceImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // Open input PDF
            PdfContentEditor pdfContentEditor = new PdfContentEditor();
            pdfContentEditor.BindPdf(dataDir+ "ReplaceImage.pdf");
            // Replace image on a particular page
            pdfContentEditor.ReplaceImage(1, 1, dataDir+ "aspose-logo.jpg");
            // Save output PDF
            pdfContentEditor.Save(dataDir+ "ReplaceImage_out.pdf");
            // ExEnd:ReplaceImage            
        }
    }
}