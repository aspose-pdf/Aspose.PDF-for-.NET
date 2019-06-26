using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System.Drawing;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ConvertToBMP
    {
        public static void Run()
        {
            // ExStart:ConvertToBMP         
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir + "AddImage.pdf");

            for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                using (FileStream imageStream = new FileStream("image" + pageCount + "_out" + ".bmp", FileMode.Create))
                {
                    // Create Resolution object
                    Resolution resolution = new Resolution(300);
                    // Create BMP device with specified attributes
                    // Width, Height, Resolution, PageSize

                    BmpDevice bmpDevice = new BmpDevice(resolution);
                    // Convert a particular page and save the image to stream
                    bmpDevice.Process(pdfDocument.Pages[pageCount], imageStream);
                    // Close stream
                    imageStream.Close();
                }
            } 
            // ExEnd:ConvertToBMP   
            Console.WriteLine("\nPDF file converted to bmp successfully!"); 
        }
    }
}