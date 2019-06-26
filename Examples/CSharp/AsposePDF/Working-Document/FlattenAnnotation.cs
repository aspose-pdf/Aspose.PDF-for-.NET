using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class FlattenAnnotation
    {
        public static void Run()
        {
            // ExStart:FlattenAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            // Open document
            Document pdfDocument = new Document(dataDir + "OptimizeDocument.pdf");
            // Flatten annotations
            foreach (var page in pdfDocument.Pages)
            {
                foreach (var annotation in page.Annotations)
                {
                    annotation.Flatten();
                }

            }
            // Save updated document
            pdfDocument.Save(dataDir + "OptimizeDocument_out.pdf");
            // ExEnd:FlattenAnnotation   
            Console.WriteLine("\nFlattened annotation successfully.\nFile saved at " + dataDir);
        }
    }
}
