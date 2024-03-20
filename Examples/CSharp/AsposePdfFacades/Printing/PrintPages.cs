using System.IO;
using System.Collections.Generic;
using Aspose.Pdf.Printing;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing
{
    public class PrintPages
    {
        // ExStart:PrintingJobSettings
        struct PrintingJobSettings
        {
            public int ToPage { get; set; }
            public int FromPage { get; set; }
            public string OutputFile { get; set; }
            public Duplex Mode { get; set; }
        }
        // ExEnd:PrintingJobSettings
        public static void Run()
        {
            // ExStart:PrintPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

            int printingJobIndex = 0;
            string inPdf = dataDir + "input.pdf";
            string output = dataDir;
            IList<PrintingJobSettings> printingJobs = new List<PrintingJobSettings>();

            PrintingJobSettings printingJob1 = new PrintingJobSettings();
            printingJob1.FromPage = 1;
            printingJob1.ToPage = 3;
            printingJob1.OutputFile = output + "35925_1_3.xps";
            printingJob1.Mode = Duplex.Default;

            printingJobs.Add(printingJob1);

            PrintingJobSettings printingJob2 = new PrintingJobSettings();
            printingJob2.FromPage = 4;
            printingJob2.ToPage = 6;
            printingJob2.OutputFile = output + "35925_4_6.xps";
            printingJob2.Mode = Duplex.Simplex;

            printingJobs.Add(printingJob2);

            PrintingJobSettings printingJob3 = new PrintingJobSettings();
            printingJob3.FromPage = 7;
            printingJob3.ToPage = 7;
            printingJob3.OutputFile = output + "35925_7.xps";
            printingJob3.Mode = Duplex.Default;

            printingJobs.Add(printingJob3);

            PdfViewer viewer = new PdfViewer();

            viewer.BindPdf(inPdf);
            viewer.AutoResize = true;
            viewer.AutoRotate = true;
            viewer.PrintPageDialog = false;

            PrinterSettings ps = new PrinterSettings();
            PageSettings pgs = new PageSettings();

            ps.PrinterName = "Microsoft XPS Document Writer";
            ps.PrintFileName = Path.GetFullPath(printingJobs[printingJobIndex].OutputFile);
            ps.PrintToFile = true;
            ps.FromPage = printingJobs[printingJobIndex].FromPage;
            ps.ToPage = printingJobs[printingJobIndex].ToPage;
            ps.Duplex = printingJobs[printingJobIndex].Mode;
            ps.PrintRange = PrintRange.SomePages;

            pgs.PaperSize = new Aspose.Pdf.Printing.PaperSize("A4", 827, 1169);
            ps.DefaultPageSettings.PaperSize = pgs.PaperSize;
            pgs.Margins = new Aspose.Pdf.Devices.Margins(0, 0, 0, 0);
            viewer.EndPrint += (sender, args) =>
            {
                if (++printingJobIndex < printingJobs.Count)
                {
                    ps.PrintFileName = Path.GetFullPath(printingJobs[printingJobIndex].OutputFile);
                    ps.FromPage = printingJobs[printingJobIndex].FromPage;
                    ps.ToPage = printingJobs[printingJobIndex].ToPage;
                    ps.Duplex = printingJobs[printingJobIndex].Mode;
                    viewer.PrintDocumentWithSettings(pgs, ps);
                }
            };

            viewer.PrintDocumentWithSettings(pgs, ps);
            // ExEnd:PrintPages
        }


    }
}