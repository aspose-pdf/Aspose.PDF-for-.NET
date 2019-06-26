using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class TextStructureElements
    {
        public static void Run()
        {
            // ExStart:TextStructureElements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Get Root Structure Elements
            StructureElement rootElement = taggedContent.RootElement;

            ParagraphElement p = taggedContent.CreateParagraphElement();
            // Set Text to Text Structure Element
            p.SetText("Paragraph.");
            rootElement.AppendChild(p);


            // Save Tagged Pdf Document
            document.Save(dataDir + "TextStructureElement.pdf");
            // ExEnd:TextStructureElements
        }
    }
}
