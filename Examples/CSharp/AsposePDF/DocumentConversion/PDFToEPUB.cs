using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToEPUB
    {
        public static void Run()
        {
            // ExStart:PDFToEPUB
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load PDF document
            Document pdfDocument = new Document(dataDir + "PDFToEPUB.pdf");

            // Instantiate Epub Save options
            EpubSaveOptions options = new EpubSaveOptions();
            
            // Specify the layout for contents
            options.ContentRecognitionMode = EpubSaveOptions.RecognitionMode.Flow;
            
            // Save the ePUB document
            pdfDocument.Save(dataDir + "PDFToEPUB_out.epub", options);
            // ExEnd:PDFToEPUB
        }
    }
}