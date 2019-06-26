using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToSVG
    {
        public static void Run()
        {
            // ExStart:PDFToSVG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load PDF document
            Document doc = new Document(dataDir + "input.pdf");
            // Instantiate an object of SvgSaveOptions
            SvgSaveOptions saveOptions = new SvgSaveOptions();
            // Do not compress SVG image to Zip archive
            saveOptions.CompressOutputToZipArchive = false;
            // Save the output in SVG files
            doc.Save(dataDir + "PDFToSVG_out.svg", saveOptions);
            // ExEnd:PDFToSVG
        }
    }
}