using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class AddImageHeader
    {
        public static void Run()
        {
            // ExStart:AddImageHeader
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            // Create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();

            // Open Document
            fileStamp.BindPdf(dataDir + "AddImage-Header.pdf");

            // Add Header
            fileStamp.AddHeader(new FileStream(dataDir + "AddImageHeader.jpg", FileMode.Open), 10);

            // Save updated PDF file
            fileStamp.Save(dataDir + "AddImage-Header_out.pdf");

            // Close fileStamp
            fileStamp.Close();
            // ExEnd:AddImageHeader
            
        }
    }
}