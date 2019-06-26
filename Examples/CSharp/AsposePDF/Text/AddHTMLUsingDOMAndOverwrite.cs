using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddHTMLUsingDOMAndOverwrite
    {
        public static void Run()
        {
            // ExStart:AddHTMLUsingDOMAndOverwrite
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Instantiate Document object
            Document doc = new Document();
            // Add a page to pages collection of PDF file
            Page page = doc.Pages.Add();
            // Instantiate HtmlFragment with HTML contnets
            HtmlFragment title = new HtmlFragment("<p style='font-family: Verdana'><b><i>Table contains text</i></b></p>");
            //Font-family from 'Verdana' will be reset to 'Arial'
            title.TextState = new TextState("Arial");
            title.TextState.FontSize = 20;
            // Set bottom margin information
            title.Margin.Bottom = 10;
            // Set top margin information
            title.Margin.Top = 400;
            // Add HTML Fragment to paragraphs collection of page
            page.Paragraphs.Add(title);
            // Save PDF file
            dataDir = dataDir + "AddHTMLUsingDOMAndOverwrite_out.pdf";
            // Save PDF file
            doc.Save(dataDir);
        }
    }
}
