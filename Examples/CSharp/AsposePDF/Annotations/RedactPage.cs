using System;
using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class RedactPage
    {
        public static void Run()
        {
           
            // ExStart:RedactPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document doc = new Document(dataDir + "input.pdf");

            // Create RedactionAnnotation instance for specific page region
            RedactionAnnotation annot = new RedactionAnnotation(doc.Pages[1], new Aspose.Pdf.Rectangle(200, 500, 300, 600));
            annot.FillColor = Aspose.Pdf.Color.Green;
            annot.BorderColor = Aspose.Pdf.Color.Yellow;
            annot.Color = Aspose.Pdf.Color.Blue;
            // Text to be printed on redact annotation
            annot.OverlayText = "REDACTED";
            annot.TextAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // Repat Overlay text over redact Annotation
            annot.Repeat = true;
            // Add annotation to annotations collection of first page
            doc.Pages[1].Annotations.Add(annot);
            // Flattens annotation and redacts page contents (i.e. removes text and image
            // Under redacted annotation)
            annot.Redact();
            dataDir = dataDir + "RedactPage_out.pdf";
            doc.Save(dataDir);
            // ExEnd:RedactPage
            Console.WriteLine("\nCertain page region with RedactionAnnotation redact successfully.\nFile saved at " + dataDir);

        }
        public static void FacadesApproach()
        {
            // ExStart:FacadesApproach
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            Aspose.Pdf.Facades.PdfAnnotationEditor editor = new Aspose.Pdf.Facades.PdfAnnotationEditor();
            // Redact certain page region
            editor.RedactArea(1, new Aspose.Pdf.Rectangle(100, 100, 20, 70), System.Drawing.Color.White);
            editor.BindPdf(dataDir + "input.pdf");
            editor.Save( dataDir + "FacadesApproach_out.pdf");
            // ExEnd:FacadesApproach

        }
    }
}