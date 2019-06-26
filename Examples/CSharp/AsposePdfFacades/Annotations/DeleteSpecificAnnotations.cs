using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class DeleteSpecificAnnotations
    {
        public static void Run()
        {
            // ExStart:DeleteSpecificAnnotations
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            // Open document
            PdfAnnotationEditor annotationEditor = new PdfAnnotationEditor();
            annotationEditor.BindPdf(dataDir+ "DeleteAllAnnotations.pdf");
            // Delete specific annoations
            annotationEditor.DeleteAnnotations("Text");
            // Save updated PDF
            annotationEditor.Save(dataDir + "DeleteSpecificAnnotations_out.pdf");
            // ExEnd:DeleteSpecificAnnotations
        }
    }
}