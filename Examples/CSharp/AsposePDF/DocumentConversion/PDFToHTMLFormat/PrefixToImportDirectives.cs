using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class PrefixToImportDirectives
    {
         private static string _folderForReferencedResources_36435;
        public static void Run()
        {
            try
            {
                // ExStart:PrefixToImportDirectives
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();
                string linceseFile = ""; // E.g @"F:\_Sources\Aspose.Total.lic"
                (new Aspose.Pdf.License()).SetLicense(linceseFile);
                Document pdfDocument = new Document(dataDir + "input.pdf");
                string outHtmlFile = dataDir + "PrefixToImportDirectives_out.html";
                _folderForReferencedResources_36435 = dataDir;
                // Create HtmlSaveOption with tested feature
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                saveOptions.CustomStrategyOfCssUrlCreation = new HtmlSaveOptions.CssUrlMakingStrategy(Strategy_10_CSS_ReturnResultPathInPredefinedTestFolder);
                saveOptions.CustomCssSavingStrategy = new HtmlSaveOptions.CssSavingStrategy(Strategy_10_CSS_WriteCssToResourceFolder);
                //----------------------------------------------------------------------------
                // Run converter
                //----------------------------------------------------------------------------
                pdfDocument.Save(outHtmlFile, saveOptions);
                // ExEnd:PrefixToImportDirectives
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:PrefixToImportDirectivesHelper
        private static void Strategy_10_CSS_WriteCssToResourceFolder(HtmlSaveOptions.CssSavingInfo resourceInfo)
        {
            // -------------------------------------------------------
            // This is only one of possible implementation of saving
            // You can write and use Your own implementation if You will
            // -------------------------------------------------------

            // Get CSS file name from requested file.
            // Some trick required cause we get in parameters of this method
            // Not pure file name but full URL that
            // Created with usage of our template returned in Strategy_9_CSS_ReturnResultPathInPredefinedTestFolder()
            // So, knowing of that template we must extract from it CSS file name itself
            string guid = System.Guid.NewGuid().ToString();
            string fullPathWithGuid = Strategy_10_CSS_ReturnResultPathInPredefinedTestFolder(new HtmlSaveOptions.CssUrlRequestInfo());
            fullPathWithGuid = string.Format(fullPathWithGuid, guid);
            int prefixLength = fullPathWithGuid.IndexOf(guid);
            int suffixLength = fullPathWithGuid.Length - (fullPathWithGuid.IndexOf(guid) + guid.Length);
            string fullPath = resourceInfo.SupposedURL;
            fullPath = fullPath.Substring(prefixLength);
            string cssFileNameCore = fullPath.Substring(0, fullPath.Length - suffixLength);

            // Get final file name for saving
            string cssFileName = "style" + cssFileNameCore + ".css";
            string path = _folderForReferencedResources_36435 + cssFileName;

            // Saving itself
            System.IO.BinaryReader reader = new BinaryReader(resourceInfo.ContentStream);
            System.IO.File.WriteAllBytes(path, reader.ReadBytes((int)resourceInfo.ContentStream.Length));
        }
        private static string Strategy_10_CSS_ReturnResultPathInPredefinedTestFolder(HtmlSaveOptions.CssUrlRequestInfo requestInfo)
        {
            string template = "http:// Localhost:24661/document-viewer/GetResourceForHtmlHandler?documentPath=Deutschland201207Arbeit.pdf&resourcePath=style{0}.css&fileNameOnly=false";
            return template;
        }
        // ExEnd:PrefixToImportDirectivesHelper
    }
}