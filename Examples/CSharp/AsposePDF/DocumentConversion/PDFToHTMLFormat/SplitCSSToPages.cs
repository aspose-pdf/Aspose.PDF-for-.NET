using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class SplitCSSToPages
    {
        public static void Run()
        {
            try
            {
                // ExStart:SplitCSSToPages
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                // 1) Clean-up target folders
                string htmlFile = Path.GetFullPath(dataDir + "resultant.html");
                string imagesDir = Path.GetDirectoryName(htmlFile) + @"\35942_files";
                string cssDir = Path.GetDirectoryName(htmlFile) + @"\35942_css_files";
                if (Directory.Exists(imagesDir)) { Directory.Delete(imagesDir, true); };
                if (Directory.Exists(cssDir)) { Directory.Delete(cssDir, true); };

                // 2) Create document for conversion
                Document pdfDocument = new Document(dataDir + "input.pdf");

                // 3) Tune conversion options
                HtmlSaveOptions options = new HtmlSaveOptions();
                options.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsPngImagesEmbeddedIntoSvg;//<- to get compatibility with previous behavior and therefore same result of tests
                // Split HTML output into pages
                options.SplitIntoPages = true;
                // Split css into pages
                options.SplitCssIntoPages = true;
                options.CustomCssSavingStrategy = new HtmlSaveOptions.CssSavingStrategy(Strategy_4_CSS_MULTIPAGE_SAVING_RIGHT_WAY);
                options.CustomStrategyOfCssUrlCreation = new HtmlSaveOptions.CssUrlMakingStrategy(Strategy_5_CSS_MAKING_CUSTOM_URL_FOR_MULTIPAGING);
                // 3) Do conversion
                pdfDocument.Save(htmlFile, options);
                // ExEnd:SplitCSSToPages
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:SplitCSSToPagesHelpers
        private static void Strategy_4_CSS_MULTIPAGE_SAVING_RIGHT_WAY(HtmlSaveOptions.CssSavingInfo partSavingInfo)
        {
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

            string outPath = dataDir + "style_xyz_page" + partSavingInfo.CssNumber.ToString() + ".css";
            System.IO.BinaryReader reader = new BinaryReader(partSavingInfo.ContentStream);
            System.IO.File.WriteAllBytes(outPath, reader.ReadBytes((int)partSavingInfo.ContentStream.Length));
        }

        private static string Strategy_5_CSS_MAKING_CUSTOM_URL_FOR_MULTIPAGING(HtmlSaveOptions.CssUrlRequestInfo requestInfo)
        {
            return "/document-viewer/GetCss?cssId=4544554445_page{0}";
        }
        // ExEnd:SplitCSSToPagesHelpers
    }
}