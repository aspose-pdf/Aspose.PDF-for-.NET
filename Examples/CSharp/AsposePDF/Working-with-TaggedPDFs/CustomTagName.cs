using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class CustomTagName
    {
        public static void Run()
        {
            // ExStart:CustomTagName
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Create Logical Structure Elements
            SectElement sect = taggedContent.CreateSectElement();
            taggedContent.RootElement.AppendChild(sect);

            ParagraphElement p1 = taggedContent.CreateParagraphElement();
            ParagraphElement p2 = taggedContent.CreateParagraphElement();
            ParagraphElement p3 = taggedContent.CreateParagraphElement();
            ParagraphElement p4 = taggedContent.CreateParagraphElement();

            p1.SetText("P1. ");
            p2.SetText("P2. ");
            p3.SetText("P3. ");
            p4.SetText("P4. ");

            p1.SetTag("P1");
            p2.SetTag("Para");
            p3.SetTag("Para");
            p4.SetTag("Paragraph");

            sect.AppendChild(p1);
            sect.AppendChild(p2);
            sect.AppendChild(p3);
            sect.AppendChild(p4);

            SpanElement span1 = taggedContent.CreateSpanElement();
            SpanElement span2 = taggedContent.CreateSpanElement();
            SpanElement span3 = taggedContent.CreateSpanElement();
            SpanElement span4 = taggedContent.CreateSpanElement();

            span1.SetText("Span 1.");
            span2.SetText("Span 2.");
            span3.SetText("Span 3.");
            span4.SetText("Span 4.");

            span1.SetTag("SPAN");
            span2.SetTag("Sp");
            span3.SetTag("Sp");
            span4.SetTag("TheSpan");

            p1.AppendChild(span1);
            p2.AppendChild(span2);
            p3.AppendChild(span3);
            p4.AppendChild(span4);

            // Save Tagged Pdf Document
            document.Save(dataDir + "CustomTag.pdf");
            // ExEnd:CustomTagName
        }
    }
}
