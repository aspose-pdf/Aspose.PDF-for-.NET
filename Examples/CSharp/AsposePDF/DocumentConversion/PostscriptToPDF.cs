using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PostscriptToPDF
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            // Create a new instance of PsLoadOptions
            LoadOptions options = new PsLoadOptions();
            // Open .ps document with created load options
            Document pdfDocument = new Document(dataDir + "input.ps", options);
            // Save document
            pdfDocument.Save(dataDir + "PSToPDF.pdf");
            // ExEnd:1
        }
    }
}
