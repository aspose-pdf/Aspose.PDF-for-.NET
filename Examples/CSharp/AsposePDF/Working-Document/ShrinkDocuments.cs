using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class ShrinkDocuments
    {
        public static void Run()
        {
            // ExStart:ShrinkDocuments
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            // Open document
            Document pdfDocument = new Document(dataDir + "ShrinkDocument.pdf");
            // Optimize PDF document. Note, though, that this method cannot guarantee document shrinking
            pdfDocument.OptimizeResources();
            dataDir = dataDir + "ShrinkDocument_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:ShrinkDocuments
            Console.WriteLine("\nDocument shrinked successfully.\nFile saved at " + dataDir);
        }
    }
}
