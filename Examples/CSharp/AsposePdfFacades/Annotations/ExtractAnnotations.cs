using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;
using Aspose.Pdf.Annotations;
using System.Collections;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class ExtractAnnotations
    {
        public static void Run()
        {
            try
            {
                // ExStart:ExtractAnnotations
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
                // Create PdfAnnotationEditor
                PdfAnnotationEditor annotationEditor = new PdfAnnotationEditor();
                // Open PDF document
                annotationEditor.BindPdf(dataDir + "ExtractAnnotations.pdf");
                // Extract annotations
                string[] annotType = { AnnotationType.FreeText.ToString(), AnnotationType.Line.ToString() };
                ArrayList annotList = (ArrayList)annotationEditor.ExtractAnnotations(1, 2, annotType);
                for (int index = 0; index < annotList.Count; index++)
                {
                    Annotation annotation = (Annotation)annotList[index];
                    Console.WriteLine(annotation.Contents);
                }
                // ExEnd:ExtractAnnotations
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}