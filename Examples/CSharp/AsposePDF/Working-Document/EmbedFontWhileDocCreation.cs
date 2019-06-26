using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class EmbedFontWhileDocCreation 
    {
        public static void Run()
        {
            // ExStart:EmbedFontWhileDocCreation 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Instantiate Pdf object by calling its empty constructor
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document();

            // Create a section in the Pdf object
            Aspose.Pdf.Page page = doc.Pages.Add();

            Aspose.Pdf.Text.TextFragment fragment = new Aspose.Pdf.Text.TextFragment("");

            Aspose.Pdf.Text.TextSegment segment = new Aspose.Pdf.Text.TextSegment(" This is a sample text using Custom font.");
            Aspose.Pdf.Text.TextState ts = new Aspose.Pdf.Text.TextState();
            ts.Font = FontRepository.FindFont("Arial");
            ts.Font.IsEmbedded = true;
            segment.TextState = ts;
            fragment.Segments.Add(segment);
            page.Paragraphs.Add(fragment);

            dataDir = dataDir + "EmbedFontWhileDocCreation_out.pdf";
            // Save PDF Document
            doc.Save(dataDir);
            // ExEnd:EmbedFontWhileDocCreation 
            Console.WriteLine("\nFont embedded successfully in a PDF file.\nFile saved at " + dataDir);
        }
    }
}