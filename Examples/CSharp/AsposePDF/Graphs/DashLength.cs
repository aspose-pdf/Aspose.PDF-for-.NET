using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs
{
    public class DashLength
    {
        public static void Run()
        {
            // ExStart:DashLength
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Graphs();

            // Instantiate Document instance
            Document doc = new Document();
            // Add page to pages collection of Document object
            Page page = doc.Pages.Add();
            // Create Drawing object with certain dimensions
            Aspose.Pdf.Drawing.Graph canvas = new Aspose.Pdf.Drawing.Graph(100.0f, 400.0f);
            // Add drawing object to paragraphs collection of page instance
            page.Paragraphs.Add(canvas);
            // Create Line object
            Aspose.Pdf.Drawing.Line line = new Aspose.Pdf.Drawing.Line(new float[] { 100, 100, 200, 100 });
            // Set color for Line object
            line.GraphInfo.Color = Aspose.Pdf.Color.Red;
            // Specify dash array for line object
            line.GraphInfo.DashArray = new int[] { 0, 1, 0 };
            // Set the dash phase for Line instance
            line.GraphInfo.DashPhase = 1;
            // Add line to shapes collection of drawing object
            canvas.Shapes.Add(line);
            dataDir = dataDir + "DashLength_out.pdf";
            // Save PDF document
            doc.Save(dataDir);
            // ExEnd:DashLength
            Console.WriteLine("\nLength dashed successfully in black and white.\nFile saved at " + dataDir);
        }
    }
}