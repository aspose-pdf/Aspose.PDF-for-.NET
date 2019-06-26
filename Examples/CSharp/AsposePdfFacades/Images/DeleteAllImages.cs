using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class DeleteAllImages
    {
        public static void Run()
        {
            // ExStart:DeleteAllImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // Open PDF file
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "DeleteAllImages.pdf");

            // Delete the images from the particular page
            contentEditor.DeleteImage();

            // Save output PDF
            contentEditor.Save(dataDir+ "DeleteAllImages_out.pdf");
            // ExEnd:DeleteAllImages
            
        }
    }
}