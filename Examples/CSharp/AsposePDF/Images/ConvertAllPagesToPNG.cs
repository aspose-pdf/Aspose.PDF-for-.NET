using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ConvertAllPagesToPNG
    {
        public static void Run()
        {
            // ExStart:ConvertAllPagesToPNG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir + "ConvertAllPagesToPNG.pdf");


            for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                using (FileStream imageStream = new FileStream(dataDir + "image" + pageCount + "_out" + ".png", FileMode.Create))
                {
                    // Create PNG device with specified attributes
                    // Width, Height, Resolution, Quality
                    // Quality [0-100], 100 is Maximum
                    // Create Resolution object
                    Resolution resolution = new Resolution(300);
                    PngDevice pngDevice = new PngDevice(resolution);

                    // Convert a particular page and save the image to stream
                    pngDevice.Process(pdfDocument.Pages[pageCount], imageStream);

                    // Close stream
                    imageStream.Close();
                }
            }
            // ExEnd:ConvertAllPagesToPNG
            System.Console.WriteLine("PDF pages are converted to PNG successfully!");
        }      

    }
}