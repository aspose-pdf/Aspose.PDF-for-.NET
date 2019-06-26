using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class FastShrinkImages
    {
        public static void Run()
        {
            // ExStart:FastShrinkImages
            // Initialize Time
            var time = DateTime.Now.Ticks;
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();
            // Open document
            Document pdfDocument = new Document(dataDir + "Shrinkimage.pdf");
            // Initialize OptimizationOptions
            var optimizeOptions = new Pdf.Optimization.OptimizationOptions();
            // Set CompressImages option
            optimizeOptions.ImageCompressionOptions.CompressImages = true;
            // Set ImageQuality option
            optimizeOptions.ImageCompressionOptions.ImageQuality = 75;
            // Set Imagae Compression Version to fast 
            optimizeOptions.ImageCompressionOptions.Version = Pdf.Optimization.ImageCompressionVersion.Fast;
            // Optimize PDF document using OptimizationOptions
            pdfDocument.OptimizeResources(optimizeOptions);
            dataDir = dataDir + "FastShrinkImages_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            Console.WriteLine("Ticks: {0}", DateTime.Now.Ticks - time);
            // ExEnd:FastShrinkImages

            Console.WriteLine("\nImage fast shrinked successfully.\nFile saved at " + dataDir);
            
        }
    }
}
