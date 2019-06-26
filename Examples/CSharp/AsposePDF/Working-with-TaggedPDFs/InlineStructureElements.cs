using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class InlineStructureElements
    {
        public static void Run()
        {
            // ExStart:InlineStructureElements
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
            rootElement.AppendChild(h1);
            rootElement.AppendChild(h2);
            rootElement.AppendChild(h3);
            rootElement.AppendChild(h4);
            rootElement.AppendChild(h5);
            rootElement.AppendChild(h6);

            SpanElement spanH11 = taggedContent.CreateSpanElement();
            spanH11.SetText("H1. ");
            h1.AppendChild(spanH11);
            SpanElement spanH12 = taggedContent.CreateSpanElement();
            spanH12.SetText("Level 1 Header");
            h1.AppendChild(spanH12);

            SpanElement spanH21 = taggedContent.CreateSpanElement();
            spanH21.SetText("H2. ");
            h2.AppendChild(spanH21);
            SpanElement spanH22 = taggedContent.CreateSpanElement();
            spanH22.SetText("Level 2 Header");
            h2.AppendChild(spanH22);

            SpanElement spanH31 = taggedContent.CreateSpanElement();
            spanH31.SetText("H3. ");
            h3.AppendChild(spanH31);
            SpanElement spanH32 = taggedContent.CreateSpanElement();
            spanH32.SetText("Level 3 Header");
            h3.AppendChild(spanH32);

            SpanElement spanH41 = taggedContent.CreateSpanElement();
            spanH41.SetText("H4. ");
            h4.AppendChild(spanH41);
            SpanElement spanH42 = taggedContent.CreateSpanElement();
            spanH42.SetText("Level 4 Header");
            h4.AppendChild(spanH42);

            SpanElement spanH51 = taggedContent.CreateSpanElement();
            spanH51.SetText("H5. ");
            h5.AppendChild(spanH51);
            SpanElement spanH52 = taggedContent.CreateSpanElement();
            spanH52.SetText("Level 5 Header");
            h5.AppendChild(spanH52);

            SpanElement spanH61 = taggedContent.CreateSpanElement();
            spanH61.SetText("H6. ");
            h6.AppendChild(spanH61);
            SpanElement spanH62 = taggedContent.CreateSpanElement();
            spanH62.SetText("Level 6 Header");
            h6.AppendChild(spanH62);

            ParagraphElement p = taggedContent.CreateParagraphElement();
            p.SetText("P. ");
            rootElement.AppendChild(p);
            SpanElement span1 = taggedContent.CreateSpanElement();
            span1.SetText("Lorem ipsum dolor sit amet, consectetur adipiscing elit. ");
            p.AppendChild(span1);
            SpanElement span2 = taggedContent.CreateSpanElement();
            span2.SetText("Aenean nec lectus ac sem faucibus imperdiet. ");
            p.AppendChild(span2);
            SpanElement span3 = taggedContent.CreateSpanElement();
            span3.SetText("Sed ut erat ac magna ullamcorper hendrerit. ");
            p.AppendChild(span3);
            SpanElement span4 = taggedContent.CreateSpanElement();
            span4.SetText("Cras pellentesque libero semper, gravida magna sed, luctus leo. ");
            p.AppendChild(span4);
            SpanElement span5 = taggedContent.CreateSpanElement();
            span5.SetText("Fusce lectus odio, laoreet nec ullamcorper ut, molestie eu elit. ");
            p.AppendChild(span5);
            SpanElement span6 = taggedContent.CreateSpanElement();
            span6.SetText("Interdum et malesuada fames ac ante ipsum primis in faucibus. ");
            p.AppendChild(span6);
            SpanElement span7 = taggedContent.CreateSpanElement();
            span7.SetText("Aliquam lacinia sit amet elit ac consectetur. Donec cursus condimentum ligula, vitae volutpat sem tristique eget. ");
            p.AppendChild(span7);
            SpanElement span8 = taggedContent.CreateSpanElement();
            span8.SetText("Nulla in consectetur massa. Vestibulum vitae lobortis ante. Nulla ullamcorper pellentesque justo rhoncus accumsan. ");
            p.AppendChild(span8);
            SpanElement span9 = taggedContent.CreateSpanElement();
            span9.SetText("Mauris ornare eu odio non lacinia. Aliquam massa leo, rhoncus ac iaculis eget, tempus et magna. Sed non consectetur elit. ");
            p.AppendChild(span9);
            SpanElement span10 = taggedContent.CreateSpanElement();
            span10.SetText("Sed vulputate, quam sed lacinia luctus, ipsum nibh fringilla purus, vitae posuere risus odio id massa. Cras sed venenatis lacus.");
            p.AppendChild(span10);

            // Save Tagged Pdf Document
            document.Save(dataDir + "InlineStructureElements.pdf");
            // ExEnd:InlineStructureElements
        }
    }
}
