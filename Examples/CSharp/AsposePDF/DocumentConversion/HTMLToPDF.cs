using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class HTMLToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:HTMLToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

                HtmlLoadOptions options = new HtmlLoadOptions();
                options.CustomLoaderOfExternalResources = new LoadOptions.ResourceLoadingStrategy(SamePictureLoader);

                Document pdfDocument = new Document(dataDir + "HTMLToPDF.html", options);
                pdfDocument.Save("HTMLToPDF_out.pdf");
                // ExEnd:HTMLToPDF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
   
        // ExStart:HTMLToPDFHelper
        private static LoadOptions.ResourceLoadingResult SamePictureLoader(string resourceURI)
        {
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            byte[] resultBytes = File.ReadAllBytes(dataDir + "aspose-logo.jpg");
            LoadOptions.ResourceLoadingResult result = new LoadOptions.ResourceLoadingResult(resultBytes);
            return result;
        }
        // ExEnd:HTMLToPDFHelper


        public static void RenderContentToSamePage()
        {
            // ExStart:RenderContentToSamePage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            // Initialize HTMLLoadSave Options
            HtmlLoadOptions options = new HtmlLoadOptions();
            // Set Render to single page property
            options.IsRenderToSinglePage = true;
            // Load document 
            Document doc = new Document(dataDir + "HTMLToPDF.html", options);
            // Save
            doc.Save(dataDir + "RenderContentToSamePage.pdf");
            // ExEnd:RenderContentToSamePage

        }
        public static void RenderHTMLwithSVGData()
        {
            // ExStart:RenderHTMLwithSVGData
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            // Set input file path
            string inFile = dataDir + "HTMLSVG.html";
            // Set output file path
            string outFile = dataDir + "RenderHTMLwithSVGData.pdf";
            // Initialize HtmlLoadOptions
            HtmlLoadOptions options = new HtmlLoadOptions(Path.GetDirectoryName(inFile));
            // Initialize Document object
            Document pdfDocument = new Document(inFile, options);
            // save
            pdfDocument.Save(outFile);
            // ExEnd:RenderHTMLwithSVGData

        }
    }
}