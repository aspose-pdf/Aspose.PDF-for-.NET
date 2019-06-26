using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class AddFooter
    {
        public static void Run()
        {
            // ExStart:AddFooter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            // Create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();

            // Open Document
            fileStamp.BindPdf(dataDir + "AddFooter.pdf");

           // Create formatted text for page number
            FormattedText formattedText = new FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, false, 14);

            // Add footer
            fileStamp.AddFooter(formattedText, 10);
            
            // Save updated PDF file
            fileStamp.Save(dataDir + "AddFooter_out.pdf");

            // Close fileStamp
            fileStamp.Close();
            // ExEnd:AddFooter
            
            
        }
    }
}