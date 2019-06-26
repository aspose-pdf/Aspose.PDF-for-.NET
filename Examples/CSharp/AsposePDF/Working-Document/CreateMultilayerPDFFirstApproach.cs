
namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class CreateMultilayerPDFFirstApproach
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            Aspose.Pdf.Document pdf = new Aspose.Pdf.Document();

            Aspose.Pdf.Page sec1 = pdf.Pages.Add();
            Aspose.Pdf.Text.TextFragment t1 = new Aspose.Pdf.Text.TextFragment("paragraph 3 segment");
            sec1.Paragraphs.Add(t1);

            Aspose.Pdf.Text.TextSegment seg1 = new Aspose.Pdf.Text.TextSegment();
            t1.Text = "paragraph 3 segment 1";
            t1.TextState.ForegroundColor = Color.Red;
            t1.TextState.FontSize = 12;

            Aspose.Pdf.Image image1 = new Aspose.Pdf.Image();
            image1.File = dataDir + "test_image.png";

            Aspose.Pdf.FloatingBox box1 = new Aspose.Pdf.FloatingBox(117, 21);
            sec1.Paragraphs.Add(box1);

            box1.Left = -4;
            box1.Top = -4;
            box1.Paragraphs.Add(image1);

            pdf.Save(dataDir + "CreateMultiLayerPdf_out.pdf");
            // ExEnd:1
        }
    }
}
