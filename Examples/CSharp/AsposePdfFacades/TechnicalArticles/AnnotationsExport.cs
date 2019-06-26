using System.IO;
using System;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class AnnotationsExport
    {
        public static void Run()
        {
            // ExStart:AnnotationsExport
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create an object of PdfAnnotationEditor class
            PdfAnnotationEditor editor = new PdfAnnotationEditor();
            // Bind input PDF file
            editor.BindPdf(dataDir + "inFile.pdf");
            // Create a file stream for output XFDF file to export annotations
            FileStream fileStream = new FileStream(dataDir + "exportannotations.xfdf", FileMode.Create, FileAccess.Write);
            // Create an enumeration of all the annotation types which you want to export
            string[] annoType = { AnnotationType.Text.ToString() };
            // Export annotations of specified type(s) to XFDF file
            editor.ExportAnnotationsXfdf(fileStream, 1, 5, annoType);
            // ExEnd:AnnotationsExport                      
        }
    }
}