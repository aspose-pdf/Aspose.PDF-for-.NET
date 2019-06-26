using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class EditPdfPages
    {
        public static void Run()
        {
            // ExStart:EditPdfPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();
     
            // Create a new instance of PdfPageEditor class
            Aspose.Pdf.Facades.PdfPageEditor pEditor = new Aspose.Pdf.Facades.PdfPageEditor();
            // Bind an existing pdf file
            pEditor.BindPdf(dataDir + "FilledForm.pdf");
            // Specify an array of pages which need to be manipulated pages can be multiple, here we have specified only one page
            pEditor.ProcessPages = new int[] { 1 };

            // Alignment related code

            // Horizontal alignment
            pEditor.HorizontalAlignment = HorizontalAlignment.Right;      

            // Specify transition type for the pages
            pEditor.TransitionType = 2;
            // Specify transition duration
            pEditor.TransitionDuration = 5;

            // Display related code

            // Select a page size from the enumeration and assign to property
            pEditor.PageSize = PageSize.PageLedger;
            // Assign page rotation
            pEditor.Rotation = 90;
            // Specify zoom factor for the page
            pEditor.Zoom = 100;
            // Assign display duration for the page
            pEditor.DisplayDuration = 5;

            // Methods provided by the class page rotation specified already can be fetched using this method
            int rotation = pEditor.GetPageRotation(1);
            // Already specified page can be fetched with the help of this method
            PageSize pagesize = pEditor.GetPageSize(1);
            // This method gets the page count
            int totalpages = pEditor.GetPages();
            // This method changes the origin from (0,0) to specified number
            pEditor.MovePosition(100, 100);

            // Finally save the output file
            pEditor.Save(dataDir + "EditPdfPages_out.pdf");
            // ExEnd:EditPdfPages                      
        }
    }
}