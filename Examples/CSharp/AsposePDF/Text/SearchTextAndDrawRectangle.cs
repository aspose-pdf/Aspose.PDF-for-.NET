using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class SearchTextAndDrawRectangle
    {
        public static void Run()
        {
            // ExStart:SearchTextAndDrawRectangle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document document = new Document(dataDir + "SearchAndGetTextFromAll.pdf");

            // Create TextAbsorber object to find all the phrases matching the regular expression

            TextFragmentAbsorber textAbsorber = new TextFragmentAbsorber(@"[\S]+");

            TextSearchOptions textSearchOptions = new TextSearchOptions(true);

            textAbsorber.TextSearchOptions = textSearchOptions;

            document.Pages.Accept(textAbsorber); 

            var editor = new PdfContentEditor(document); 

            foreach (TextFragment textFragment in textAbsorber.TextFragments)

            {

                foreach (TextSegment textSegment in textFragment.Segments)

                {

                        DrawBox(editor, textFragment.Page.Number, textSegment, System.Drawing.Color.Red);

                }

            }
            dataDir = dataDir + "SearchTextAndDrawRectangle_out.pdf";
            document.Save(dataDir);
            // ExEnd:SearchTextAndDrawRectangle
            Console.WriteLine("\nRectangle drawn successfully on searched text.\nFile saved at " + dataDir);
        }
        // ExStart:DrawBox
        private static void DrawBox(PdfContentEditor editor, int page, TextSegment segment, System.Drawing.Color color)
        {

            var lineInfo = new LineInfo();

            lineInfo.VerticeCoordinate = new[] {

            (float)segment.Rectangle.LLX, (float)segment.Rectangle.LLY,

            (float)segment.Rectangle.LLX, (float)segment.Rectangle.URY,

            (float)segment.Rectangle.URX, (float)segment.Rectangle.URY,

            (float)segment.Rectangle.URX, (float)segment.Rectangle.LLY

            };

            lineInfo.Visibility = true;

            lineInfo.LineColor = color;

            editor.CreatePolygon(lineInfo, page, new System.Drawing.Rectangle(0, 0, 0, 0), null);

        }
        // ExEnd:DrawBox
    }
}