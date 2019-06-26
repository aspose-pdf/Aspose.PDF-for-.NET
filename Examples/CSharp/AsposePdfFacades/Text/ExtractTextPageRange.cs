using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Text
{
    public class ExtractTextPageRange
    {
        public static void Run()
        {
            // ExStart:ExtractTextPageRange
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Text();
            // Open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractText-PageRange.pdf");

            // Specify start and end pages
            pdfExtractor.StartPage = 1;
            pdfExtractor.EndPage = 1;

            // Use parameterless ExtractText method
            pdfExtractor.ExtractText();

            MemoryStream tempMemoryStream = new MemoryStream();
            pdfExtractor.GetText(tempMemoryStream);

            string text = "";
            // Specify Unicode encoding type in StreamReader constructor
            using (StreamReader sr = new StreamReader(tempMemoryStream,Encoding.Unicode))
            {
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                text = sr.ReadToEnd();
            }

            File.WriteAllText(dataDir+ "output_out.txt", text);
            // ExEnd:ExtractTextPageRange
        }
    }
}