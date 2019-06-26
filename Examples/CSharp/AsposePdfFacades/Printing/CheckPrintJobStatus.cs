using System.IO;
using System;
using System.Windows.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing
{
    public class CheckPrintJobStatus
    {
        public static void Run()
        {
            try
            {
                // ExStart:CheckPrintJobStatus
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

                // Instantiate PdfViewer object
                PdfViewer viewer = new PdfViewer();

                // Bind source PDF file
                viewer.BindPdf(dataDir + "input.pdf");
                viewer.AutoResize = true;

                // Hide printing dialog
                viewer.PrintPageDialog = false;

                // Create Printer Settings object
                System.Drawing.Printing.PrinterSettings ps = new System.Drawing.Printing.PrinterSettings();
                System.Drawing.Printing.PageSettings pgs = new System.Drawing.Printing.PageSettings();
                System.Drawing.Printing.PrintDocument prtdoc = new System.Drawing.Printing.PrintDocument();

                // Specify the printer anme
                ps.PrinterName = "Microsoft XPS Document Writer";

                // Resultant Printout name
                ps.PrintFileName = "ResultantPrintout.xps";

                // Print the output to file
                ps.PrintToFile = true;
                ps.FromPage = 1;
                ps.ToPage = 2;
                ps.PrintRange = System.Drawing.Printing.PrintRange.SomePages;

                // Specify the page size of printout
                pgs.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
                ps.DefaultPageSettings.PaperSize = pgs.PaperSize;
                pgs.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

                // Print the document with settings specified above
                viewer.PrintDocumentWithSettings(pgs, ps);

                // Check the print status
                if (viewer.PrintStatus != null)
                {
                    // An exception was thrown
                    Exception ex = viewer.PrintStatus as Exception;
                    if (ex != null)
                    {
                        // Get exception message
                    }
                }
                else
                {
                    // No errors were found. Printing job has completed successfully
                    Console.WriteLine("printing completed without any issue..");
                }
                // ExEnd:CheckPrintJobStatus
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void GetSetPrintOwnerName()
        {
            // ExStart:GetSetPrintOwnerName
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();
            PdfViewer viewer = new PdfViewer();
            // Bind source PDF file
            viewer.BindPdf(dataDir + "input.pdf");
            // Specify the name of Print job
            viewer.PrinterJobName = GetCurrentUserCredentials();
            // ExEnd:GetSetPrintOwnerName
        }
        // ExStart:GetCurrentUserCredentials
        private static string GetCurrentUserCredentials()
        {
            // The implementation depends on type of running application (ASP.NET, Windows forms, etc.)
            string userCredentials = string.Empty;
            return userCredentials;
        }
        // ExEnd:GetCurrentUserCredentials
        public static void UsingImpersonation()
        {
            // ExStart:UsingImpersonation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();
            PdfViewer viewer = new PdfViewer();
            viewer.BindPdf( dataDir + "input.pdf");
            viewer.PrintPageDialog = false;
            // Do not produce the page number dialog when printing
            using (new Impersonator("OwnerUserName", "SomeDomain", "OwnerUserNamePassword"))
            {
                System.Drawing.Printing.PrinterSettings ps = new System.Drawing.Printing.PrinterSettings();
                ps.PrinterName = "Microsoft XPS Document Writer";
                viewer.PrintDocumentWithSettings(ps); // OwnerUserName is a value of Owner column in spooler app
                viewer.Close();
            }
            // ExEnd:UsingImpersonation
        }
    }
}