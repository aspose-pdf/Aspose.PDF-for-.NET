using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class RotatingStamp
    {
        public static void Run()
        {
            // ExStart:RotatingStamp
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Set path of the image to be set as watermark
            string imageFile = dataDir + "aspose-logo.jpg";

            // Set input file path
            string inFile = dataDir + "inFile.pdf";

            // Set output file path
            string outFile = dataDir + "RotatingStamp_out.pdf";

            // Create PdfFileInfo object to get height and width of the pages
            PdfFileInfo fileInfo = new PdfFileInfo(inFile);

            // Create Stamp object
            Aspose.Pdf.Facades.Stamp aStamp = new Aspose.Pdf.Facades.Stamp();

            // Bind image file with the Stamp object
            aStamp.BindImage(imageFile);

            // Specify whether the stamp will be added as a background or not
            aStamp.IsBackground = false;

            // Specifies at which pages to add the watermark
            aStamp.Pages = new int[] { 1 };

            // Specifies the watermark rotation - rotate at 90 degrees the stamp is rotated about the center point of the stamp object
            aStamp.Rotation = 90;

            // Specifies the position of stamp - lower left corner of the stamp
            aStamp.SetOrigin(fileInfo.GetPageWidth(1) / 2, fileInfo.GetPageHeight(1) / 2);

            // Set the size of the watermark
            aStamp.SetImageSize(100, 100);

            Document doc = new Document(inFile);
            // Create PdfFileStamp class to bind input and output files
            PdfFileStamp stamper = new PdfFileStamp(doc);

            // Add the stamp in the PDF file
            stamper.AddStamp(aStamp);

            // Close the PdfFileStamp object
            stamper.Close();
            // ExEnd:RotatingStamp                      
        }
    }
}