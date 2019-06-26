using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class DetermineProgress
    {
        public static void Run()
        {
            // ExStart:DetermineProgress
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "AddTOC.pdf");
            DocSaveOptions saveOptions = new DocSaveOptions();
            saveOptions.CustomProgressHandler = new UnifiedSaveOptions.ConversionProgressEventHandler(ShowProgressOnConsole);

            dataDir = dataDir + "DetermineProgress_out.pdf";
            pdfDocument.Save(dataDir, saveOptions);
            Console.ReadLine();
            // ExEnd:DetermineProgress
        }
        // ExStart:ShowProgressOnConsole
        public static void ShowProgressOnConsole(DocSaveOptions.ProgressEventHandlerInfo eventInfo)
        {
            switch (eventInfo.EventType)
            {
                case ProgressEventType.TotalProgress:
                    Console.WriteLine(String.Format("{0}  - Conversion progress : {1}% .", DateTime.Now.ToLongTimeString(), eventInfo.Value.ToString()));
                    break;
                case ProgressEventType.SourcePageAnalized:
                    Console.WriteLine(String.Format("{0}  - Source page {1} of {2} analyzed.", DateTime.Now.ToLongTimeString(), eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                case ProgressEventType.ResultPageCreated:
                    Console.WriteLine(String.Format("{0}  - Result page's {1} of {2} layout created.", DateTime.Now.ToLongTimeString(), eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                case ProgressEventType.ResultPageSaved:
                    Console.WriteLine(String.Format("{0}  - Result page {1} of {2} exported.", DateTime.Now.ToLongTimeString(), eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                default:
                    break;
            }

        }
        // ExEnd:ShowProgressOnConsole
    }
}