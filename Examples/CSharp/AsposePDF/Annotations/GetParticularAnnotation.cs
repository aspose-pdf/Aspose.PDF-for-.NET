using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class GetParticularAnnotation
    {
        public static void Run()
        {
            // ExStart:GetParticularAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetParticularAnnotation.pdf");

            // Get particular annotation
            TextAnnotation textAnnotation = (TextAnnotation)pdfDocument.Pages[1].Annotations[1];
            
            // Get annotation properties
            Console.WriteLine("Title : {0} ", textAnnotation.Title);
            Console.WriteLine("Subject : {0} ", textAnnotation.Subject);
            Console.WriteLine("Contents : {0} ", textAnnotation.Contents);
            // ExEnd:GetParticularAnnotation
        }
    }
}