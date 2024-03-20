using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class AddInkAnnotation
    {
        public static void Run()
        {
            // ExStart:AddLinkAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            Document doc = new Document();
            Page pdfPage = doc.Pages.Add();
            System.Drawing.Rectangle drect = new System.Drawing.Rectangle();
            drect.Height = (int)pdfPage.Rect.Height;
            drect.Width = (int)pdfPage.Rect.Width;
            drect.X = 0;
            drect.Y = 0;
            Aspose.Pdf.Rectangle arect = Aspose.Pdf.Rectangle.FromRect(drect);
            IList<Point[]> inkList = new List<Point[]>();
            Aspose.Pdf.Point[] arrpt = new Aspose.Pdf.Point[3];
            inkList.Add(arrpt);
            arrpt[0] = new Aspose.Pdf.Point(100, 800);
            arrpt[1] = new Aspose.Pdf.Point(200, 800);
            arrpt[2] = new Aspose.Pdf.Point(200, 700);
            InkAnnotation ia = new InkAnnotation(pdfPage, arect, inkList)
            {
                Title = "XXX",
                Color = Aspose.Pdf.Color.LightBlue, // (GetColorFromString(stroke.InkColor));
                CapStyle = CapStyle.Rounded
            };
            Border border = new Border(ia);
            border.Width = 25;
            ia.Opacity = 0.5;
            pdfPage.Annotations.Add(ia);

            dataDir = dataDir + "AddInkAnnotation_out.pdf";
            // Save output file
            doc.Save(dataDir);
            // ExEnd:AddLinkAnnotation
            Console.WriteLine("\nlnk annotation added successfully.\nFile saved at " + dataDir);
        }
    }
}