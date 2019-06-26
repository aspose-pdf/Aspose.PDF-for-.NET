using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class ExportAnnotations
    {
        public static void Run()
        {
            // ExStart:ExportAnnotations
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            // Create PdfAnnotationEditor object
            PdfAnnotationEditor AnnotationEditor = new PdfAnnotationEditor();
            // Open PDF document
            AnnotationEditor.BindPdf(dataDir+ "ExportAnnotations.pdf");
            // Export annotations
            FileStream fileStream = new System.IO.FileStream(dataDir + "exportannotations.xfdf", System.IO.FileMode.Create);
            string[] annotType = { AnnotationType.FreeText.ToString(), AnnotationType.Line.ToString() };
            AnnotationEditor.ExportAnnotationsXfdf(fileStream, 1, 5, annotType);
            // Save output PDF
            AnnotationEditor.Save(dataDir+ "ExportAnnotations_out.pdf");
            fileStream.Flush();
            fileStream.Close();            
            // ExEnd:ExportAnnotations
        }
    }
}