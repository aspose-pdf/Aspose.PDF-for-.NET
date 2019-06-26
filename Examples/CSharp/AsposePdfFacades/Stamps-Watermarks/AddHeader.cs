using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class AddHeader
    {
        public static void Run()
        {
            // ExStart:AddHeader
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            // Create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();

            // Open Document
            fileStamp.BindPdf(dataDir + "AddHeader.pdf");
         
            // Create formatted text for page number
            FormattedText formattedText = new FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, false, 14);

            // Add header
            fileStamp.AddHeader(formattedText, 10);
           
            // Save updated PDF file
            fileStamp.Save(dataDir + "AddHeader_out.pdf");
            
            // Close fileStamp
            fileStamp.Close();
            // ExEnd:AddHeader
        }
    }
}