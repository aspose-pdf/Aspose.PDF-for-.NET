using System.IO;
using System;
using System.Collections;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class PdfAnnotationEditorFeatures
    {
        public static void Run()
        {
            // ExStart:PdfAnnotationEditorFeatures
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create an object of PdfAnnotationEditor class
            PdfAnnotationEditor editor = new PdfAnnotationEditor();
            // Bind input PDF file
            editor.BindPdf(dataDir + "inFile.pdf");

            // Create a new object of type Annotation to modify annotation attributes
            Aspose.Pdf.Annotations.FreeTextAnnotation annotation = new Aspose.Pdf.Annotations.FreeTextAnnotation(
                editor.Document.Pages[1],
                new Aspose.Pdf.Rectangle(200, 400, 400, 600),
                new Aspose.Pdf.Annotations.DefaultAppearance("TimesNewRoman", 14, System.Drawing.Color.Orange));

            // Set new annotation attributees
            annotation.Subject = "technical article";

            // Modify annotations in the PDF file
            editor.ModifyAnnotations(1, 5, annotation);

            // Delete all the annotations of type Stamp
            editor.DeleteAnnotation("Stamp");

            // Extract annotations to an array list
            // String[] annType = { "Text" };
            string[] annotType = { Aspose.Pdf.Annotations.AnnotationType.FreeText.ToString(), Aspose.Pdf.Annotations.AnnotationType.Line.ToString() };
            ArrayList list = (ArrayList)editor.ExtractAnnotations(1, 5, annotType);
            for (int index = 0; index < list.Count; index++)
            {
                Aspose.Pdf.Annotations.Annotation list_annotation = (Aspose.Pdf.Annotations.Annotation)list[index];
                Console.WriteLine(list_annotation.Contents);
            }

            // Import annotations from another PDF file
            string[] importFrom = new string[1];
            importFrom[0] = dataDir + "inFile2.pdf";
            editor.ImportAnnotations(importFrom);

            // Finally save the output PDF file
            editor.Save(dataDir + "PdfAnnotationEditorFeatures_out.pdf");
            // ExEnd:PdfAnnotationEditorFeatures                      
        }
    }
}