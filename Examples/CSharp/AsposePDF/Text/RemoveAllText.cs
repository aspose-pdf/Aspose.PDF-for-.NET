using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class RemoveAllText
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "RemoveAllText.pdf");
            // Loop through all pages of PDF Document
            for (int i = 1; i <= pdfDocument.Pages.Count; i++)
            {
                Page page = pdfDocument.Pages[i];
                OperatorSelector operatorSelector = new OperatorSelector(new Aspose.Pdf.Operators.TextShowOperator());
                // Select all text on the page
                page.Contents.Accept(operatorSelector);
                // Delete all text
                page.Contents.Delete(operatorSelector.Selected);
            }
            // Save the document
            pdfDocument.Save(dataDir + "RemoveAllText_out.pdf", Aspose.Pdf.SaveFormat.Pdf);
            // ExEnd:1
        }
    }
}
