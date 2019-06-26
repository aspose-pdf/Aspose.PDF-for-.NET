using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class DeleteParticularAnnotation
    {
        public static void Run()
        {
            // ExStart:DeleteParticularAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document pdfDocument = new Document(dataDir + "DeleteParticularAnnotation.pdf");

            // Delete particular annotation
            pdfDocument.Pages[1].Annotations.Delete(1);

            dataDir = dataDir + "DeleteParticularAnnotation_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:DeleteParticularAnnotation
            Console.WriteLine("\nParticular annotation deleted successfully.\nFile saved at " + dataDir);
        }
    }
}