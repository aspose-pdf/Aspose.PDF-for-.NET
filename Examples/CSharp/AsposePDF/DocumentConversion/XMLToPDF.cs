using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class XMLToPDF
    {
        public static void Run()
        {
            // ExStart:XMLToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Instantiate Document object
            Document doc = new Document();
            // Bind source XML file
            doc.BindXml( dataDir + "sample.xml");
            // Get reference of page object from XML
            Page page = (Page)doc.GetObjectById("mainSection");
            // Get reference of first TextSegment with ID boldHtml
            TextSegment segment = (TextSegment)doc.GetObjectById("boldHtml");
            // Get reference of second TextSegment with ID strongHtml
            segment = (TextSegment)doc.GetObjectById("strongHtml");
            // Save resultant PDF file
            doc.Save(dataDir + "XMLToPDF_out.pdf");
            // ExEnd:XMLToPDF
        }
        
    }
}