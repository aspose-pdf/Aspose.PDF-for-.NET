using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class RotateTextUsingTextParagraphAndBuilder
    {
        public static void Run()
        {
            // ExStart:RotateTextUsingTextParagraphAndBuilder
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Initialize document object
            Document pdfDocument = new Document();
            // Get particular page
            Page pdfPage = (Page)pdfDocument.Pages.Add();
            for (int i = 0; i < 4; i++)
            {
                TextParagraph paragraph = new TextParagraph();
                paragraph.Position = new Position(200, 600);
                // Specify rotation
                paragraph.Rotation = i * 90 + 45;
                // Create text fragment
                TextFragment textFragment1 = new TextFragment("Paragraph Text");
                // Create text fragment
                textFragment1.TextState.FontSize = 12;
                textFragment1.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                textFragment1.TextState.BackgroundColor = Aspose.Pdf.Color.LightGray;
                textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.Blue;
                // Create text fragment
                TextFragment textFragment2 = new TextFragment("Second line of text");
                // Set text properties
                textFragment2.TextState.FontSize = 12;
                textFragment2.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                textFragment2.TextState.BackgroundColor = Aspose.Pdf.Color.LightGray;
                textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.Blue;
                // Create text fragment
                TextFragment textFragment3 = new TextFragment("And some more text...");
                // Set text properties
                textFragment3.TextState.FontSize = 12;
                textFragment3.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                textFragment3.TextState.BackgroundColor = Aspose.Pdf.Color.LightGray;
                textFragment3.TextState.ForegroundColor = Aspose.Pdf.Color.Blue;
                textFragment3.TextState.Underline = true;
                paragraph.AppendLine(textFragment1);
                paragraph.AppendLine(textFragment2);
                paragraph.AppendLine(textFragment3);
                // Create TextBuilder object
                TextBuilder textBuilder = new TextBuilder(pdfPage);
                // Append the text fragment to the PDF page
                textBuilder.AppendParagraph(paragraph);
            }
            // Save document
            pdfDocument.Save(dataDir + "TextFragmentTests_Rotated4_out.pdf");
            // ExEnd:RotateTextUsingTextParagraphAndBuilder           
        }
       
    }
}