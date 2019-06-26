using System.IO;
using System;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class AddTextImagesUsingPdfFileMend
    {
        public static void Run()
        {
            // ExStart:AddTextImagesUsingPdfFileMend
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Specify input and output PDF file paths
            string inputFile = dataDir + "inFile.pdf";
            string outputFile = dataDir + "AddTextImagesUsingPdfFileMend_out.pdf";

            // Specify image file path
            string imageName = dataDir + "aspose-logo.jpg";

            // Create file streams for all of the files to be used in the example           
            FileStream inImgStream = new FileStream(@imageName, FileMode.Open);
            FileStream outputStream = new FileStream(@outputFile, FileMode.Create);

            Document doc = new Document(inputFile);
            // Create instance of PdfFileMend class
            PdfFileMend mendor = new PdfFileMend(doc);

            // Add image to the input PDF file on page number 1 at specified location
            mendor.AddImage(inImgStream, 1, 50, 50, 100, 100);

            // Create new FormattedText type object to add text in the PDF file
            FormattedText ft = new FormattedText(
            "PdfFileMend testing! 0 rotation.",
            System.Drawing.Color.FromArgb(0, 200, 0),
            FontStyle.TimesRoman,
            EncodingType.Winansi,
            false,
            12);

            // Add text in the existing PDF file
            mendor.AddText(ft, 1, 50, 100, 100, 200);

            // Claose the PdfFileMend type object
            mendor.Close();
            // Close output file stream
            outputStream.Close();
            // ExEnd:AddTextImagesUsingPdfFileMend                      
        }
    }
}