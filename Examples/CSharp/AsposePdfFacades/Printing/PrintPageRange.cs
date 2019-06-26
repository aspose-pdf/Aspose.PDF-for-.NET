using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing
{
    public class PrintPageRange
    {
        public static void Run()
        {
            try
            {
                // ExStart:PrintPageRange
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

                Aspose.Pdf.Facades.PdfViewer pdfv = new Aspose.Pdf.Facades.PdfViewer();

                pdfv.PdfQueryPageSettings += PdfvOnPdfQueryPageSettings;

                System.Drawing.Printing.PageSettings pgs = new System.Drawing.Printing.PageSettings();
                System.Drawing.Printing.PrinterSettings prin = new System.Drawing.Printing.PrinterSettings();

                pdfv.BindPdf(dataDir + "Print-PageRange.pdf");
                prin.PrinterName = "HP LaserJet M9050 MFP PCL6";
                prin.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);

                Aspose.Pdf.Facades.PdfPageEditor pageEditor = new Aspose.Pdf.Facades.PdfPageEditor();
                pageEditor.BindPdf(dataDir + "input.pdf");

                pgs.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                pgs.PaperSize = prin.DefaultPageSettings.PaperSize;

                pdfv.PrintDocumentWithSettings(pgs, prin);
                pdfv.Close();
                // ExEnd:PrintPageRange
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:PdfvOnPdfQueryPageSettings
        private static void PdfvOnPdfQueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs queryPageSettingsEventArgs, PdfPrintPageInfo currentPageInfo)
        {
            bool isOdd = currentPageInfo.PageNumber % 2 != 0;

            System.Drawing.Printing.PrinterSettings.PaperSourceCollection paperSources = queryPageSettingsEventArgs.PageSettings.PrinterSettings.PaperSources;

            if (isOdd)
                queryPageSettingsEventArgs.PageSettings.PaperSource = paperSources[0];
            else
                queryPageSettingsEventArgs.PageSettings.PaperSource = paperSources[1];
        }
        // ExEnd:PdfvOnPdfQueryPageSettings

    }
}