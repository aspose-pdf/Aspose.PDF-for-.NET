using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class ProgressDetails
    {
        public static void Run()
        {
            try
            {
                // ExStart:ProgressDetails
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();
                string licenseFile = ""; // E.g F:\_Sources\Aspose_5\trunk\testdata\License\Aspose.Total.lic
                (new Aspose.Pdf.License()).SetLicense(licenseFile);
                Document doc = new Document(dataDir + "input.pdf");
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                // SaveOptions.CustomProgressHandler = new HtmlSaveOptions.ConversionProgessEventHandler(ShowProgressOnConsole);
                saveOptions.SplitIntoPages = false;
                doc.Save(dataDir + "ProgressDetails_out_.html", saveOptions);
                Console.ReadLine();
                // ExEnd:ProgressDetails
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:ProgressDetailsHelper
        public static void ShowProgressOnConsole(HtmlSaveOptions.ProgressEventHandlerInfo eventInfo)
        {
            switch (eventInfo.EventType)
            {
                case ProgressEventType.TotalProgress:
                    Console.WriteLine(String.Format("{0}  - Conversion progress : {1}% .", DateTime.Now.TimeOfDay, eventInfo.Value.ToString()));
                    break;
                case ProgressEventType.SourcePageAnalysed:
                    Console.WriteLine(String.Format("{0}  - Source page {1} of {2} analyzed.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                case ProgressEventType.ResultPageCreated:
                    Console.WriteLine(String.Format("{0}  - Result page's {1} of {2} layout created.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                case ProgressEventType.ResultPageSaved:
                    Console.WriteLine(String.Format("{0}  - Result page {1} of {2} exported.", DateTime.Now.TimeOfDay, eventInfo.Value.ToString(), eventInfo.MaxValue.ToString()));
                    break;
                default:
                    break;
            }
        }
        // ExEnd:ProgressDetailsHelper
    }
}