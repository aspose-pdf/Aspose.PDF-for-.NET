using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class SaveImages
    {
        public static void Run()
        {
            try
            {
                // ExStart:SaveImages
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                // Source PDF file
                Document doc = new Document(dataDir + "input.pdf");

                // Create HtmlSaveOption with tested feature
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                saveOptions.FixedLayout = true;
                saveOptions.SplitIntoPages = false;
                saveOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsExternalPngFilesReferencedViaSvg;
              
                // Save the output in HTML format
                doc.Save( dataDir + "SaveImages_out.html", saveOptions);
                // ExEnd:SaveImages
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}