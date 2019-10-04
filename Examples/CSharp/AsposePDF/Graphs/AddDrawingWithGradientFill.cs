using Aspose.Pdf.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs
{
    class AddDrawingWithGradientFill
    {
        public static void Run()
        {
            // ExStart:AddDrawingWithGradientFill
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Graphs();

            Document doc = new Document();
            Page page = doc.Pages.Add();
            Aspose.Pdf.Drawing.Graph graph = new Aspose.Pdf.Drawing.Graph(300, 300);
            page.Paragraphs.Add(graph);
            Aspose.Pdf.Drawing.Rectangle rect = new Aspose.Pdf.Drawing.Rectangle(0, 0, 300, 300);
            graph.Shapes.Add(rect);
            rect.GraphInfo.FillColor = new Aspose.Pdf.Color
            {
                PatternColorSpace = new GradientAxialShading(Color.Red, Color.Blue)
                {
                    Start = new Point(0, 0),
                    End = new Point(300, 300)
                }
            };
            doc.Save(dataDir + "AddDrawingWithGradientFill_out.pdf");
            //ExEnd: AddDrawingWithGradientFill
        }
    }
}
