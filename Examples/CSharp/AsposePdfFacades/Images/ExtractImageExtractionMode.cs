using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ExtractImageExtractionMode
    {
        public static void Run()
        {
            // ExStart:ExtractImageExtractionMode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // Open input PDF
            PdfExtractor extractor = new PdfExtractor();
            extractor.BindPdf(dataDir+ "ExtractImageExtractionMode.pdf");

            // Specify Image Extraction Mode
            extractor.ExtractImageMode = ExtractImageMode.DefinedInResources;

            // Extract Images based on Image Extraction Mode
            extractor.ExtractImage();

            // Get all the extracted images
            while (extractor.HasNextImage())
            {
                extractor.GetNextImage(dataDir+ DateTime.Now.Ticks.ToString() + "_out.png" , System.Drawing.Imaging.ImageFormat.Png);
            }
            // ExEnd:ExtractImageExtractionMode
        }
    }
}