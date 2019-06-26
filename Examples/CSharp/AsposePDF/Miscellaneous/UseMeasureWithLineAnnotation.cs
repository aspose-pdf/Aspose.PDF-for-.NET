using System.IO;
using System;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Miscellaneous
{
    public class UseMeasureWithLineAnnotation
    {
        public static void Run()
        {
            // ExStart:UseMeasureWithLineAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Miscellaneous();

            Document doc = new Document( dataDir + "input.pdf");
            Rectangle rect = new Rectangle(260, 630, 451, 662);
            LineAnnotation line = new LineAnnotation(doc.Pages[1], rect, new Point(266, 657), new Point(446, 656));
            line.Color = Color.Red;

            // Set extension line parameters.
            line.LeaderLine = -15;
            line.LeaderLineExtension = 5;

            // Set line endings
            line.StartingStyle = LineEnding.OpenArrow;
            line.EndingStyle = LineEnding.OpenArrow;

            // Create Measure element
            line.Measure = new Measure(line);
            line.Measure.DistanceFormat = new Measure.NumberFormatList(line.Measure);
            line.Measure.DistanceFormat.Add(new Measure.NumberFormat(line.Measure));
            line.Measure.DistanceFormat[1].UnitLabel = "mm";
            line.Measure.DistanceFormat[1].FractionSeparator = ".";
            line.Measure.DistanceFormat[1].ConvresionFactor = 1;

            // Text of measure line
            line.Contents = "155 mm";
            // This must be set to show the text.
            line.ShowCaption = true;
            line.CaptionPosition = CaptionPosition.Top;
            doc.Pages[1].Annotations.Add(line);
            doc.Save(dataDir + "UseMeasureWithLineAnnotation_out.pdf");
            // ExEnd:UseMeasureWithLineAnnotation
        }
    }
}