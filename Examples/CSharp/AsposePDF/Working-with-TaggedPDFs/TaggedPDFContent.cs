using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class TaggedPDFContent
    {
        public static void Run()
        {
            // ExStart:TaggedPDFContent
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            //
            // Work with Tagged Pdf content
            //

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Simple Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Save Tagged Pdf Document
            document.Save(dataDir + "TaggedPDFContent.pdf");
            // ExEnd:TaggedPDFContent
        }
    }
}
