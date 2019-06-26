using System.IO;
using System;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Miscellaneous
{
    public class UseMeasureWithPolylineAnnotation
    {
        public static void Run()
        {
            // ExStart:UseMeasureWithPolylineAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Miscellaneous();

            Document doc = new Document( dataDir + "input.pdf");
            Point[] vertices = new Point[]
            {
	            new Point(100, 600),
	            new Point(500, 600),
	            new Point(500, 500),
	            new Point(400, 300),
	            new Point(100, 500),
	            new Point(100, 600)
            };
            Rectangle rect = new Rectangle(100, 500, 500, 600);

            // Area or perimeter line
            PolylineAnnotation area = new PolylineAnnotation(doc.Pages[1], rect, vertices);
            area.Color = Color.Red;

            // Line endings can be set for perimeter line.
            area.StartingStyle = LineEnding.OpenArrow;
            area.EndingStyle = LineEnding.OpenArrow;
            area.Measure = new Measure(area);
            area.Measure.DistanceFormat = new Measure.NumberFormatList(area.Measure);
            area.Measure.DistanceFormat.Add(new Measure.NumberFormat(area.Measure));
            area.Measure.DistanceFormat[1].UnitLabel = "mm";
            doc.Pages[1].Annotations.Add(area);
            doc.Save( dataDir + "UseMeasureWithPolylineAnnotation_out.pdf");
            // ExEnd:UseMeasureWithPolylineAnnotation
        }
    }
}