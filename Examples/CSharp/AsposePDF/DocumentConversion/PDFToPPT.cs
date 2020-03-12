using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToPPT
    {
        public static void Run()
        {
            // ExStart:PDFToPPT
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            // Load PDF document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "input.pdf");
            // Instantiate PptxSaveOptions instance
            Aspose.Pdf.PptxSaveOptions pptx_save = new Aspose.Pdf.PptxSaveOptions();
            // Save the output in PPTX format
            doc.Save(dataDir + "PDFToPPT_out.pptx", pptx_save);
            // ExEnd:PDFToPPT
        }

        public static void PDFtoPPTXWithSlidesAsImages()
        {
            //ExStart: PDFtoPPTXWithSlidesAsImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            // Load PDF document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "input.pdf");
            // Instantiate PptxSaveOptions instance
            Aspose.Pdf.PptxSaveOptions pptx_save = new Aspose.Pdf.PptxSaveOptions();
            // Save the output in PPTX format
            pptx_save.SlidesAsImages = true;
            doc.Save(dataDir + "PDFToPPT_out_.pptx", pptx_save);
            //ExEnd: PDFtoPPTXWithSlidesAsImages
        }

        public static void PDFtoPTTXWithProgressTracking()
        {
            //ExStart: PDFtoPTTXWithProgressTracking
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            // Load PDF document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "input.pdf");
            // Instantiate PptxSaveOptions instance
            Aspose.Pdf.PptxSaveOptions pptx_save = new Aspose.Pdf.PptxSaveOptions();

            //Specify Custom Progress Handler
            pptx_save.CustomProgressHandler = ShowProgressOnConsole;
            // Save the output in PPTX format
            doc.Save(dataDir + "PDFToPPTWithProgressTracking_out_.pptx", pptx_save);
            //ExEnd: PDFtoPTTXWithProgressTracking
        }

        public static void ShowProgressOnConsole(PptxSaveOptions.ProgressEventHandlerInfo eventInfo)
        {
            //ExStart: ShowProgressOnConsole
            switch (eventInfo.EventType)
            {
                case ProgressEventType.TotalProgress:
                    Console.WriteLine(String.Format("{0}  - Conversion progress : {1}% .", DateTime.Now.TimeOfDay, eventInfo.Value.ToString()));
                    break;
                case ProgressEventType.ResultPageCreated:
                    Console.WriteLine(String.Format("{0}  - Result page's {1} of {2} layout created.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                case ProgressEventType.ResultPageSaved:
                    Console.WriteLine(String.Format("{0}  - Result page {1} of {2} exported.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                case ProgressEventType.SourcePageAnalysed:
                    Console.WriteLine(String.Format("{0}  - Source page {1} of {2} analyzed.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                
                default:
                    break;
            }
            //ExEnd: ShowProgressOnConsole
        }
    }
}