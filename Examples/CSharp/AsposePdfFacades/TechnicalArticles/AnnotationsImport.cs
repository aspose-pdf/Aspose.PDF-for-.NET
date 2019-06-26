using System.IO;
using System;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class AnnotationsImport
    {
        public static void Run()
        {
            // ExStart:AnnotationsImport
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create an object of PdfAnnotationEditor class
            PdfAnnotationEditor editor = new PdfAnnotationEditor();
            // Bind input PDF file
            editor.BindPdf(dataDir + "inFile.pdf");
            // Create a file stream for input XFDF file to import annotations
            FileStream fileStream = new FileStream(dataDir + "exportannotations.xfdf", FileMode.Open, FileAccess.Read);
            // Create an enumeration of all the annotation types which you want to import
            AnnotationType[] annType = { AnnotationType.Text };
            // Import annotations of specified type(s) from XFDF file
            editor.ImportAnnotationFromXfdf(fileStream, annType);
            // Save output pdf file
            editor.Save(dataDir + "ImportAnnotations_out.pdf");
            // ExEnd:AnnotationsImport                      
        }
    }
}