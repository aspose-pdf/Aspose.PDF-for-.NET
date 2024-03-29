using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing
{
    public class PdfToPostScript
    {
        public static void Run()
        {
            try
            {
                // ExStart:PdfToPostScript
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

                Aspose.Pdf.Facades.PdfViewer viewer = new Aspose.Pdf.Facades.PdfViewer();
                viewer.BindPdf(dataDir + "input.pdf");
                // Set PrinterSettings and PageSettings
                Aspose.Pdf.Printing.PrinterSettings printerSettings = new Aspose.Pdf.Printing.PrinterSettings();
                printerSettings.Copies = 1;
                // Set PS printer, one can find this driver in the list of preinstalled printer drivers in Windows
                printerSettings.PrinterName = "HP LaserJet 2300 Series PS";
                // Set output file name and PrintToFile attribute
                printerSettings.PrintFileName = dataDir + "PdfToPostScript_out.ps";
                printerSettings.PrintToFile = true;
                // Disable print page dialog
                viewer.PrintPageDialog = false;
                // Pass printer settings object to the method
                viewer.PrintDocumentWithSettings(printerSettings);
                viewer.Close();
                // ExEnd:PdfToPostScript
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}