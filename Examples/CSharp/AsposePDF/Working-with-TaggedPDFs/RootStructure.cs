using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class RootStructure
    {
        public static void Run()
        {
            // ExStart:RootStructure
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Properties StructTreeRootElement and RootElement are used for access to 
            // StructTreeRoot object of pdf document and to root structure element (Document structure element).
            StructTreeRootElement structTreeRootElement = taggedContent.StructTreeRootElement;
            StructureElement rootElement = taggedContent.RootElement;
            // ExEnd:RootStructure
        }
    }
}
