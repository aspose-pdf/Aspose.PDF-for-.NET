using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class SaveFonts
    {
        public static void Run()
        {
            try
            {
                // ExStart:SaveFonts
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                // Output HTML file path information
                string outFile = Path.GetFullPath(dataDir + "36192_out.html");

                // Source PDF document
                Document doc = new Document(dataDir + "input.pdf");

                // Create HtmlSaveOption with tested feature
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                saveOptions.FixedLayout = true;
                saveOptions.SplitIntoPages = false;

                // Save the fonts as TTF format
                saveOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.AlwaysSaveAsTTF;
                string htmlFile = Path.GetFullPath(outFile);
                string linkedFilesFolder = Path.GetDirectoryName(htmlFile) + @"\36192_files";

                if (Directory.Exists(linkedFilesFolder))
                {
                    Directory.Delete(linkedFilesFolder, true);
                }

                // Save the output
                doc.Save(outFile, saveOptions);
                // ExEnd:SaveFonts
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void WOFFFormat()
        {
            // Create HtmlSaveOption with tested feature
            HtmlSaveOptions saveOptions = new HtmlSaveOptions();
            // ExStart:WOFFFormat
            saveOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.AlwaysSaveAsWOFF;
            // ExEnd:WOFFFormat
        }
        public static void ThreeSetFonts()
        {
            // ExStart:ThreeSetFonts
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();
        
            Document doc = new Document(dataDir + "input.pdf");
            HtmlSaveOptions htmlOptions = new HtmlSaveOptions();
            htmlOptions.FixedLayout = true;
            htmlOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsExternalPngFilesReferencedViaSvg;
            htmlOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;

            doc.Save(dataDir + "ThreeSetFonts_out.html", htmlOptions);
            // ExEnd:ThreeSetFonts

        }
    }
}