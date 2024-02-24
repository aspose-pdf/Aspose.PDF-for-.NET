using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddTransparentText
    {
        public static void Run()
        {
            // ExStart:AddTransparentText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Create Document instance
            Document doc = new Document();
            // Create page to pages collection of PDF file
            Aspose.Pdf.Page page = doc.Pages.Add();

            // Create Graph object
            Aspose.Pdf.Drawing.Graph canvas = new Aspose.Pdf.Drawing.Graph(100.0f, 400.0f);
            // Create rectangle instance with certain dimensions
            Aspose.Pdf.Drawing.Rectangle rect = new Aspose.Pdf.Drawing.Rectangle(100, 100, 400, 400);
            // Create color object from Alpha color channel
            rect.GraphInfo.FillColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.FromArgb(128, System.Drawing.Color.FromArgb(12957183)));
            // Add rectangle to shapes collection of Graph object
            canvas.Shapes.Add(rect);
            // Add graph object to paragraphs collection of page object
            page.Paragraphs.Add(canvas);
            // Set value to not change position for graph object
            canvas.IsChangePosition = false;

            // Create TextFragment instance with sample value
            TextFragment text = new TextFragment("transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text transparent text ");
            // Create color object from Alpha channel
            Aspose.Pdf.Color color = Aspose.Pdf.Color.FromArgb(30, 0, 255, 0);
            // Set color information for text instance
            text.TextState.ForegroundColor = color;
            // Add text to paragraphs collection of page instance
            page.Paragraphs.Add(text);

            dataDir = dataDir + "AddTransparentText_out.pdf";
            doc.Save(dataDir);
            // ExEnd:AddTransparentText
            Console.WriteLine("\nTransparent text added successfully.\nFile saved at " + dataDir);
        }
    }
}