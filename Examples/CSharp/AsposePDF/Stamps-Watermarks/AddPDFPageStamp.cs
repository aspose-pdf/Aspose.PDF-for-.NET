using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class AddPDFPageStamp
    {
        public static void Run()
        {
            // ExStart:PDFPageStamp
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "PDFPageStamp.pdf");

            // Create page stamp
            PdfPageStamp pageStamp = new PdfPageStamp(pdfDocument.Pages[1]);
            pageStamp.Background = true;
            pageStamp.XIndent = 100;
            pageStamp.YIndent = 100;
            pageStamp.Rotate = Rotation.on180;

            // Add stamp to particular page
            pdfDocument.Pages[1].AddStamp(pageStamp);

            dataDir = dataDir + "PDFPageStamp_out.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:PDFPageStamp
            Console.WriteLine("\nPdf page stamp added successfully.\nFile saved at " + dataDir);
            
        }
    }
}