using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Devices;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class PageToPNG
    {
        public static void Run()
        {
            // ExStart:PageToPNG         
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir + "PageToPNG.pdf");


            using (FileStream imageStream = new FileStream(dataDir + "aspose-logo.png", FileMode.Create))
            {
                // Create Resolution object
                Resolution resolution = new Resolution(300);
                // Create PNG device with specified attributes (Width, Height, Resolution)
                PngDevice pngDevice = new PngDevice(resolution);

                // Convert a particular page and save the image to stream
                pngDevice.Process(pdfDocument.Pages[1], imageStream);

                // Close stream
                imageStream.Close();
            }
            // ExEnd:PageToPNG    
        }
    }
}