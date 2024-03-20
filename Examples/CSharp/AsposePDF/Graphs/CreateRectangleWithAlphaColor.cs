using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs
{
    public class CreateRectangleWithAlphaColor
    {
        public static void Run()
        {
            // ExStart:CreateRectangleWithAlphaColor
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Graphs();

            // Instantiate Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF file
            Aspose.Pdf.Page page = doc.Pages.Add();
            // Create Graph instance
            Aspose.Pdf.Drawing.Graph canvas = new Aspose.Pdf.Drawing.Graph(100.0, 400.0);
            // Create rectangle object with specific dimensions
            Aspose.Pdf.Drawing.Rectangle rect = new Aspose.Pdf.Drawing.Rectangle(100, 100, 200, 100);
            // Set graph fill color from System.Drawing.Color structure from a 32-bit ARGB value
            rect.GraphInfo.FillColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.FromArgb(128, System.Drawing.Color.FromArgb(12957183)));
            // Add rectangle object to shapes collection of Graph instance
            canvas.Shapes.Add(rect);

            // Create second rectangle object
            Aspose.Pdf.Drawing.Rectangle rect1 = new Aspose.Pdf.Drawing.Rectangle(200, 150, 200, 100);
            rect1.GraphInfo.FillColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.FromArgb(128, System.Drawing.Color.FromArgb(16118015)));
            canvas.Shapes.Add(rect1);
            // Add graph instance to paragraph collection of page object
            page.Paragraphs.Add(canvas);

            dataDir = dataDir + "CreateRectangleWithAlphaColor_out.pdf";
            // Save PDF file
            doc.Save(dataDir);
            // ExEnd:CreateRectangleWithAlphaColor
            Console.WriteLine("\nRectangle object created successfully with alpha color.\nFile saved at " + dataDir);            
        }
    }
}