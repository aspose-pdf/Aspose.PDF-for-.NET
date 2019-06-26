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
    }
}