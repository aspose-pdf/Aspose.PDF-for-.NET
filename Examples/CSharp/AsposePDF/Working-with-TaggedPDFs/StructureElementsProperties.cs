using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class StructureElementsProperties
    {
        public static void Run()
        {
            // ExStart:StructureElementsProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Create Structure Elements
            StructureElement rootElement = taggedContent.RootElement;

            SectElement sect = taggedContent.CreateSectElement();
            rootElement.AppendChild(sect);

            HeaderElement h1 = taggedContent.CreateHeaderElement(1);
            sect.AppendChild(h1);
            h1.SetText("The Header");

            h1.Title = "Title";
            h1.Language = "en-US";
            h1.AlternativeText = "Alternative Text";
            h1.ExpansionText = "Expansion Text";
            h1.ActualText = "Actual Text";

            // Save Tagged Pdf Document
            document.Save(dataDir + "StructureElementsProperties.pdf");

            // ExEnd:StructureElementsProperties
        }
    }
}
