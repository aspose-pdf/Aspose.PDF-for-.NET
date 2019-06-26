using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class SingleHTML
    {
        public static void Run()
        {
            try
            {
                // ExStart:SingleHTML
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                // Load source PDF file
                Document doc = new Document(dataDir + "input.pdf");
                // Instantiate HTML Save options object
                HtmlSaveOptions newOptions = new HtmlSaveOptions();

                // Enable option to embed all resources inside the HTML
                newOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml;

                // This is just optimization for IE and can be omitted 
                newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss;
                newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;
                newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;
                // Output file path 
                string outHtmlFile = "SingleHTML_out.html";
                doc.Save(outHtmlFile, newOptions);
                // ExEnd:SingleHTML
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}