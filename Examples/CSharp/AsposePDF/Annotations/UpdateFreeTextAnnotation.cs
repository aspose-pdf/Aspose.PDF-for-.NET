using System;
using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class UpdateFreeTextAnnotation
    {
        public static void Run()
        {
            try
            {
                // ExStart:UpdateFreeTextAnnotation
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

                // Open document
                Document doc1 = new Document(dataDir + "input.pdf");

                // Set font size and color of the annotation:
                (doc1.Pages[1].Annotations[0] as FreeTextAnnotation).TextStyle.FontSize = 18;
                (doc1.Pages[1].Annotations[0] as FreeTextAnnotation).TextStyle.Color = System.Drawing.Color.Green;
                // ExEnd:UpdateFreeTextAnnotation
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}