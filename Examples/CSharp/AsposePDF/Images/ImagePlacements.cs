using System.IO;
using Aspose.Pdf;
using System;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ImagePlacements
    {
        public static void Run()
        {
            // ExStart:ImagePlacements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();


            // Load the source PDF document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir+ "ImagePlacement.pdf");
            ImagePlacementAbsorber abs = new ImagePlacementAbsorber();
            
            // Load the contents of first page
            // ExStart:ExtractImageFromIndividualPage
            doc.Pages[1].Accept(abs);
            // ExEnd:ExtractImageFromIndividualPage
            foreach (ImagePlacement imagePlacement in abs.ImagePlacements)
            {
                // Get image properties
                Console.Out.WriteLine("image width:" + imagePlacement.Rectangle.Width);
                Console.Out.WriteLine("image height:" + imagePlacement.Rectangle.Height);
                Console.Out.WriteLine("image LLX:" + imagePlacement.Rectangle.LLX);
                Console.Out.WriteLine("image LLY:" + imagePlacement.Rectangle.LLY);
                Console.Out.WriteLine("image horizontal resolution:" + imagePlacement.Resolution.X);
                Console.Out.WriteLine("image vertical resolution:" + imagePlacement.Resolution.Y);

                // Retrieve image with visible dimensions
                Bitmap scaledImage;
                using (MemoryStream imageStream = new MemoryStream())
                {
                    // Retrieve image from resources
                    imagePlacement.Image.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                    Bitmap resourceImage = (Bitmap)Bitmap.FromStream(imageStream);
                    // Create bitmap with actual dimensions
                    scaledImage = new Bitmap(resourceImage, (int)imagePlacement.Rectangle.Width, (int)imagePlacement.Rectangle.Height);
                }
            }
            // ExEnd:ImagePlacements            
        }
    }
}