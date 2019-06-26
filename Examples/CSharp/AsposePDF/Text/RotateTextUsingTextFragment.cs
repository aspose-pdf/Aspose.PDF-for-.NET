using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class RotateTextUsingTextFragment
    {
        public static void Run()
        {
            // ExStart:RotateTextUsingTextFragment
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Initialize document object
            Document pdfDocument = new Document();
            // Get particular page
            Page pdfPage = (Page)pdfDocument.Pages.Add();
            // Create text fragment
            TextFragment textFragment1 = new TextFragment("main text");
            textFragment1.Position = new Position(100, 600);
            // Set text properties
            textFragment1.TextState.FontSize = 12;
            textFragment1.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            // Create rotated text fragment
            TextFragment textFragment2 = new TextFragment("rotated text");
            textFragment2.Position = new Position(200, 600);
            // Set text properties
            textFragment2.TextState.FontSize = 12;
            textFragment2.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            textFragment2.TextState.Rotation = 45;
            // Create rotated text fragment
            TextFragment textFragment3 = new TextFragment("rotated text");
            textFragment3.Position = new Position(300, 600);
            // Set text properties
            textFragment3.TextState.FontSize = 12;
            textFragment3.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            textFragment3.TextState.Rotation = 90;
            // create TextBuilder object
            TextBuilder textBuilder = new TextBuilder(pdfPage);
            // Append the text fragment to the PDF page
            textBuilder.AppendText(textFragment1);
            textBuilder.AppendText(textFragment2);
            textBuilder.AppendText(textFragment3);
            // Save document
            pdfDocument.Save(dataDir + "TextFragmentTests_Rotated1_out.pdf");
            // ExEnd:RotateTextUsingTextFragment           
        }
       
    }
}