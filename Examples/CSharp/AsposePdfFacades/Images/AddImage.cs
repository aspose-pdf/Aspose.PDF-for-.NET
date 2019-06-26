using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class AddImage
    {
        public static void Run()
        {
            // ExStart:AddImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();

            // Open document
            PdfFileMend mender = new PdfFileMend();

            // Create PdfFileMend object to add text
            mender.BindPdf(dataDir + "AddImage.pdf");

           // Add image in the PDF file
            mender.AddImage(dataDir+ "aspose-logo.jpg", 1, 100, 600, 200, 700);

            // Save changes
            mender.Save(dataDir + "AddImage_out.pdf");

            // Close PdfFileMend object
            mender.Close();
            // ExEnd:AddImage
        }
    }
}