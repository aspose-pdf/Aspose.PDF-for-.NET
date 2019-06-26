using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class InvisibleAnnotation
    {
        public static void Run()
        {
            // ExStart:InvisibleAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document doc = new Document(dataDir + "input.pdf");

            FreeTextAnnotation annotation = new FreeTextAnnotation(doc.Pages[1], new Aspose.Pdf.Rectangle(50, 600, 250, 650), new DefaultAppearance("Helvetica", 16, System.Drawing.Color.Red));
            annotation.Contents = "ABCDEFG";
            annotation.Characteristics.Border = System.Drawing.Color.Red;
            annotation.Flags = AnnotationFlags.Print | AnnotationFlags.NoView;
            doc.Pages[1].Annotations.Add(annotation);

            dataDir = dataDir + "InvisibleAnnotation_out.pdf";
            // Save output file
            doc.Save(dataDir);
            // ExEnd:InvisibleAnnotation
            Console.WriteLine("\nAnnotation nvisible successfully.\nFile saved at " + dataDir);
        }
    }
}