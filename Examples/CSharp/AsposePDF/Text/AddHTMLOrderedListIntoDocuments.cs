using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddHTMLOrderedListIntoDocuments
    {
        public static void Run()
        {
            // ExStart:AddHTMLOrderedListIntoDocuments
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // The path to the output document.  
            string outFile = dataDir + "AddHTMLOrderedListIntoDocuments_out.pdf";
            // Instantiate Document object  
            Document doc = new Document();
            // Instantiate HtmlFragment object with corresponding HTML fragment  
            HtmlFragment t = new HtmlFragment("`<body style='line-height: 100px;'><ul><li>First</li><li>Second</li><li>Third</li><li>Fourth</li><li>Fifth</li></ul>Text after the list.<br/>Next line<br/>Last line</body>`");
            // Add Page in Pages Collection  
            Page page = doc.Pages.Add();
            // Add HtmlFragment inside page  
            page.Paragraphs.Add(t);
            // Save resultant PDF file  
            doc.Save(outFile);
            // ExEnd:AddHTMLOrderedListIntoDocuments


        }
    }
}
