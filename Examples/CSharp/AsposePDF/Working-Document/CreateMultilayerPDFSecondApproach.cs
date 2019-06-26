
namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class CreateMultilayerPDFSecondApproach
    {
        public static void Run()
        {
            // ExStart:2
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            int alpha = 10;
            int green = 0;
            int red = 100;
            int blue = 0;
            Color alphaColor = Color.FromArgb(alpha, red, green, blue);
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document();

            Aspose.Pdf.Page page = doc.Pages.Add();
            Aspose.Pdf.Text.TextFragment t1 = new Aspose.Pdf.Text.TextFragment("paragraph 3 segment");
            t1.TextState.ForegroundColor = Color.Red;
            t1.IsInLineParagraph = true;
            t1.TextState.FontSize = 12;
            Aspose.Pdf.FloatingBox TextFloatingBox1 = new Aspose.Pdf.FloatingBox(117, 21);
            TextFloatingBox1.ZIndex = 1;
            TextFloatingBox1.Left = -4;
            TextFloatingBox1.Top = -4;
            page.Paragraphs.Add(TextFloatingBox1);
            TextFloatingBox1.Paragraphs.Add(t1);
            Aspose.Pdf.Image image1 = new Aspose.Pdf.Image();
            image1.File = dataDir + "test_image.png";
            Aspose.Pdf.FloatingBox ImageFloatingBox = new Aspose.Pdf.FloatingBox(117, 21);
            page.Paragraphs.Add(ImageFloatingBox);

            ImageFloatingBox.Left = -4;
            ImageFloatingBox.Top = -4;
            ImageFloatingBox.ZIndex = 2;
            ImageFloatingBox.Paragraphs.Add(image1);

            doc.Save(dataDir + @"Multilayer-2ndApproach_out.pdf");
            // ExEnd:2
        }
    }
}