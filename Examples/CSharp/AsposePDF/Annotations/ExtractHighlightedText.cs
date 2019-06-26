using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class ExtractHighlightedText
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();
            Document doc = new Document(dataDir + "ExtractHighlightedText.pdf");
            // Loop through all the annotations
            foreach (Annotation annotation in doc.Pages[1].Annotations)
            {
                // Filter TextMarkupAnnotation
                if (annotation is TextMarkupAnnotation)
                {
                    TextMarkupAnnotation highlightedAnnotation = annotation as TextMarkupAnnotation;
                    // Retrieve highlighted text fragments
                    TextFragmentCollection collection = highlightedAnnotation.GetMarkedTextFragments();
                    foreach (TextFragment tf in collection)
                    {
                        // Display highlighted text
                        Console.WriteLine(tf.Text);
                    }
                }
            }
            // ExEnd:1
        }
    }
}
