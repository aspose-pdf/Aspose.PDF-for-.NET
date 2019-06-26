using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class ChangeStampPosition
    {
        public static void Run()
        {
            try
            {
                // ExStart:ChangeStampPosition
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

                // Instantiate PdfContentEditor Object
                PdfContentEditor pdfContentEditor = new PdfContentEditor();

                // Bind input PDF file
                pdfContentEditor.BindPdf(dataDir + "ChangeStampPosition.pdf");

                int pageId = 1;
                int stampIndex = 1;
                double x = 200;
                double y = 200;

                // Change the position of the stamp to new x and y position
                pdfContentEditor.MoveStamp(pageId, stampIndex, x, y);

                // Save the Pdf file
                pdfContentEditor.Save(dataDir + "ChangeStampPosition_out.pdf");
                // ExEnd:ChangeStampPosition
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static void ChangeStampPositionByID()
        {
            // ExStart:ChangeStampPositionByID
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            // Instantiate PdfContentEditor Object
            PdfContentEditor pdfContentEditor = new PdfContentEditor();

            // Bind input PDF file
            pdfContentEditor.BindPdf(dataDir + "ChangeStampPosition.pdf");

            int pageId = 1;
            int stampId = 1;
            double x = 200;
            double y = 200;

            // Change the position of the stamp to new x and y position
            pdfContentEditor.MoveStamp(pageId, stampId, x, y);

            // Save the Pdf file
            pdfContentEditor.Save(dataDir + "ChangeStampPositionByID_out.pdf");
            // ExEnd:ChangeStampPositionByID
        }
    }
}