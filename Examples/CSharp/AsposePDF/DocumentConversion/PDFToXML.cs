using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToXML
    {
        public static void Run()
        {
            // ExStart:PDFToXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();            
            // Load source PDF file
            Document doc = new Document(dataDir + "input.pdf");
            // Save output in XML format
            doc.Save(dataDir + "PDFToXML_out.xml", SaveFormat.MobiXml);
            // ExEnd:PDFToXML
        }
    }
}