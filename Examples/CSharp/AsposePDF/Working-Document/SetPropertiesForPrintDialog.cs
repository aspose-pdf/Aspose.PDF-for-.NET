using Aspose.Pdf.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class SetPresetPropertiesForPrintDialog
    {
        public static void Run()
        {
            //ExStart: SetPresetPropertiesForPrintDialog
            var dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            using (Document doc = new Document())
            {
                doc.Pages.Add();
                doc.Duplex = PrintDuplex.DuplexFlipLongEdge;
                doc.Save(dataDir + "35297_out.pdf", SaveFormat.Pdf);
            }
            //ExEnd: SetPresetPropertiesForPrintDialog
        }

        public static void SetPrintDlgPropertiesUsingPdfContentEditor()
        {
            //ExStart:SetPrintDlgPropertiesUsingPdfContentEditor
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            string outputFile = dataDir + "input.pdf";
            using (PdfContentEditor ed = new PdfContentEditor())
            {
                ed.BindPdf(outputFile);
                if ((ed.GetViewerPreference() & ViewerPreference.DuplexFlipShortEdge) > 0)
                {
                    Console.WriteLine("The file has duplex flip short edge");
                }

                ed.ChangeViewerPreference(ViewerPreference.DuplexFlipShortEdge);
                ed.Save(dataDir + "SetPrintDlgPropertiesUsingPdfContentEditor_out.pdf");
            }
            //ExEnd: SetPrintDlgPropertiesUsingPdfContentEditor
        }
    }
}
