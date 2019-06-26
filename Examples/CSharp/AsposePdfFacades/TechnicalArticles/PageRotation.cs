using System.IO;
using System;
using System.Collections;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class PageRotation
    {
        public static void Run()
        {
            // ExStart:PageRotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create PdfPageEditor object
            PdfPageEditor pEdit = new PdfPageEditor();

            // Rotate odd pages at 180 degrees
            pEdit.BindPdf(dataDir + "inFile1.pdf");
            pEdit.ProcessPages = new int[] { 1 };
            pEdit.Rotation = 180;
            pEdit.Save(dataDir + "Aspose.Pdf.Facades_rotate_180_out.pdf");

            // Rotate even pages at 270 degrees
            pEdit.BindPdf(dataDir + "inFile2.pdf");
            pEdit.ProcessPages = new int[] { 1 };
            pEdit.Rotation = 270;
            pEdit.Save(dataDir + "Aspose.Pdf.Facades_rotate_270_out.pdf");

            // Find at what degrees a page was rotated
            pEdit.BindPdf(dataDir + "inFile.pdf");
            int degrees = pEdit.GetPageRotation(1);
            pEdit = null;
            // ExEnd:PageRotation                      
        }
    }
}