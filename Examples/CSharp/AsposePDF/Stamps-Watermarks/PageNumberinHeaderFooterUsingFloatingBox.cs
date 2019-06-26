using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class PageNumberinHeaderFooterUsingFloatingBox
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Instantiate Document instance
            Aspose.Pdf.Document pdf = new Aspose.Pdf.Document();
            // Add a Page into the pdf document
            Aspose.Pdf.Page page = pdf.Pages.Add();

            // Initializes a new instance of the FloatingBox class
            Aspose.Pdf.FloatingBox box1 = new Aspose.Pdf.FloatingBox(140, 80);
            // Float value that indicates left position of the paragraph
            box1.Left = 2;
            // Float value that indicates top position of the paragraph
            box1.Top = 10;
            // Add the macros to the paragraphs collection of the FloatingBox
            box1.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Page: ($p/ $P )"));
            // Add a floatingBox to the page
            page.Paragraphs.Add(box1);

            // Save the document
            pdf.Save(dataDir + "PageNumberinHeaderFooterUsingFloatingBox_out.pdf");
            // ExEnd:1
        }
    }
}
