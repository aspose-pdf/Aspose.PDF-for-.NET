using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class LnkAnnotationLineWidth
    {
        public static void Run()
        {
            // ExStart:lnkAnnotationLineWidth
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            Document doc = new Document();
            doc.Pages.Add();
            IList<Point[]> inkList = new List<Point[]>();
            LineInfo lineInfo = new LineInfo();
            lineInfo.VerticeCoordinate = new float[] { 55, 55, 70, 70, 70, 90, 150, 60 };
            lineInfo.Visibility = true;
            lineInfo.LineColor = System.Drawing.Color.Red;
            lineInfo.LineWidth = 2;
            int length = lineInfo.VerticeCoordinate.Length / 2;
            Aspose.Pdf.Point[] gesture = new Aspose.Pdf.Point[length];
            for (int i = 0; i < length; i++)
            {
               gesture[i] = new Aspose.Pdf.Point(lineInfo.VerticeCoordinate[2 * i], lineInfo.VerticeCoordinate[2 * i + 1]);
            }

            inkList.Add(gesture);
            InkAnnotation a1 = new InkAnnotation(doc.Pages[1], new Aspose.Pdf.Rectangle(100, 100, 300, 300), inkList);
            a1.Subject = "Test";
            a1.Title = "Title";
            a1.Color = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);
            Border border = new Border(a1);
            border.Width = 3;
            border.Effect = BorderEffect.Cloudy;
            border.Dash = new Dash(1, 1);
            border.Style = BorderStyle.Solid;
            doc.Pages[1].Annotations.Add(a1);

            dataDir = dataDir + "lnkAnnotationLineWidth_out.pdf";
            // Save output file
            doc.Save(dataDir);
            // ExEnd:lnkAnnotationLineWidth
            Console.WriteLine("\nlnk annotation line width setup successfully.\nFile saved at " + dataDir);
        }
    }
}