using Aspose.Pdf.Text;
using System.IO;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class CreatePDFA1WithAsposePdf
    {
        public static void Run()
        {
            // ExStart:CreatePDFA1WithAsposePdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            Aspose.Pdf.Document pdf1 = new Aspose.Pdf.Document();
            // Add a page into the pdf document
            pdf1.Pages.Add().Paragraphs.Add(new TextFragment("Hello World!"));
            MemoryStream ms = new MemoryStream();
            // Save the document
            pdf1.Save(ms);
            pdf1.Convert(new MemoryStream(), PdfFormat.PDF_A_1A, ConvertErrorAction.Delete);
            pdf1.Save(dataDir + "CreatePdfA1_out.pdf");
            // ExEnd:CreatePDFA1WithAsposePdf
        }
    }
}
