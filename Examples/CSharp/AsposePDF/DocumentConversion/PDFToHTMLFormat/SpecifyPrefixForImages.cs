using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class SpecifyPrefixForImages
    {
        public static void Run()
        {
            try
            {
                // ExStart:SpecifyPrefixForImages
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                string outFile = dataDir + "SpecifyImages_out.html";

                Document doc = new Document(dataDir + "input.pdf");
                // Create HtmlSaveOption with tested feature
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                saveOptions.SplitIntoPages = false;
                saveOptions.CustomResourceSavingStrategy = new HtmlSaveOptions.ResourceSavingStrategy(SavingTestStrategy_1);

                doc.Save(outFile, saveOptions);
                // ExEnd:SpecifyPrefixForImages
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:SpecifyPrefixForImagesHelper
        private static string SavingTestStrategy_1(SaveOptions.ResourceSavingInfo resourceSavingInfo)
        {
            // This sample method saving strategy method saves only svg-files in some folder and returns specific path
            // To be used as value of 'src' or 'data' relevant attribute in generated HTML
            // All other files will be processed with converter itself cause for them flag
            // ResourceSavingInfo.CustomProcessingCancelled is set to 'true'
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();
            if (!(resourceSavingInfo is HtmlSaveOptions.HtmlImageSavingInfo))
            {
                resourceSavingInfo.CustomProcessingCancelled = true;
                return "";
            }

            HtmlSaveOptions.HtmlImageSavingInfo asHtmlImageSavingInfo = (HtmlSaveOptions.HtmlImageSavingInfo)resourceSavingInfo;

            if ((asHtmlImageSavingInfo.ImageType != HtmlSaveOptions.HtmlImageType.Svg)
                 && (asHtmlImageSavingInfo.ImageType != HtmlSaveOptions.HtmlImageType.ZippedSvg)
                )
            {
                resourceSavingInfo.CustomProcessingCancelled = true;
                return "";
            }

            string outFile = dataDir + "SpecifyImages_out.html";
            string imageOutFolder = Path.GetFullPath(Path.GetDirectoryName(outFile)
                              + @"\35956_svg_files\");
            // ImageOutFolder="C:\AsposeImagesTests\";
            if (!Directory.Exists(imageOutFolder))
            {
                Directory.CreateDirectory(imageOutFolder);
            }

            string outPath = imageOutFolder + Path.GetFileName(resourceSavingInfo.SupposedFileName);
            System.IO.BinaryReader reader = new BinaryReader(resourceSavingInfo.ContentStream);
            System.IO.File.WriteAllBytes(outPath, reader.ReadBytes((int)resourceSavingInfo.ContentStream.Length));

            return "/document-viewer/GetImage?path=CRWU-NDWAC-Final-Report-12-09-10-2.pdf&name=" + resourceSavingInfo.SupposedFileName;
        }
        // ExEnd:SpecifyPrefixForImagesHelper
    }
}