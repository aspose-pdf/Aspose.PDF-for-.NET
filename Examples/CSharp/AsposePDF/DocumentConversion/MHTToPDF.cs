using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class MHTToPDF
    {
        public static void Run()
        {
            // ExStart:MHTToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            MhtLoadOptions options = new MhtLoadOptions();
            // Load document
            Document document = new Document(dataDir  + "test.mht", options);
            // Save the output as PDF document
            document.Save(dataDir + "MHTToPDF_out.pdf");
            // ExEnd:MHTToPDF
        }
    }
}