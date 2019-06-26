using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Devices;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class PagesToImages
    {
        public static void Run()
        {
            // ExStart:PagesToImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();
            
            // Open document
            Document pdfDocument = new Document(dataDir + "PagesToImages.pdf");

            for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                using (FileStream imageStream = new FileStream(dataDir + "image" + pageCount + "_out" + ".jpg", FileMode.Create))
                {
                    // Create JPEG device with specified attributes
                    // Width, Height, Resolution, Quality
                    // Quality [0-100], 100 is Maximum
                    // Create Resolution object
                    Resolution resolution = new Resolution(300);
                    
                    // JpegDevice jpegDevice = new JpegDevice(500, 700, resolution, 100);
                    JpegDevice jpegDevice = new JpegDevice(resolution, 100);

                    // Convert a particular page and save the image to stream
                    jpegDevice.Process(pdfDocument.Pages[pageCount], imageStream);

                    // Close stream
                    imageStream.Close();

                }
            }
            // ExEnd:PagesToImages
            System.Console.WriteLine("PDF pages are converted to individual images successfully!");
        }
        public static void SinglePageToImage()
        {
           
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir + "PagesToImages.pdf");
           
            using (FileStream imageStream = new FileStream(dataDir + "image" + 1 + ".jpg", FileMode.Create))
            {
                // Create JPEG device with specified attributes
                // Width, Height, Resolution, Quality
                // Quality [0-100], 100 is Maximum
                // Create Resolution object
                Resolution resolution = new Resolution(300);

                // JpegDevice jpegDevice = new JpegDevice(500, 700, resolution, 100);
                JpegDevice jpegDevice = new JpegDevice(resolution, 100);
                // ExStart:ConvertParticularPage
                // Convert a particular page and save the image to stream
                jpegDevice.Process(pdfDocument.Pages[1], imageStream);
                // ExEnd:ConvertParticularPage
                // Close stream
                imageStream.Close();
            }            
          
        }
    }
}