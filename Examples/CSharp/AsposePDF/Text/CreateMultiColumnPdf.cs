using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class CreateMultiColumnPdf
    {
        public static void Run()
        {
            // ExStart:CreateMultiColumnPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            Document doc = new Document();
            // Specify the left margin info for the PDF file
            doc.PageInfo.Margin.Left = 40;
            // Specify the Right margin info for the PDF file
            doc.PageInfo.Margin.Right = 40;
            Page page = doc.Pages.Add();

            Aspose.Pdf.Drawing.Graph graph1 = new Aspose.Pdf.Drawing.Graph(500, 2);
            // Add the line to paraphraphs collection of section object
            page.Paragraphs.Add(graph1);

            // Specify the coordinates for the line
            float[] posArr = new float[] { 1, 2, 500, 2 };
            Aspose.Pdf.Drawing.Line l1 = new Aspose.Pdf.Drawing.Line(posArr);
            graph1.Shapes.Add(l1);
            // Create string variables with text containing html tags

            string s = "<font face=\"Times New Roman\" size=4>" +

            "<strong> How to Steer Clear of money scams</<strong> "
            + "</font>";
            // Create text paragraphs containing HTML text

            HtmlFragment heading_text = new HtmlFragment(s);
            page.Paragraphs.Add(heading_text);

            Aspose.Pdf.FloatingBox box = new Aspose.Pdf.FloatingBox();
            // Add four columns in the section
            box.ColumnInfo.ColumnCount = 2;
            // Set the spacing between the columns
            box.ColumnInfo.ColumnSpacing = "5";

            box.ColumnInfo.ColumnWidths = "105 105";
            TextFragment text1 = new TextFragment("By A Googler (The Official Google Blog)");
            text1.TextState.FontSize = 8;
            text1.TextState.LineSpacing = 2;
            box.Paragraphs.Add(text1);
            text1.TextState.FontSize = 10;

            text1.TextState.FontStyle = FontStyles.Italic;
            // Create a graphs object to draw a line
            Aspose.Pdf.Drawing.Graph graph2 = new Aspose.Pdf.Drawing.Graph(50, 10);
            // Specify the coordinates for the line
            float[] posArr2 = new float[] { 1, 10, 100, 10 };
            Aspose.Pdf.Drawing.Line l2 = new Aspose.Pdf.Drawing.Line(posArr2);
            graph2.Shapes.Add(l2);

            // Add the line to paragraphs collection of section object
            box.Paragraphs.Add(graph2);

            TextFragment text2 = new TextFragment(@"Sed augue tortor, sodales id, luctus et, pulvinar ut, eros. Suspendisse vel dolor. Sed quam. Curabitur ut massa vitae eros euismod aliquam. Pellentesque sit amet elit. Vestibulum interdum pellentesque augue. Cras mollis arcu sit amet purus. Donec augue. Nam mollis tortor a elit. Nulla viverra nisl vel mauris. Vivamus sapien. nascetur ridiculus mus. Nam justo lorem, aliquam luctus, sodales et, semper sed, enim Nam justo lorem, aliquam luctus, sodales et,nAenean posuere ante ut neque. Morbi sollicitudin congue felis. Praesent turpis diam, iaculis sed, pharetra non, mollis ac, mauris. Phasellus nisi ipsum, pretium vitae, tempor sed, molestie eu, dui. Duis lacus purus, tristique ut, iaculis cursus, tincidunt vitae, risus. Sed commodo. *** sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam justo lorem, aliquam luctus, sodales et, semper sed, enim Nam justo lorem, aliquam luctus, sodales et, semper sed, enim Nam justo lorem, aliquam luctus, sodales et, semper sed, enim nAenean posuere ante ut neque. Morbi sollicitudin congue felis. Praesent turpis diam, iaculis sed, pharetra non, mollis ac, mauris. Phasellus nisi ipsum, pretium vitae, tempor sed, molestie eu, dui. Duis lacus purus, tristique ut, iaculis cursus, tincidunt vitae, risus. Sed commodo. *** sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed urna. . Duis convallis ultrices nisi. Maecenas non ligula. Nunc nibh est, tincidunt in, placerat sit amet, vestibulum a, nulla. Praesent porttitor turpis eleifend ante. Morbi sodales.nAenean posuere ante ut neque. Morbi sollicitudin congue felis. Praesent turpis diam, iaculis sed, pharetra non, mollis ac, mauris. Phasellus nisi ipsum, pretium vitae, tempor sed, molestie eu, dui. Duis lacus purus, tristique ut, iaculis cursus, tincidunt vitae, risus. Sed commodo. *** sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed urna. . Duis convallis ultrices nisi. Maecenas non ligula. Nunc nibh est, tincidunt in, placerat sit amet, vestibulum a, nulla. Praesent porttitor turpis eleifend ante. Morbi sodales.");
            box.Paragraphs.Add(text2);

            page.Paragraphs.Add(box);

            dataDir = dataDir + "CreateMultiColumnPdf_out.pdf";
            // Save PDF file
            doc.Save(dataDir);
            // ExEnd:CreateMultiColumnPdf            
            Console.WriteLine("\nMulti column pdf file created successfully.\nFile saved at " + dataDir);
        }
    }
}