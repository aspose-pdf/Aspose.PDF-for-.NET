using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Devices;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class PageToEMF
    {
        public static void Run()
        {
            // ExStart:PageToEMF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "PageToEMF.pdf");

            using (FileStream imageStream = new FileStream(dataDir + "image_out.emf", FileMode.Create))
            {
                // Create Resolution object
                Resolution resolution = new Resolution(300);
                // Create EMF device with specified attributes
                // Width, Height, Resolution
                EmfDevice emfDevice = new EmfDevice(500, 700, resolution);

                // Convert a particular page and save the image to stream
                emfDevice.Process(pdfDocument.Pages[1], imageStream);

                // Close stream
                imageStream.Close();
            }
            // ExEnd:PageToEMF
            System.Console.WriteLine("PDF page is converted to EMF successfully!");
        }
    }
}