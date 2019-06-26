
namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class SetDefaultFont
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            // Load an existing PDF document with missing font
            string documentName = dataDir + "input.pdf";
            string newName = "Arial";
            using (System.IO.FileStream fs = new System.IO.FileStream(documentName, System.IO.FileMode.Open))
            using (Document document = new Document(fs))
            {
                PdfSaveOptions pdfSaveOptions = new PdfSaveOptions();
                // Specify Default Font Name
                pdfSaveOptions.DefaultFontName = newName;
                document.Save(dataDir + "output_out.pdf", pdfSaveOptions);
            }
            // ExEnd:1
        }
    }
}
