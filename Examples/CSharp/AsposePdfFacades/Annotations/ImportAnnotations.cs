using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class ImportAnnotations
    {
        public static void Run()
        {
            // ExStart:ImportAnnotations
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            // Create PdfAnnotationEditor object
            PdfAnnotationEditor AnnotationEditor = new PdfAnnotationEditor();
            // Open PDF document
            AnnotationEditor.BindPdf(dataDir+ "ImportAnnotations.pdf");
            // Import annotations
            FileStream fileStream = new System.IO.FileStream(dataDir+ "annotations.xfdf", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            AnnotationType[] annotType = { AnnotationType.FreeText, AnnotationType.Line };
            AnnotationEditor.ImportAnnotationFromXfdf(fileStream, annotType);
            // Save output PDF
            AnnotationEditor.Save(dataDir + "ImportAnnotations_out.pdf");
            fileStream.Flush();
            fileStream.Close();            
            // ExEnd:ImportAnnotations            
        }
    }
}