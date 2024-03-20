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
                Aspose.Pdf.Printing.PrinterSettings ps = new Aspose.Pdf.Printing.PrinterSettings();
                Aspose.Pdf.Printing.PageSettings pgs = new Aspose.Pdf.Printing.PageSettings();
                System.Drawing.Printing.PrintDocument prtdoc = new System.Drawing.Printing.PrintDocument();

                // Specify the printer name
                ps.PrinterName = "Microsoft XPS Document Writer";

                // Resultant Printout name
                ps.PrintFileName = "ResultantPrintout.xps";

                // Print the output to file
                ps.PrintToFile = true;
                ps.FromPage = 1;
                ps.ToPage = 2;
                ps.PrintRange = Aspose.Pdf.Printing.PrintRange.SomePages;

                // Specify the page size of printout
                pgs.PaperSize = new Aspose.Pdf.Printing.PaperSize("A4", 827, 1169);
                ps.DefaultPageSettings.PaperSize = pgs.PaperSize;
                pgs.Margins = new Aspose.Pdf.Devices.Margins(0, 0, 0, 0);

                // Print the document with settings specified above
                viewer.PrintDocumentWithSettings(pgs, ps);

                // Check the print status
                if (viewer.PrintStatus != null)
                {
                    // An exception was thrown
                    if (viewer.PrintStatus is Exception ex)
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
                Aspose.Pdf.Printing.PrinterSettings ps = new Aspose.Pdf.Printing.PrinterSettings();
                ps.PrinterName = "Microsoft XPS Document Writer";
                viewer.PrintDocumentWithSettings(ps); // OwnerUserName is a value of Owner column in spooler app
                viewer.Close();
            }
            // ExEnd:UsingImpersonation
        }
    }
}