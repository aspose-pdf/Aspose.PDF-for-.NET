using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class AddImageFooter
    {
        public static void Run()
        {
            // ExStart:AddImageFooter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            // Create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();

            // Open Document
            fileStamp.BindPdf(dataDir + "AddImage-Footer.pdf");

            // Add footer
            fileStamp.AddFooter(new FileStream(dataDir+ "aspose-logo.jpg", FileMode.Open), 10);

            // Save updated PDF file
            fileStamp.Save(dataDir + "AddImage-Footer_out.pdf");

            // Close fileStamp
            fileStamp.Close();
            // ExEnd:AddImageFooter
            
        }
    }
}