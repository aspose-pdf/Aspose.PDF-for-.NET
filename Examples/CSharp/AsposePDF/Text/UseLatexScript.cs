using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class UseLatexScript
    {
        public static void Run()
        {
            // ExStart:UseLatexScript
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Create a new Document Object
            Document doc = new Document();
            // Add Page in Pages Collection
            Page page = doc.Pages.Add();
            // Create a Table
            Table table = new Table();
            // Add a row into Table
            Row row = table.Rows.Add();
            // Add Cell with Latex Script to add methematical expressions/formulae
            string latexText1 = "$123456789+\\sqrt{1}+\\int_a^b f(x)dx$";
            Cell cell = row.Cells.Add();
            cell.Margin = new MarginInfo { Left = 20, Right = 20, Top = 20, Bottom = 20 };
            // Second LatexFragment constructor bool parameter provides LaTeX paragraph indents elimination.
            LatexFragment ltext1 = new LatexFragment(latexText1, true);
            cell.Paragraphs.Add(ltext1);
            // Add table inside page
            page.Paragraphs.Add(table);
            // Save the document
            doc.Save(dataDir + "LatextScriptInPdf_out.pdf");
            // ExEnd:UseLatexScript
        }
    }
}
