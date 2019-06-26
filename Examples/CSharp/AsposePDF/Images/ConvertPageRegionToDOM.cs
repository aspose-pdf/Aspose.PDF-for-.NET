using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System.Drawing;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ConvertPageRegionToDOM
    {
        public static void Run()
        {
            // ExStart:ConvertPageRegionToDOM         
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document document = new Document( dataDir + "AddImage.pdf");
            // Get rectangle of particular page region
            Aspose.Pdf.Rectangle pageRect = new Aspose.Pdf.Rectangle(20, 671, 693, 1125);
            // Set CropBox value as per rectangle of desired page region
            document.Pages[1].CropBox = pageRect;
            // Save cropped document into stream
            MemoryStream ms = new MemoryStream();
            document.Save(ms);
            // Open cropped PDF document and convert to image
            document = new Document(ms);
            // Create Resolution object
            Resolution resolution = new Resolution(300);
            // Create PNG device with specified attributes
            PngDevice pngDevice = new PngDevice(resolution);
            dataDir = dataDir + "ConvertPageRegionToDOM_out.png";
            // Convert a particular page and save the image to stream
            pngDevice.Process(document.Pages[1], dataDir);
            ms.Close();
            // ExEnd:ConvertPageRegionToDOM   
            Console.WriteLine("\nPage region converted to DOM successfully.\nFile saved at " + dataDir); 
        }
    }
}