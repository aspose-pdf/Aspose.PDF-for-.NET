using Aspose.Pdf.Text;
using System.IO;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class SpecifyLineSpacing
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            string fontFile = dataDir + "HPSimplified.TTF";
            // Load input PDF file
            Document doc = new Document();
            //Create TextFormattingOptions with LineSpacingMode.FullSize
            TextFormattingOptions formattingOptions = new TextFormattingOptions();
            formattingOptions.LineSpacing = TextFormattingOptions.LineSpacingMode.FullSize;

            // Create text builder object for first page of document
            //TextBuilder textBuilder = new TextBuilder(doc.Pages[1]);
            // Create text fragment with sample string
            TextFragment textFragment = new TextFragment("Hello world");

            if (fontFile != "")
            {
                // Load the TrueType font into stream object
                using (FileStream fontStream = System.IO.File.OpenRead(fontFile))
                {
                    // Set the font name for text string
                    textFragment.TextState.Font = FontRepository.OpenFont(fontStream, FontTypes.TTF);
                    // Specify the position for Text Fragment
                    textFragment.Position = new Position(100, 600);
                    //Set TextFormattingOptions of current fragment to predefined(which points to LineSpacingMode.FullSize)
                    textFragment.TextState.FormattingOptions = formattingOptions;
                    // Add the text to TextBuilder so that it can be placed over the PDF file
                    //textBuilder.AppendText(textFragment);
                    var page = doc.Pages.Add();
                    page.Paragraphs.Add(textFragment);
                }

                dataDir = dataDir + "SpecifyLineSpacing_out.pdf";
                // Save resulting PDF document
                doc.Save(dataDir);
            }
            // ExEnd:1
        }
    }
}
