using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs
{
    public class AddDrawing
    {
        public static void Run()
        {
            // ExStart:AddDrawing
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Graphs();

            int alpha = 10;
            int green = 0;
            int red = 100;
            int blue = 0;
            // Create Color object using Alpha RGB
            Aspose.Pdf.Color alphaColor = Aspose.Pdf.Color.FromArgb(alpha, red, green, blue); // Provide alpha channel
            // Instantiate Document object
            Document document = new Document();
            // Add page to pages collection of PDF file
            Page page = document.Pages.Add();
            // Create Graph object with certain dimensions
            Aspose.Pdf.Drawing.Graph graph = new Aspose.Pdf.Drawing.Graph(300.0, 400.0);
            // Set border for Drawing object
            graph.Border = (new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, Aspose.Pdf.Color.Black));
            // Add graph object to paragraphs collection of Page instance
            page.Paragraphs.Add(graph);
            // Create Rectangle object with certain dimensions
            Aspose.Pdf.Drawing.Rectangle rectangle = new Aspose.Pdf.Drawing.Rectangle(0, 0, 100, 50);
            // Create graphInfo object for Rectangle instance
            Aspose.Pdf.GraphInfo graphInfo = rectangle.GraphInfo;
            // Set color information for GraphInfo instance
            graphInfo.Color = (Aspose.Pdf.Color.Red);
            // Set fill color for GraphInfo
            graphInfo.FillColor = (alphaColor);
            // Add rectangle shape to shapes collection of graph object
            graph.Shapes.Add(rectangle);
            dataDir = dataDir + "AddDrawing_out.pdf";
            // Save PDF file
            document.Save(dataDir);
            // ExEnd:AddDrawing
            Console.WriteLine("\nDrawing added successfully with transparent color.\nFile saved at " + dataDir);
        }
    }
}