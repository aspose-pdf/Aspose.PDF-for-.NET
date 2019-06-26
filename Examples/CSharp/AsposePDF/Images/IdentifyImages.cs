using System.IO;
using Aspose.Pdf;
using System.Drawing.Imaging;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class IdentifyImages
    {
        public static void Run()
        {
            // ExStart:IdentifyImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Counter for grayscale images
            int grayscaled = 0;
            // Counter for RGB images
            int rgd = 0;

            using (Document document = new Document(dataDir + "ExtractImages.pdf"))
            {
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine("--------------------------------");
                    ImagePlacementAbsorber abs = new ImagePlacementAbsorber();
                    page.Accept(abs);
                    // Get the count of images over specific page
                    Console.WriteLine("Total Images = {0} over page number {1}", abs.ImagePlacements.Count, page.Number);
                    // Document.Pages[29].Accept(abs);
                    int image_counter = 1;
                    foreach (ImagePlacement ia in abs.ImagePlacements)
                    {
                        ColorType colorType = ia.Image.GetColorType();
                        switch (colorType)
                        {
                            case ColorType.Grayscale:
                                ++grayscaled;
                                Console.WriteLine("Image {0} is GrayScale...", image_counter);
                                break;
                            case ColorType.Rgb:
                                ++rgd;
                                Console.WriteLine("Image {0} is RGB...", image_counter);
                                break;
                        }
                        image_counter += 1;
                    }
                }
            }
            // ExEnd:IdentifyImages
           
            
        }
    }
}