using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddTextBorder
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Create new document object 
            Document pdfDocument = new Document();
            // Get particular page
            Page pdfPage = (Page)pdfDocument.Pages.Add();
            // Create text fragment
            TextFragment textFragment = new TextFragment("main text");
            textFragment.Position = new Position(100, 600);
            // Set text properties
            textFragment.TextState.FontSize = 12;
            textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.LightGray;
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Red;
            // Set StrokingColor property for drawing border (stroking) around text rectangle
            textFragment.TextState.StrokingColor = Aspose.Pdf.Color.DarkRed;
            // Set DrawTextRectangleBorder property value to true
            textFragment.TextState.DrawTextRectangleBorder = true;
            TextBuilder tb = new TextBuilder(pdfPage);
            tb.AppendText(textFragment);
            // Save the document
            pdfDocument.Save(dataDir + "PDFWithTextBorder_out.pdf");
            // ExEnd:1
        }
    }
}
