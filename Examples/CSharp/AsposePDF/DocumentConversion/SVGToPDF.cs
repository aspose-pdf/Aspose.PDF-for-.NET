using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class SVGToPDF
    {
        public static void Run()
        {
            // ExStart:SVGToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Instantiate LoadOption object using SVG load option
            Aspose.Pdf.LoadOptions loadopt = new Aspose.Pdf.SvgLoadOptions();

            // Create Document object
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "SVGToPDF.svg", loadopt);

            // Save the resultant PDF document
            doc.Save(dataDir + "SVGToPDF_out.pdf");
            // ExEnd:SVGToPDF
        }
    }
}