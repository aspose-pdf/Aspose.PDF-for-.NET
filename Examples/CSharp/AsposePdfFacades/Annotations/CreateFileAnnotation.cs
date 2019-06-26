using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class CreateFileAnnotation
    {
        public static void Run()
        {
            // ExStart:CreateFileAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();

            // Instantiate PdfContentEditor object
            PdfContentEditor editor = new PdfContentEditor();
            // Bind input PDF file
            editor.BindPdf(dataDir+ "CreateFileAnnotation.pdf");
            // The last argumnet is for transparency of icon
            editor.CreateFileAttachment(new System.Drawing.Rectangle(50, 50, 10, 10), "here", dataDir + "AddFreeTextAnnotation.pdf", 1, "Paperclip", 0.005);
            // Save the updated PDF file
            editor.Save(dataDir+ "PdfWith_Transparent_Annotation_out.pdf");
            // ExEnd:CreateFileAnnotation
        }
    }
}