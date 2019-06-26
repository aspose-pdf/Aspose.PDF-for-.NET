using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class PrefixForURLs
    {
        public static void Run()
        {
            try
            {
                // ExStart:PrefixForURLs
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();
                                
                Document testDoc = new Document(dataDir + "input.pdf");

                HtmlSaveOptions options = new HtmlSaveOptions();
                // This is main setting that allows work and testing of tested feature
                options.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsExternalPngFilesReferencedViaSvg;//


                options.CustomResourceSavingStrategy = new HtmlSaveOptions.ResourceSavingStrategy(Custom_processor_of_embedded_images);
                                
                // Do conversion
                testDoc.Save(dataDir + @"PrefixForURLs_out.html", options);
                // ExEnd:PrefixForURLs
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:PrefixForURLsHelper
        private static string Custom_processor_of_embedded_images(SaveOptions.ResourceSavingInfo resourceSavingInfo)
        {
            // ____________________________________________________________________________
            //    This sample method saving strategy method saves image-files in some folder
            //    (including raster image files that are exctracted from that SVGs)
            //    Then it returns specific custom artificial  path
            //    to be used as value of 'src' or 'data' relevant attribute in generated host-SVG(or HTML)
            // ____________________________________________________________________________

            //---------------------------------------------------------
            // 1) All other files(f.e. fonts) will be processed with converter itself cause for them flag
            //   resourceSavingInfo.CustomProcessingCancelled is set to 'true'
            //---------------------------------------------------------
            if (!(resourceSavingInfo is HtmlSaveOptions.HtmlImageSavingInfo))
            {
                resourceSavingInfo.CustomProcessingCancelled = true;
                return "";
            }
            //---------------------------------------------------------
            // 1) Create target folder if not created yet
            //---------------------------------------------------------
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();
            string outDir = dataDir + @"output\36297_files\";
            string outPath = outDir + Path.GetFileName(resourceSavingInfo.SupposedFileName);
            if (!Directory.Exists(outDir))
            {
                Directory.CreateDirectory(outDir);
            }
            //---------------------------------------------------------
            // 3) Write supplied image to that folder
            //---------------------------------------------------------
            System.IO.BinaryReader reader = new BinaryReader(resourceSavingInfo.ContentStream);
            System.IO.File.WriteAllBytes(dataDir, reader.ReadBytes((int)resourceSavingInfo.ContentStream.Length));
            //---------------------------------------------------------
            // 4) Return customized specific URL to be used to refer
            //    just created image in parent SVG (or HTML)
            //---------------------------------------------------------
            HtmlSaveOptions.HtmlImageSavingInfo asHtmlImageSavingInfo = resourceSavingInfo as HtmlSaveOptions.HtmlImageSavingInfo;
            if (asHtmlImageSavingInfo.ParentType == HtmlSaveOptions.ImageParentTypes.SvgImage)
            {
                return "http:// Localhost:255/" + resourceSavingInfo.SupposedFileName;
            }
            else
            {
                return "http:// Localhost:GetImage/imageID=" + resourceSavingInfo.SupposedFileName;
            }
        }
        // ExEnd:PrefixForURLsHelper

    }
}