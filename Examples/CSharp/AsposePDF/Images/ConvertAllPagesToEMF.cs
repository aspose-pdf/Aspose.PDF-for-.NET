using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Devices;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ConvertAllPagesToEMF
    {
        public static void Run()
        {
            // ExStart:ConvertAllPagesToEMF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "ConvertAllPagesToEMF.pdf");

            for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                using (FileStream imageStream = new FileStream(dataDir + "image" + pageCount + "_out" + ".emf", FileMode.Create))
                {
                    // Create Resolution object
                    Resolution resolution = new Resolution(300);
                    // Create PNG device with specified attributes
                    // Width, Height, Resolution
                    EmfDevice emfDevice = new EmfDevice(500, 700, resolution);

                    // Convert a particular page and save the image to stream
                    emfDevice.Process(pdfDocument.Pages[pageCount], imageStream);

                    // Close stream
                    imageStream.Close();

                }
            }
            // ExEnd:ConvertAllPagesToEMF
            System.Console.WriteLine("PDF pages are converted to EMF successfully!");
        }
    }
}