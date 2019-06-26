using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing
{
    public class PrintoXPSPrinter
    {
        public static void Run()
        {
            // ExStart:PrintoXPSPrinter
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

            // Set XPS/PDF printer name
            ps.PrinterName = "Microsoft XPS Document Writer";
            // Or set the PDF printer
            // Ps.PrinterName = "Adobe PDF";

            // Set PageSize (if required)
            pgs.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);

            // Set PageMargins (if required)
            pgs.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            // Print document using printer and page settings
            viewer.PrintDocumentWithSettings(pgs, ps);

            // Close the PDF file after priting
            viewer.Close();
            // ExEnd:PrintoXPSPrinter
        }
        public static void HideDialgo()
        {
            // ExStart:HideDialgo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

            // Create PdfViewer object and bind PDF file
            PdfViewer pdfViewer = new PdfViewer();
            pdfViewer.BindPdf( dataDir + "input.pdf");

            // Set PrinterSettings and PageSettings
            System.Drawing.Printing.PrinterSettings printerSetttings = new System.Drawing.Printing.PrinterSettings();
            printerSetttings.Copies = 1;
            printerSetttings.PrinterName = "Microsoft XPS Document Writer";

            // Set output file name and PrintToFile attribute
            printerSetttings.PrintFileName = dataDir + "print_out.xps";
            printerSetttings.PrintToFile = true;

            // Disable print page dialog
            pdfViewer.PrintPageDialog = false;

            // Pass printer settings object to the method
            pdfViewer.PrintDocumentWithSettings(printerSetttings);
            pdfViewer.Close();
            // ExEnd:HideDialgo
        }
        public static void FontsNotEmbedded()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

            // Create PdfViewer object
            PdfViewer viewer = new PdfViewer();

            // Open input PDF file
            viewer.BindPdf(dataDir + "input.pdf");

            // Set attributes for printing
            viewer.AutoResize = true;         // Print the file with adjusted size
            viewer.AutoRotate = true;         // Print the file with adjusted rotation
            viewer.PrintPageDialog = false;   // Do not produce the page number dialog when printing

            // Create objects for printer and page settings and PrintDocument
            System.Drawing.Printing.PrinterSettings ps = new System.Drawing.Printing.PrinterSettings();
            System.Drawing.Printing.PageSettings pgs = new System.Drawing.Printing.PageSettings();

            // Set XPS/PDF printer name
            ps.PrinterName = "Microsoft XPS Document Writer";
            // Or set the PDF printer
            // Ps.PrinterName = "Adobe PDF";

            // Set PageSize (if required)
            pgs.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);

            // Set PageMargins (if required)
            pgs.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            
            // ExStart:FontsNotEmbedded
            // Render all system fonts with native system approach (embed the fonts to output documents)
            viewer.RenderingOptions.SystemFontsNativeRendering = true;
            // ExEnd:FontsNotEmbedded

            // Print document using printer and page settings
            viewer.PrintDocumentWithSettings(pgs, ps);

            // Close the PDF file after priting
            viewer.Close();
        }
      
       
    }
}