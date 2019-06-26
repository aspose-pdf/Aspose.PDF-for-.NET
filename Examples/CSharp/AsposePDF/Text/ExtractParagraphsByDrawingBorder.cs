using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ExtractParagraphsByDrawingBorder
    {
        public static void Run()
        {
            ExtractParagraph();
        }

        // ExStart:1
        private static void ExtractParagraph()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            Document doc = new Document(dataDir + "input.pdf");
            Page page = doc.Pages[2];

            ParagraphAbsorber absorber = new ParagraphAbsorber();
            absorber.Visit(page);

            PageMarkup markup = absorber.PageMarkups[0];

            foreach (MarkupSection section in markup.Sections)
            {
                DrawRectangleOnPage(section.Rectangle, page);
                foreach (MarkupParagraph paragraph in section.Paragraphs)
                {
                    DrawPolygonOnPage(paragraph.Points, page);
                }
            }

            doc.Save(dataDir + "output_out.pdf");
        }

        private static void DrawRectangleOnPage(Rectangle rectangle, Page page)
        {
            page.Contents.Add(new Aspose.Pdf.Operators.GSave());
            page.Contents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(1, 0, 0, 1, 0, 0));
            page.Contents.Add(new Aspose.Pdf.Operators.SetRGBColorStroke(0, 1, 0));
            page.Contents.Add(new Aspose.Pdf.Operators.SetLineWidth(2));
            page.Contents.Add(
                new Aspose.Pdf.Operators.Re(rectangle.LLX,
                    rectangle.LLY,
                    rectangle.Width,
                    rectangle.Height));
            page.Contents.Add(new Aspose.Pdf.Operators.ClosePathStroke());
            page.Contents.Add(new Aspose.Pdf.Operators.GRestore());
        }

        private static void DrawPolygonOnPage(Point[] polygon, Page page)
        {
            page.Contents.Add(new Aspose.Pdf.Operators.GSave());
            page.Contents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(1, 0, 0, 1, 0, 0));
            page.Contents.Add(new Aspose.Pdf.Operators.SetRGBColorStroke(0, 0, 1));
            page.Contents.Add(new Aspose.Pdf.Operators.SetLineWidth(1));
            page.Contents.Add(new Aspose.Pdf.Operators.MoveTo(polygon[0].X, polygon[0].Y));
            for (int i = 1; i < polygon.Length; i++)
            {
                page.Contents.Add(new Aspose.Pdf.Operators.LineTo(polygon[i].X, polygon[i].Y));
            }
            page.Contents.Add(new Aspose.Pdf.Operators.LineTo(polygon[0].X, polygon[0].Y));
            page.Contents.Add(new Aspose.Pdf.Operators.ClosePathStroke());
            page.Contents.Add(new Aspose.Pdf.Operators.GRestore());
        }
        // ExEnd:1
    }
}
