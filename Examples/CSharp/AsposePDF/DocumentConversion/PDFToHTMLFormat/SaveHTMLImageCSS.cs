using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class SaveHTMLImageCSS
    {
        public static void Run()
        {
            try
            {
                // ExStart:SaveHTMLImageCSS
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                Document doc = new Document(dataDir + "input.pdf");

                // Pay attention that we put non-existing path here : since we use custon resource processing it won't be in use.
                // If You forget implement some of required saving strategies(CustomHtmlSavingStrategy,CustomResourceSavingStrategy,CustomCssSavingStrategy), then saving will return "Path not found" exception
                string outHtmlFile = dataDir + "SaveHTMLImageCSS_out.html";

                // Create HtmlSaveOption with custom saving strategies that will do all the saving job
                // In such approach You can split HTML in pages if You will
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                saveOptions.SplitIntoPages = true;

                saveOptions.CustomHtmlSavingStrategy = new HtmlSaveOptions.HtmlPageMarkupSavingStrategy(StrategyOfSavingHtml);
                saveOptions.CustomResourceSavingStrategy = new HtmlSaveOptions.ResourceSavingStrategy(CustomSaveOfFontsAndImages);
                saveOptions.CustomStrategyOfCssUrlCreation = new HtmlSaveOptions.CssUrlMakingStrategy(CssUrlMakingStrategy);
                saveOptions.CustomCssSavingStrategy = new HtmlSaveOptions.CssSavingStrategy(CustomSavingOfCss);

                saveOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;
                saveOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;
                doc.Save(outHtmlFile, saveOptions);

                Console.WriteLine("Done");
                Console.ReadLine();
                // ExEnd:SaveHTMLImageCSS
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:SaveHTMLImageCSSHelper
        private static void StrategyOfSavingHtml(HtmlSaveOptions.HtmlPageMarkupSavingInfo htmlSavingInfo)
        {
            // Get target file name and write content to it
            System.IO.BinaryReader reader = new BinaryReader(htmlSavingInfo.ContentStream);
            byte[] htmlAsByte = reader.ReadBytes((int)htmlSavingInfo.ContentStream.Length);
            Console.WriteLine("Html page processed with handler. Length of page's text in bytes is " + htmlAsByte.Length.ToString());

            // Here You can put code that will save page's HTML to some storage, f.e database
            MemoryStream targetStream = new MemoryStream();
            targetStream.Write(htmlAsByte, 0, htmlAsByte.Length);
        }
        private static string CssUrlMakingStrategy(HtmlSaveOptions.CssUrlRequestInfo requestInfo)
        {
            string template = "style{0}.css";
            // One more example of template :
            // String template = "http:// Localhost:24661/document-viewer/GetResourceForHtmlHandler?documentPath=Deutschland201207Arbeit.pdf&resourcePath=style{0}.css&fileNameOnly=false";
            return template;
        }

        private static void CustomSavingOfCss(HtmlSaveOptions.CssSavingInfo resourceInfo)
        {
            System.IO.BinaryReader reader = new BinaryReader(resourceInfo.ContentStream);
            byte[] cssAsBytes = reader.ReadBytes((int)resourceInfo.ContentStream.Length);
            Console.WriteLine("Css page processed with handler. Length of css in bytes is " + cssAsBytes.Length.ToString());

            // Here You can put code that will save page's HTML to some storage, f.e database
            MemoryStream targetStream = new MemoryStream();
            targetStream.Write(cssAsBytes, 0, cssAsBytes.Length);
        }

        private static string CustomSaveOfFontsAndImages(SaveOptions.ResourceSavingInfo resourceSavingInfo)
        {
            System.IO.BinaryReader reader = new BinaryReader(resourceSavingInfo.ContentStream);
            byte[] resourceAsBytes = reader.ReadBytes((int)resourceSavingInfo.ContentStream.Length);

            if (resourceSavingInfo.ResourceType == SaveOptions.NodeLevelResourceType.Font)
            {
                Console.WriteLine("Font processed with handler. Length of content in bytes is " + resourceAsBytes.Length.ToString());
                // Here You can put code that will save font to some storage, f.e database
                MemoryStream targetStream = new MemoryStream();
                targetStream.Write(resourceAsBytes, 0, resourceAsBytes.Length);
            }
            else if (resourceSavingInfo.ResourceType == SaveOptions.NodeLevelResourceType.Image)
            {
                Console.WriteLine("Image processed with handler. Length of content in bytes is " + resourceAsBytes.Length.ToString());
                // Here You can put code that will save image to some storage, f.e database
                MemoryStream targetStream = new MemoryStream();
                targetStream.Write(resourceAsBytes, 0, resourceAsBytes.Length);
            }

            // We should return URI bt which resource will be referenced in CSS(for font)
            // Or HTML(for images)
            //  This  is very siplistic way - here we just return file name or resource.
            //  You can put here some URI that will include ID of resource in database etc. 
            //  - this URI will be added into result CSS or HTML to refer the resource
            return resourceSavingInfo.SupposedFileName;
        }
        // ExEnd:SaveHTMLImageCSSHelper
    }
}