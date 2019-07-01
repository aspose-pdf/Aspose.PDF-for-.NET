using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class MarkdownToPDF
    {
        /// <summary>
        /// This feature is supported by version 19.6 or greater
        /// </summary>
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            // Open Markdown document
            Document doc = new Document(dataDir + "sample.md", new MdLoadOptions());
            // Save document in PDF format
            doc.Save(dataDir + "MarkdownToPDF.pdf");
            // ExEnd:1
        }
    }
}

