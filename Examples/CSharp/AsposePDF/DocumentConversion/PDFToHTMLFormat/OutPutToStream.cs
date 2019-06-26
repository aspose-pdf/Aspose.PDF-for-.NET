using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class OutPutToStream
    {
        public static void Run()
        {
            try
            {
                // ExStart:OutPutToStream
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                Document doc = new Document( dataDir + "input.pdf");

                // Tune conversion params
                HtmlSaveOptions newOptions = new HtmlSaveOptions();
                newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;
                newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;
                newOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml;
                newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss;
                newOptions.SplitIntoPages = false;// Force write HTMLs of all pages into one output document

                newOptions.CustomHtmlSavingStrategy = new HtmlSaveOptions.HtmlPageMarkupSavingStrategy(SavingToStream);
                // We can use some non-existing puth as result file name - all real saving will be done
                // In our custom method SavingToStream() (it's follows this one)                
                doc.Save(dataDir + "OutPutToStream_out.html", newOptions);
                // ExEnd:OutPutToStream
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:SavingToStream
        private static void SavingToStream(HtmlSaveOptions.HtmlPageMarkupSavingInfo htmlSavingInfo)
        {
            byte[] resultHtmlAsBytes = new byte[htmlSavingInfo.ContentStream.Length];
            htmlSavingInfo.ContentStream.Read(resultHtmlAsBytes, 0, resultHtmlAsBytes.Length);
            // Here You can use any writable stream, file stream is taken just as example
            string fileName = "stream_out.html";
            Stream outStream = File.OpenWrite(fileName);
            outStream.Write(resultHtmlAsBytes, 0, resultHtmlAsBytes.Length);
        }
        // ExEnd:SavingToStream

        // ExStart:OutPutToStreamHelper
        static string _folderForReferencedResources_34748;
        public static void PDFNEWNET_34748()
        {
            //-----------------------------------------------------
            // 1) Tune paths and set license
            //-----------------------------------------------------
            (new Aspose.Pdf.License()).SetLicense(@"F:\_Sources\Aspose_5\trunk\testdata\License\Aspose.Total.lic");
            Document pdfDocument = new Document(@"F:\ExternalTestsData\34748_36189.pdf");
            string outHtmlFile = @"F:\ExternalTestsData\34748.html";
            _folderForReferencedResources_34748 = @"F:\ExternalTestsData\out_34748\";
            //-----------------------------------------------------
            // 2) Clean results if they already present
            //-----------------------------------------------------
            if (Directory.Exists(_folderForReferencedResources_34748))
            {
                Directory.Delete(_folderForReferencedResources_34748, true);
            }
            File.Delete(outHtmlFile);
            //-----------------------------------------------------
            // Create HtmlSaveOption with tested feature
            //-----------------------------------------------------
            HtmlSaveOptions saveOptions = new HtmlSaveOptions();
            saveOptions.CustomResourceSavingStrategy = new HtmlSaveOptions.ResourceSavingStrategy(Strategy_11_CUSTOM_SAVE_OF_FONTS_AND_IMAGES);
            saveOptions.CustomCssSavingStrategy = new HtmlSaveOptions.CssSavingStrategy(Strategy_11_CSS_WriteCssToPredefinedFolder);
            saveOptions.CustomStrategyOfCssUrlCreation = new HtmlSaveOptions.CssUrlMakingStrategy(Strategy_11_CSS_ReturnResultPathInPredefinedTestFolder);

            using (Stream outStream = File.OpenWrite(outHtmlFile))
            {
                pdfDocument.Save(outStream, saveOptions);
            }
        }

        private static void Strategy_11_CSS_WriteCssToPredefinedFolder(HtmlSaveOptions.CssSavingInfo resourceInfo)
        {
            if (!Directory.Exists(_folderForReferencedResources_34748))
            {
                Directory.CreateDirectory(_folderForReferencedResources_34748);
            }
            string path = _folderForReferencedResources_34748 + Path.GetFileName(resourceInfo.SupposedURL);
            System.IO.BinaryReader reader = new BinaryReader(resourceInfo.ContentStream);
            System.IO.File.WriteAllBytes(path, reader.ReadBytes((int)resourceInfo.ContentStream.Length));
        }
        private static string Strategy_11_CSS_ReturnResultPathInPredefinedTestFolder(HtmlSaveOptions.CssUrlRequestInfo requestInfo)
        {
            return "file:///" + _folderForReferencedResources_34748.Replace(@"\", "/") + "css_style{0}.css";
        }
        private static string Strategy_11_CUSTOM_SAVE_OF_FONTS_AND_IMAGES(SaveOptions.ResourceSavingInfo resourceSavingInfo)
        {
            if (!Directory.Exists(_folderForReferencedResources_34748))
            {
                Directory.CreateDirectory(_folderForReferencedResources_34748);
            }
            string path = _folderForReferencedResources_34748 + Path.GetFileName(resourceSavingInfo.SupposedFileName);
            // The first path of this method is for saving fonts
            System.IO.BinaryReader contentReader = new BinaryReader(resourceSavingInfo.ContentStream);
            System.IO.File.WriteAllBytes(path, contentReader.ReadBytes((int)resourceSavingInfo.ContentStream.Length));
            string urlThatWillBeUsedInHtml = "file:///" + _folderForReferencedResources_34748.Replace(@"\", "/") + Path.GetFileName(resourceSavingInfo.SupposedFileName);
            return urlThatWillBeUsedInHtml;
        }
        // ExEnd:OutPutToStreamHelper
    }
}