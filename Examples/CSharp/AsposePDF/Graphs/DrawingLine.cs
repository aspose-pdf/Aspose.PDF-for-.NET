using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs
{
    public class DrawingLine
    {
        public static void Run()
        {
            // ExStart:DrawingLine
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Graphs();

            // Create Document instance
            Document pDoc = new Document();
            // Add page to pages collection of PDF document
            Page pg = pDoc.Pages.Add();
            // Set page margin on all sides as 0
            pg.PageInfo.Margin.Left = pg.PageInfo.Margin.Right = pg.PageInfo.Margin.Bottom = pg.PageInfo.Margin.Top = 0;
            // Create Graph object with Width and Height equal to page dimensions
            Aspose.Pdf.Drawing.Graph graph = new Aspose.Pdf.Drawing.Graph((float)pg.PageInfo.Width , (float)pg.PageInfo.Height);
            // Create first line object starting from Lower-Left to Top-Right corner of page
            Aspose.Pdf.Drawing.Line line = new Aspose.Pdf.Drawing.Line(new float[] { (float)pg.Rect.LLX, 0, (float)pg.PageInfo.Width, (float)pg.Rect.URY });
            // Add line to shapes collection of Graph object
            graph.Shapes.Add(line);
            // Draw line from Top-Left corner of page to Bottom-Right corner of page
            Aspose.Pdf.Drawing.Line line2 = new Aspose.Pdf.Drawing.Line(new float[] { 0, (float)pg.Rect.URY, (float)pg.PageInfo.Width, (float)pg.Rect.LLX });
            // Add line to shapes collection of Graph object
            graph.Shapes.Add(line2);
            // Add Graph object to paragraphs collection of page
            pg.Paragraphs.Add(graph);

            dataDir = dataDir + "DrawingLine_out.pdf";
            // Save PDF file
            pDoc.Save(dataDir);
            // ExEnd:DrawingLine
            Console.WriteLine("\nLine drawn successfully across the page.\nFile saved at " + dataDir);            
        }
    }
}