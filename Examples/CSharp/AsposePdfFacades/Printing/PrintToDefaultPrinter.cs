using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing
{
    public class PrintToDefaultPrinter
    {
        public static void Run()
        {
            // ExStart:PrintToDefaultPrinter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

            // Create PdfViewer object
            PdfViewer viewer = new PdfViewer();

            // Open input PDF file
            viewer.BindPdf( dataDir + "input.pdf");

            // Set attributes for printing
            viewer.AutoResize = true;         // Print the file with adjusted size
            viewer.AutoRotate = true;         // Print the file with adjusted rotation
            viewer.PrintPageDialog = false;   // Do not produce the page number dialog when printing

            // Create objects for printer and page settings and PrintDocument
            System.Drawing.Printing.PrinterSettings ps = new System.Drawing.Printing.PrinterSettings();
            System.Drawing.Printing.PageSettings pgs = new System.Drawing.Printing.PageSettings();
            System.Drawing.Printing.PrintDocument prtdoc = new System.Drawing.Printing.PrintDocument();

            // Set printer name
            ps.PrinterName = prtdoc.PrinterSettings.PrinterName;

            // Set PageSize (if required)
            pgs.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);

            // Set PageMargins (if required)
            pgs.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            // Print document using printer and page settings
            viewer.PrintDocumentWithSettings(pgs, ps);

            // Close the PDF file after priting
            viewer.Close();
            // ExEnd:PrintToDefaultPrinter
        }
        public static void ShowPrintDialog()
        {
          
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

            // Create PdfViewer object
            PdfViewer viewer = new PdfViewer();

            // Open input PDF file
            viewer.BindPdf( dataDir + "input.pdf");

            // Set attributes for printing
            viewer.AutoResize = true;         // Print the file with adjusted size
            viewer.AutoRotate = true;         // Print the file with adjusted rotation
            viewer.PrintPageDialog = false;   // Do not produce the page number dialog when printing

            // Create objects for printer and page settings and PrintDocument
            System.Drawing.Printing.PrinterSettings ps = new System.Drawing.Printing.PrinterSettings();
            System.Drawing.Printing.PageSettings pgs = new System.Drawing.Printing.PageSettings();
            System.Drawing.Printing.PrintDocument prtdoc = new System.Drawing.Printing.PrintDocument();

            // Set printer name
            ps.PrinterName = prtdoc.PrinterSettings.PrinterName;

            // Set PageSize (if required)
            pgs.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);

            // Set PageMargins (if required)
            pgs.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            // ExStart:PrintDialog
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            if (printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Document printing code goes here
                // Print document using printer and page settings
                viewer.PrintDocumentWithSettings(pgs, ps);
            }
            // ExEnd:PrintDialog            

            // Close the PDF file after priting
            viewer.Close();
        }
       
    }
}