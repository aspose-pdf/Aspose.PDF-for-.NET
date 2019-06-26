using System;
using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class SetFreeTextAnnotationFormatting
    {
        public static void Run()
        {
            // ExStart:SetFreeTextAnnotationFormatting
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();
            
            // Open document
            Document pdfDocument = new Document(dataDir + "SetFreeTextAnnotationFormatting.pdf");

            // Instantiate DefaultAppearance object
            DefaultAppearance default_appearance = new DefaultAppearance("Arial", 28, System.Drawing.Color.Red);
            // Create annotation
            FreeTextAnnotation freetext = new FreeTextAnnotation(pdfDocument.Pages[1], new Aspose.Pdf.Rectangle(200, 400, 400, 600), default_appearance);
            // Specify the contents of annotation
            freetext.Contents = "Free Text";
            // Add anootation to annotations collection of page
            pdfDocument.Pages[1].Annotations.Add(freetext);
            dataDir = dataDir + "SetFreeTextAnnotationFormatting_out.pdf";
            // Save the updated document
            pdfDocument.Save(dataDir);
            // ExEnd:SetFreeTextAnnotationFormatting
            Console.WriteLine("\nFree TextAnnotation with specific text formatting added successfully.\nFile saved at " + dataDir);
            
        }
    }
}