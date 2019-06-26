using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class TextBlockStructureElements
    {
        public static void Run()
        {
            // ExStart:TextBlockStructureElements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Get Root Structure Element
            StructureElement rootElement = taggedContent.RootElement;

            HeaderElement h1 = taggedContent.CreateHeaderElement(1);
            HeaderElement h2 = taggedContent.CreateHeaderElement(2);
            HeaderElement h3 = taggedContent.CreateHeaderElement(3);
            HeaderElement h4 = taggedContent.CreateHeaderElement(4);
            HeaderElement h5 = taggedContent.CreateHeaderElement(5);
            HeaderElement h6 = taggedContent.CreateHeaderElement(6);
            h1.SetText("H1. Header of Level 1");
            h2.SetText("H2. Header of Level 2");
            h3.SetText("H3. Header of Level 3");
            h4.SetText("H4. Header of Level 4");
            h5.SetText("H5. Header of Level 5");
            h6.SetText("H6. Header of Level 6");
            rootElement.AppendChild(h1);
            rootElement.AppendChild(h2);
            rootElement.AppendChild(h3);
            rootElement.AppendChild(h4);
            rootElement.AppendChild(h5);
            rootElement.AppendChild(h6);

            ParagraphElement p = taggedContent.CreateParagraphElement();
            p.SetText("P. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean nec lectus ac sem faucibus imperdiet. Sed ut erat ac magna ullamcorper hendrerit. Cras pellentesque libero semper, gravida magna sed, luctus leo. Fusce lectus odio, laoreet nec ullamcorper ut, molestie eu elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Aliquam lacinia sit amet elit ac consectetur. Donec cursus condimentum ligula, vitae volutpat sem tristique eget. Nulla in consectetur massa. Vestibulum vitae lobortis ante. Nulla ullamcorper pellentesque justo rhoncus accumsan. Mauris ornare eu odio non lacinia. Aliquam massa leo, rhoncus ac iaculis eget, tempus et magna. Sed non consectetur elit. Sed vulputate, quam sed lacinia luctus, ipsum nibh fringilla purus, vitae posuere risus odio id massa. Cras sed venenatis lacus.");
            rootElement.AppendChild(p);

            // Save Tagged Pdf Document
            document.Save(dataDir + "TextBlockStructureElements.pdf");

            // ExEnd:TextBlockStructureElements
        }
    }
}
