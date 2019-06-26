using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class DeleteAllAnnotations
    {
        public static void Run()
        {
            // ExStart:DeleteAllAnnotations
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            // Open document
            PdfAnnotationEditor annotationEditor = new PdfAnnotationEditor();
            annotationEditor.BindPdf(dataDir+ "DeleteAllAnnotations.pdf");
            // Delete all annoations
            annotationEditor.DeleteAnnotations();
            // Save updated PDF
            annotationEditor.Save(dataDir+ "DeleteAllAnnotations_out.pdf");
            // ExEnd:DeleteAllAnnotations
        }
    }
}