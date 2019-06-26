using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class ExportDataToXML
    {
        public static void Run()
        {
            // ExStart:ExportDataToXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            // Open document
            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form();

            form.BindPdf(dataDir + "input.pdf");

            // Create xml file.
            System.IO.FileStream xmlOutputStream = new FileStream( dataDir + "input.xml", FileMode.Create);

            // Export data
            form.ExportXml(xmlOutputStream);

            // Close file stream
            xmlOutputStream.Close();

            // Close the document
            form.Dispose();
            // ExEnd:ExportDataToXML
        }        
    }
}