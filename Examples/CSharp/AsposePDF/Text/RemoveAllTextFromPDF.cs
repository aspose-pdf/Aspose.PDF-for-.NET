using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class RemoveAllTextFromPDF
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "RemoveAllText.pdf");

            // Initiate TextFragmentAbsorber
            TextFragmentAbsorber absorber = new TextFragmentAbsorber();

            // Remove all absorbed text
            absorber.RemoveAllText(pdfDocument);

            // Save the document
            pdfDocument.Save(dataDir + "RemoveAllText_out.pdf", Aspose.Pdf.SaveFormat.Pdf);
            // ExEnd:1
        }
    }
}
