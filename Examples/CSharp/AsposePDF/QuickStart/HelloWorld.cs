using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart
{
    public class HelloWorld
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_QuickStart();

            // Initialize document object
            Document document = new Document();
            // Add page
            Page page = document.Pages.Add();
            // Add text to new page
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World!"));
            // Save updated PDF
            document.Save(dataDir + "HelloWorld_out.pdf");
            // ExEnd:1
            Console.WriteLine("\nPDF file password changed successfully.\nFile saved at " + dataDir);
        }
    }
}
