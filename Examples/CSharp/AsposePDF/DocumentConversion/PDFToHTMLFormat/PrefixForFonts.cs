using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class PrefixForFonts
    {
        private static int _fontNumberForUniqueFontFileNames;
        private static string _desiredFontDir;
        public static void Run()
        {
            try
            {
                // ExStart:PrefixForFonts
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                Document doc = new Document(dataDir + "input.pdf");
                string outHtmlFile = dataDir + "PrefixForFonts_out.html";
                _desiredFontDir = Path.GetDirectoryName(outHtmlFile) + @"\36296_files\";
                if (!Directory.Exists(_desiredFontDir))
                {
                    Directory.CreateDirectory(_desiredFontDir);
                }
                // Reset counter for font names - this counter will be used in our custom code
                // To generate unigue font file names

                _fontNumberForUniqueFontFileNames = 0;

                // Create HtmlSaveOption with custom saving strategy that will do all the job
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                saveOptions.CustomResourceSavingStrategy = new HtmlSaveOptions.ResourceSavingStrategy(CustomResourcesProcessing);
                doc.Save(outHtmlFile, saveOptions);
                // ExEnd:PrefixForFonts
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:PrefixForFontsHelper
        private static string CustomResourcesProcessing(SaveOptions.ResourceSavingInfo resourceSavingInfo)
        {
            //-----------------------------------------------------------------------------
            // It's just example of possible realization of cusstom processing of resources
            // Referenced in result HTML
            //-----------------------------------------------------------------------------

            // 1) In this case we need only do something special
            //    with fonts, so let's leave processing of all other resources
            //    to converter itself
            if (resourceSavingInfo.ResourceType != SaveOptions.NodeLevelResourceType.Font)
            {
                resourceSavingInfo.CustomProcessingCancelled = true;
                return "";
            }

            // If supplied font resource, process it ourselves
            // 1) Write supplied font with short name  to desired folder
            //    You can easily do anythings  - it's just one of realizations

            _fontNumberForUniqueFontFileNames++;
            string shortFontFileName = (_fontNumberForUniqueFontFileNames.ToString() + Path.GetExtension(resourceSavingInfo.SupposedFileName));
            string outFontPath = _desiredFontDir + "\\" + shortFontFileName;

            System.IO.BinaryReader fontBinaryReader = new BinaryReader(resourceSavingInfo.ContentStream);
            System.IO.File.WriteAllBytes(outFontPath, fontBinaryReader.ReadBytes((int)resourceSavingInfo.ContentStream.Length));


            // 2) Return the desired URI with which font will be referenced in CSSes
            string fontUrl = "http:// Localhost:255/document-viewer/GetFont/" + shortFontFileName;
            return fontUrl;
        }
        // ExEnd:PrefixForFontsHelper

    }
}