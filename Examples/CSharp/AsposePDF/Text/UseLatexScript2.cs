using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class UseLatexScript2
    {
        public static void Run()
        {
            // ExStart:WithPreambleanddocument
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
            string latexText2 = @"\documentclass{article}
                                \begin{document}
                                Latex and the document class will normally take care of page layout issues for you. For submission to an academic publication, this entire topic will be out
                                \end{document}";
            Cell cell = row.Cells.Add();
            cell.Margin = new MarginInfo { Left = 20, Right = 20, Top = 20, Bottom = 20 };
            HtmlFragment text2 = new HtmlFragment(latexText2);
            cell.Paragraphs.Add(text2);
            // Add table inside page
            page.Paragraphs.Add(table);
            // Save the document
            doc.Save(dataDir + "LatextScriptInPdf2_out.pdf");
            // ExEnd:WithPreambleanddocument
        }
    }
}
