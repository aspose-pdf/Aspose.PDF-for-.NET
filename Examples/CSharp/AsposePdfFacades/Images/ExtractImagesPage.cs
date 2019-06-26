using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ExtractImagesPage
    {
        public static void Run()
        {
            // ExStart:ExtractImagesPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();

            // Open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractImages-Page.pdf");

            // Set StartPage and EndPage properties to the page number to
            // You want to extract images from
            pdfExtractor.StartPage = 2;
            pdfExtractor.EndPage = 2;

            // Extract images
            pdfExtractor.ExtractImage();
            // Get extracted images
            while (pdfExtractor.HasNextImage())
            {
                // Read image into memory stream
                MemoryStream memoryStream = new MemoryStream();
                pdfExtractor.GetNextImage(memoryStream);

                // Write to disk, if you like, or use it otherwise.
                FileStream fileStream = new
                FileStream(dataDir+ DateTime.Now.Ticks.ToString() + "_out.jpg", FileMode.Create);
                memoryStream.WriteTo(fileStream);
                fileStream.Close();
            }
            // ExEnd:ExtractImagesPage
            
        }
    }
}