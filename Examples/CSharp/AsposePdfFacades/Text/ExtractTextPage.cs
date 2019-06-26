using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Text
{
    public class ExtractTextPage
    {
        public static void Run()
        {
            // ExStart:ExtractTextPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Text();
            // Open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractText-Page.pdf");

            // Use parameterless ExtractText method
            pdfExtractor.ExtractText();

            int pageNumber = 1;

            while (pdfExtractor.HasNextPageText())
            {
                MemoryStream tempMemoryStream = new MemoryStream();
                pdfExtractor.GetNextPageText(tempMemoryStream);
                string text = "";
                // Specify Unicode encoding type in StreamReader constructor
                using (StreamReader streamReader = new
                StreamReader(tempMemoryStream, Encoding.Unicode))
                {
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    text = streamReader.ReadToEnd();
                }
                File.WriteAllText(dataDir+ "output" + pageNumber + "_out.txt", text);
                pageNumber++;
            }
            // ExEnd:ExtractTextPage
        }
    }
}