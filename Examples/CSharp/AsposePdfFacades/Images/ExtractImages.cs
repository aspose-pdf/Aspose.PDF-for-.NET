using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ExtractImages
    {
        public static void Run()
        {
            // ExStart:ExtractImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();

            // Open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractImages.pdf");

            // Extract all the images
            pdfExtractor.ExtractImage();

            // Get all the extracted images
            while (pdfExtractor.HasNextImage())
                pdfExtractor.GetNextImage(dataDir+ DateTime.Now.Ticks.ToString() + "_out.jpg");
            // ExEnd:ExtractImages            
            
        }
    }
}