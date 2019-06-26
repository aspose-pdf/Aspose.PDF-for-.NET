using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ReplaceImage
    {
        public static void Run()
        {
            // ExStart:ReplaceImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "ReplaceImage.pdf");

            // Replace a particular image
            pdfDocument.Pages[1].Resources.Images.Replace(1, new FileStream(dataDir + "aspose-logo.jpg", FileMode.Open));

            dataDir = dataDir + "ReplaceImage_out.pdf";
            // Save updated PDF file
            pdfDocument.Save(dataDir);
            // ExEnd:ReplaceImage
            Console.WriteLine("\nImage replaced successfully.\nFile saved at " + dataDir); 
        }
    }
}