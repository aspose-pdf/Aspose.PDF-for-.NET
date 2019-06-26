using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ResizeImages
    {
        public static void Run()
        {
            // ExStart:ResizeImages
            // Initialize Time
            var time = DateTime.Now.Ticks;
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();
            // Open document
            Document pdfDocument = new Document(dataDir + "ResizeImage.pdf");
            // Initialize OptimizationOptions
            var optimizeOptions = new Pdf.Optimization.OptimizationOptions();            // Set CompressImages option            optimizeOptions.ImageCompressionOptions.CompressImages = true;            // Set ImageQuality option             optimizeOptions.ImageCompressionOptions.ImageQuality = 75;            // Set ResizeImage option            optimizeOptions.ImageCompressionOptions.ResizeImages = true;            // Set MaxResolution option            optimizeOptions.ImageCompressionOptions.MaxResolution = 300;
            // Optimize PDF document using OptimizationOptions
            pdfDocument.OptimizeResources(optimizeOptions);
            dataDir = dataDir + "ResizeImages_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:ResizeImages

            Console.WriteLine("\nImage resized successfully.\nFile saved at " + dataDir);

        }
    }
}
