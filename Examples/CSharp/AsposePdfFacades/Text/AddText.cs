using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Text
{
    public class AddText
    {
        public static void Run()
        {
            // ExStart:AddText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Text();

            // Open document
            PdfFileMend mender = new PdfFileMend();

            // Create PdfFileMend object to add text
            mender.BindPdf(dataDir + "AddText.pdf");

            // Create formatted text
            FormattedText text = new FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.AliceBlue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, true, 14);

            // Set whether to use Word Wrap or not and using which mode
            mender.IsWordWrap = true;
            mender.WrapMode = WordWrapMode.Default;

            // Add text in the PDF file
            mender.AddText(text, 1, 100, 200, 200, 400);

            // Save changes
            mender.Save(dataDir + "AddText_out.pdf");

            // Close PdfFileMend object
            mender.Close();
            // ExEnd:AddText
        }
    }
}