using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddSubsequentLinesIndent
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Create new document object 
            Aspose.Pdf.Document document = new Aspose.Pdf.Document();
            Aspose.Pdf.Page page = document.Pages.Add();

            Aspose.Pdf.Text.TextFragment text = new Aspose.Pdf.Text.TextFragment("A quick brown fox jumped over the lazy dog. A quick brown fox jumped over the lazy dog. A quick brown fox jumped over the lazy dog. A quick brown fox jumped over the lazy dog. A quick brown fox jumped over the lazy dog. A quick brown fox jumped over the lazy dog. A quick brown fox jumped over the lazy dog. A quick brown fox jumped over the lazy dog.");

            // Initilize TextFormattingOptions for the text fragment and specify SubsequentLinesIndent value
            text.TextState.FormattingOptions = new Aspose.Pdf.Text.TextFormattingOptions()
            {
                SubsequentLinesIndent = 20
            };

            page.Paragraphs.Add(text);

            text = new Aspose.Pdf.Text.TextFragment("Line2");
            page.Paragraphs.Add(text);

            text = new Aspose.Pdf.Text.TextFragment("Line3");
            page.Paragraphs.Add(text);

            text = new Aspose.Pdf.Text.TextFragment("Line4");
            page.Paragraphs.Add(text);

            text = new Aspose.Pdf.Text.TextFragment("Line5");
            page.Paragraphs.Add(text);

            document.Save(dataDir + "SubsequentIndent_out.pdf", Aspose.Pdf.SaveFormat.Pdf);
            // ExEnd:1
        }
    }
}
