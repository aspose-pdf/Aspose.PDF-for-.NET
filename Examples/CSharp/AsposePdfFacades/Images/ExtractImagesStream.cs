using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ExtractImagesStream
    {
        public static void Run()
        {
            // ExStart:ExtractImagesStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // Open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractImages-Stream.pdf");

            // Extract images
            pdfExtractor.ExtractImage();
            // Get all the extracted images
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
            // ExEnd:ExtractImagesStream
        }
    }
}