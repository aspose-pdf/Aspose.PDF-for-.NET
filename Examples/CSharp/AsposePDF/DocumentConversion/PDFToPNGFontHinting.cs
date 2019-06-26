using Aspose.Pdf.Devices;
using System;
using System.IO;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToPNGFontHinting
    {
        public static void Run()
        {
            try
            {
                // ExStart:1
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
                // Open document
                Document pdfDocument = new Document(dataDir + "input.pdf");
                // Create Aspose.Pdf.RenderingOptions to enable font hinting
                RenderingOptions opts = new RenderingOptions();
                opts.UseFontHinting = true;
                
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
                        // Set predefined rendering options
                        pngDevice.RenderingOptions = opts;

                        // Convert a particular page and save the image to stream
                        pngDevice.Process(pdfDocument.Pages[pageCount], imageStream);

                        // Close stream
                        imageStream.Close();
                    }
                }
                // ExEnd:1
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
