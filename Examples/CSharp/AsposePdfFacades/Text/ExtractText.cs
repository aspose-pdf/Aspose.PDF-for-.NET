using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Text
{
    public class ExtractText
    {
        public static void Run()
        {
            // ExStart:ExtractText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Text();
            // Open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractText.pdf");

            // Use parameterless ExtractText method
            pdfExtractor.ExtractText();

            MemoryStream tempMemoryStream = new MemoryStream();
            pdfExtractor.GetText(tempMemoryStream);

            string text = "";
            // Specify Unicode encoding type in StreamReader constructor
            using (StreamReader streamReader = new StreamReader(tempMemoryStream, Encoding.Unicode))
            {
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                text = streamReader.ReadToEnd();
            }

            File.WriteAllText(dataDir+ "output_out.txt", text);
            // ExEnd:ExtractText
        }
    }
}