using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class PdfContainsTextOrImages
    {
        public static void Run()
        {
            // ExStart:PdfContainsTextOrImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Instantiate a memoryStream object to hold the extracted text from Document
            MemoryStream ms = new MemoryStream();
            // Instantiate PdfExtractor object
            PdfExtractor extractor = new PdfExtractor();

            // Bind the input PDF document to extractor
            extractor.BindPdf(dataDir + "FilledForm.pdf");
            // Extract text from the input PDF document
            extractor.ExtractText();

            bool containsText = false;
            bool containsImage = false;
            // Save the extracted text to a text file
            extractor.GetText(ms);
            // Check if the MemoryStream length is greater than or equal to 1
            if (ms.Length >= 1)
                containsText = true;

            // Extract images from the input PDF document
            extractor.ExtractImage();

            // Calling HasNextImage method in while loop. When images will finish, loop will exit
            if (extractor.HasNextImage())
                containsImage = true;

            // Now find out whether this PDF is text only or image only
            if (containsText == true && containsImage == false)
                Console.WriteLine("PDF contains text only");
            else if (containsText == false && containsImage == true)
                Console.WriteLine("PDF contains image only");
            else if (containsText == true && containsImage == true)
                Console.WriteLine("PDF contains both text and image");
            else if (containsText == false && containsImage == false)
                Console.WriteLine("PDF contains neither text or nor image");
            // ExEnd:PdfContainsTextOrImages                      
        }
    }
}