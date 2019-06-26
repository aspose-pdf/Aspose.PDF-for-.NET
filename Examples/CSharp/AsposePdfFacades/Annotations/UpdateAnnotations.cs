using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class UpdateAnnotations
    {
        public static void Run()
        {
            // ExStart:UpdateAnnotations
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();

            // Open document
            Aspose.Pdf.Facades.PdfAnnotationEditor annotationEditor = new Aspose.Pdf.Facades.PdfAnnotationEditor();
            annotationEditor.BindPdf( dataDir + "input.pdf");

            // Create annotation
            FreeTextAnnotation annotation = new FreeTextAnnotation(annotationEditor.Document.Pages[1], new Aspose.Pdf.Rectangle(200, 400, 400, 600), new DefaultAppearance("TimesNewRoman", 14, System.Drawing.Color.Orange));
            annotation.Modified = DateTime.Now;
            annotation.Contents = "Contents...";
            annotation.Subject = "Subject";
            annotation.Color = Color.Green;

            // Modify annotation
            annotationEditor.ModifyAnnotations(1, 1, annotation);

            // Save updated PDF file
            annotationEditor.Save("output_out.pdf");
            // ExEnd:UpdateAnnotations
        }
    }
}