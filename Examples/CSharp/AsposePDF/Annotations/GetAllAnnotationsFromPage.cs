using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class GetAllAnnotationsFromPage
    {
        public static void Run()
        {
            // ExStart:GetAllAnnotationsFromPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetAllAnnotationsFromPage.pdf");

            // Loop through all the annotations
            foreach (MarkupAnnotation annotation in pdfDocument.Pages[1].Annotations)
            {
                // Get annotation properties
                Console.WriteLine("Title : {0} ", annotation.Title);
                Console.WriteLine("Subject : {0} ", annotation.Subject);
                Console.WriteLine("Contents : {0} ", annotation.Contents);                
            }
            // ExEnd:GetAllAnnotationsFromPage
        }
    }
}