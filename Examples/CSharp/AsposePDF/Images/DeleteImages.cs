using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class DeleteImages
    {
        public static void Run()
        {
            // ExStart:DeleteImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "DeleteImages.pdf");

            // Delete a particular image
            pdfDocument.Pages[1].Resources.Images.Delete(1);

            dataDir = dataDir + "DeleteImages_out.pdf";
            // Save updated PDF file
            pdfDocument.Save(dataDir);
            // ExEnd:DeleteImages
            Console.WriteLine("\nImages deleted successfully.\nFile saved at " + dataDir); 
        }
    }
}