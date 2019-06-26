using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs
{
    public class ControlRectangleZOrder
    {
        public static void Run()
        {
            // ExStart:ControlRectangleZOrder
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Graphs();

            // Instantiate Document class object
            Document doc1 = new Document();
            /// Add page to pages collection of PDF file
            Aspose.Pdf.Page page1 = doc1.Pages.Add();
            // Set size of PDF page
            page1.SetPageSize(375, 300);
            // Set left margin for page object as 0
            page1.PageInfo.Margin.Left = 0;
            // Set top margin of page object as 0
            page1.PageInfo.Margin.Top = 0;
            // Create a new rectangle with Color as Red, Z-Order as 0 and certain dimensions
            AddRectangle(page1, 50, 40, 60, 40, Aspose.Pdf.Color.Red, 2);
            // Create a new rectangle with Color as Blue, Z-Order as 0 and certain dimensions
            AddRectangle(page1, 20, 20, 30, 30, Aspose.Pdf.Color.Blue, 1);
            // Create a new rectangle with Color as Green, Z-Order as 0 and certain dimensions
            AddRectangle(page1, 40, 40, 60, 30, Aspose.Pdf.Color.Green, 0);
            dataDir = dataDir + "ControlRectangleZOrder_out.pdf";
            // Save resultant PDF file
            doc1.Save(dataDir);
            // ExEnd:ControlRectangleZOrder
                  
        }
        // ExStart:AddRectangle
        private static void AddRectangle(Aspose.Pdf.Page page, float x, float y, float width, float height, Aspose.Pdf.Color color, int zindex)
        {
            // Create graph object with dimensions same as specified for Rectangle object
            Aspose.Pdf.Drawing.Graph graph = new Aspose.Pdf.Drawing.Graph(width, height);
            // Can we change the position of graph instance
            graph.IsChangePosition = false;
            // Set Left coordinate position for Graph instance
            graph.Left = x;
            // Set Top coordinate position for Graph object
            graph.Top = y;
            // Add a rectangle inside the "graph"
            Aspose.Pdf.Drawing.Rectangle rect = new Aspose.Pdf.Drawing.Rectangle(0, 0, width, height);
            // Set rectangle fill color
            rect.GraphInfo.FillColor = color;
            // Color of graph object
            rect.GraphInfo.Color = color;
            // Add rectangle to shapes collection of graph instance
            graph.Shapes.Add(rect);
            // Set Z-Index for rectangle object
            graph.ZIndex = zindex;
            // Add graph to paragraphs collection of page object
            page.Paragraphs.Add(graph);
        }
        // ExEnd:AddRectangle
    }
}