using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs
{
    public class CreateFilledRectangle
    {
        public static void Run()
        {
            // ExStart:CreateFilledRectangle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Graphs();

            // Create Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF file
            Page page = doc.Pages.Add();
            // Create Graph instance
            Aspose.Pdf.Drawing.Graph graph = new Aspose.Pdf.Drawing.Graph(100.0, 400.0);
            // Add graph object to paragraphs collection of page instance
            page.Paragraphs.Add(graph);
            // Create Rectangle instance
            Aspose.Pdf.Drawing.Rectangle rect = new Aspose.Pdf.Drawing.Rectangle(100, 100, 200, 120);
            // Specify fill color for Graph object
            rect.GraphInfo.FillColor = Aspose.Pdf.Color.Red;
            // Add rectangle object to shapes collection of Graph object
            graph.Shapes.Add(rect);
            dataDir = dataDir + "CreateFilledRectangle_out.pdf";
            // Save PDF file
            doc.Save(dataDir);
            // ExEnd:CreateFilledRectangle
            Console.WriteLine("\nFilled rectangle object created successfully.\nFile saved at " + dataDir);
        }
    }
}