using Aspose.Pdf.Annotations;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class AddAnnotation
    {
        public static void Run()
        {
            // ExStart:AddAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document pdfDocument = new Document(dataDir + "AddAnnotation.pdf");

            // Create annotation
            TextAnnotation textAnnotation = new TextAnnotation(pdfDocument.Pages[1], new Aspose.Pdf.Rectangle(200, 400, 400, 600));
            textAnnotation.Title = "Sample Annotation Title";
            textAnnotation.Subject = "Sample Subject";
            textAnnotation.Contents = "Sample contents for the annotation";
            textAnnotation.Open = true;
            textAnnotation.Icon = TextIcon.Key;

            Border border = new Border(textAnnotation);
            border.Width = 5;
            border.Dash = new Dash(1, 1);
            textAnnotation.Border = border;
            textAnnotation.Rect = new Aspose.Pdf.Rectangle(200, 400, 400, 600);

            // Add annotation in the annotations collection of the page
            pdfDocument.Pages[1].Annotations.Add(textAnnotation);
            dataDir = dataDir + "AddAnnotation_out.pdf";
            // Save output file
            pdfDocument.Save(dataDir);
            // ExEnd:AddAnnotation
            Console.WriteLine("\nAnnotation added successfully.\nFile saved at " + dataDir);
        }
    }
}