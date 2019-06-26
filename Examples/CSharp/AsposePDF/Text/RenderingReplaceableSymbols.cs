using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class RenderingReplaceableSymbols
    {
        public static void Run()
        {
            // ExStart:RenderingReplaceableSymbols
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            Aspose.Pdf.Document pdfApplicationDoc = new Aspose.Pdf.Document();
            Aspose.Pdf.Page applicationFirstPage = (Aspose.Pdf.Page)pdfApplicationDoc.Pages.Add();

            // Initialize new TextFragment with text containing required newline markers
            Aspose.Pdf.Text.TextFragment textFragment = new Aspose.Pdf.Text.TextFragment("Applicant Name: " + Environment.NewLine + " Joe Smoe");

            // Set text fragment properties if necessary
            textFragment.TextState.FontSize = 12;
            textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman");
            textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.LightGray;
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Red;

            // Create TextParagraph object
            TextParagraph par = new TextParagraph();

            // Add new TextFragment to paragraph
            par.AppendLine(textFragment);

            // Set paragraph position
            par.Position = new Aspose.Pdf.Text.Position(100, 600);

            // Create TextBuilder object
            TextBuilder textBuilder = new TextBuilder(applicationFirstPage);
            // Add the TextParagraph using TextBuilder
            textBuilder.AppendParagraph(par);

            dataDir = dataDir + "RenderingReplaceableSymbols_out.pdf";
            pdfApplicationDoc.Save(dataDir);
            // ExEnd:RenderingReplaceableSymbols            
            Console.WriteLine("\nReplaceable symbols render successfully duing pdf creation.\nFile saved at " + dataDir);
        }
    }
}