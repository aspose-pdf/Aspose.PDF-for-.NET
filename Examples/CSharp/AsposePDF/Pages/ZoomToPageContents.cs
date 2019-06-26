using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class ZoomToPageContents
    {
        public static void Run()
        {
            // ExStart:ZoomToPageContents
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Load source PDF file
            Document doc = new Document(dataDir + "input.pdf");
            // Get rectangular region of first page of PDF
            Aspose.Pdf.Rectangle rect = doc.Pages[1].Rect;
            // Instantiate PdfPageEditor instance
            PdfPageEditor ppe = new PdfPageEditor();
            // Bind source PDF
            ppe.BindPdf(dataDir + "input.pdf");
            // Set zoom coefficient
            ppe.Zoom = (float)(rect.Width / rect.Height);
            // Update page size
            ppe.PageSize = new Aspose.Pdf.PageSize((float)rect.Height, (float)rect.Width);

            dataDir = dataDir + "ZoomToPageContents_out.pdf";
            // Save output file
            doc.Save(dataDir);
            // ExEnd:ZoomToPageContents
            System.Console.WriteLine("\nZoom to page contents applied successfully.\nFile saved at " + dataDir);
        }
    }
}