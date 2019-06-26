using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Headings
{
    public class ApplyNumberStyle
    {
        public static void Run()
        {
            // ExStart:ApplyNumberStyle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Headings();

            Document pdfDoc = new Document();
            pdfDoc.PageInfo.Width = 612.0;
            pdfDoc.PageInfo.Height = 792.0;
            pdfDoc.PageInfo.Margin = new Aspose.Pdf.MarginInfo();
            pdfDoc.PageInfo.Margin.Left = 72;
            pdfDoc.PageInfo.Margin.Right = 72;
            pdfDoc.PageInfo.Margin.Top = 72;
            pdfDoc.PageInfo.Margin.Bottom = 72;

            Aspose.Pdf.Page pdfPage = pdfDoc.Pages.Add();
            pdfPage.PageInfo.Width = 612.0;
            pdfPage.PageInfo.Height = 792.0;
            pdfPage.PageInfo.Margin = new Aspose.Pdf.MarginInfo();
            pdfPage.PageInfo.Margin.Left = 72;
            pdfPage.PageInfo.Margin.Right = 72;
            pdfPage.PageInfo.Margin.Top = 72;
            pdfPage.PageInfo.Margin.Bottom = 72;

            Aspose.Pdf.FloatingBox floatBox = new Aspose.Pdf.FloatingBox();
            floatBox.Margin = pdfPage.PageInfo.Margin;

            pdfPage.Paragraphs.Add(floatBox);

            TextFragment textFragment = new TextFragment();
            TextSegment segment = new TextSegment();

            Aspose.Pdf.Heading heading = new Aspose.Pdf.Heading(1);
            heading.IsInList = true;
            heading.StartNumber = 1;
            heading.Text = "List 1";
            heading.Style = NumberingStyle.NumeralsRomanLowercase;
            heading.IsAutoSequence = true;

            floatBox.Paragraphs.Add(heading);

            Aspose.Pdf.Heading heading2 = new Aspose.Pdf.Heading(1);
            heading2.IsInList = true;
            heading2.StartNumber = 13;
            heading2.Text = "List 2";
            heading2.Style = NumberingStyle.NumeralsRomanLowercase;
            heading2.IsAutoSequence = true;

            floatBox.Paragraphs.Add(heading2);

            Aspose.Pdf.Heading heading3 = new Aspose.Pdf.Heading(2);
            heading3.IsInList = true;
            heading3.StartNumber = 1;
            heading3.Text = "the value, as of the effective date of the plan, of property to be distributed under the plan onaccount of each allowed";
            heading3.Style = NumberingStyle.LettersLowercase;
            heading3.IsAutoSequence = true;

            floatBox.Paragraphs.Add(heading3);
            dataDir = dataDir + "ApplyNumberStyle_out.pdf";
            pdfDoc.Save(dataDir);
            // ExEnd:ApplyNumberStyle
            Console.WriteLine("\nNumber style applied successfully in headings.\nFile saved at " + dataDir);            
        }
    }
}