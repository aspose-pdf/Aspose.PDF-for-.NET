using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class RotateTextUsingTextFragmentAndParagraph
    {
        public static void Run()
        {
            // ExStart:RotateTextUsingTextFragmentAndParagraph
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Initialize document object
            Document pdfDocument = new Document();
            // Get particular page
            Page pdfPage = (Page)pdfDocument.Pages.Add();
            // Create text fragment
            TextFragment textFragment1 = new TextFragment("main text");
            // Set text properties
            textFragment1.TextState.FontSize = 12;
            textFragment1.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            // Create text fragment
            TextFragment textFragment2 = new TextFragment("rotated text");
            // Set text properties
            textFragment2.TextState.FontSize = 12;
            textFragment2.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            // Set rotation
            textFragment2.TextState.Rotation = 315;
            // Create text fragment
            TextFragment textFragment3 = new TextFragment("rotated text");
            // Set text properties
            textFragment3.TextState.FontSize = 12;
            textFragment3.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            // Set rotation
            textFragment3.TextState.Rotation = 270;
            pdfPage.Paragraphs.Add(textFragment1);
            pdfPage.Paragraphs.Add(textFragment2);
            pdfPage.Paragraphs.Add(textFragment3);
            // Save document
            pdfDocument.Save(dataDir + "TextFragmentTests_Rotated3_out.pdf");
            // ExEnd:RotateTextUsingTextFragmentAndParagraph           
        }
       
    }
}