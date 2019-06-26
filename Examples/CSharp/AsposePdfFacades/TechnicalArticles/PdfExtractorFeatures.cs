using System.IO;
using System;
using System.Collections;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class PdfExtractorFeatures
    {
        public static void Run()
        {
            // ExStart:PdfExtractorFeatures
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create an instance of PdfExtractor class
            PdfExtractor extractor = new PdfExtractor();

            // Set PDF file password
            extractor.Password = "";
            // Specify start and end pages of the PDF
            extractor.StartPage = 1;
            extractor.EndPage = 10;

            // Bind PDF file with the extractor object
            extractor.BindPdf( dataDir +  "inFile.pdf");
            // Extract all text from the PDF
            extractor.ExtractText();
            // Save extracted text in a text file
            extractor.GetText(dataDir + "PdfExtractorFeatures_text_out.txt");

            // Text of individual pages can also be saved individually in single text files
            if (extractor.HasNextPageText())
            {
                extractor.GetNextPageText(dataDir + DateTime.Now.Ticks.ToString() + "_out.txt");
            }

            // Extract images from PDF file
            extractor.ExtractImage();
            // Save each individual image in an image file
            if (extractor.HasNextImage())
            {
                extractor.GetNextImage(dataDir + DateTime.Now.Ticks.ToString() + "_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            // Extract attachments
            extractor.ExtractAttachment();           
            extractor.GetAttachment(dataDir);
            // ExEnd:PdfExtractorFeatures                      
        }
    }
}