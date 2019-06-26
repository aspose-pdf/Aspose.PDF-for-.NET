using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class AddStructureElementIntoElement
    {
        public static void Run()
        {
            // ExStart:AddStructureElementIntoElement
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            string outFile = dataDir + "AddStructureElementIntoElement_Output.pdf";
            string logFile = dataDir + "46144_log.xml";

            // Creation document and getting Tagged Pdf Content
            Document document = new Document();
            ITaggedContent taggedContent = document.TaggedContent;


            // Setting Title and Nature Language for document
            taggedContent.SetTitle("Text Elements Example");
            taggedContent.SetLanguage("en-US");

            // Getting Root structure element (Document structure element)
            StructureElement rootElement = taggedContent.RootElement;


            ParagraphElement p1 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p1);
            SpanElement span11 = taggedContent.CreateSpanElement();
            span11.SetText("Span_11");
            SpanElement span12 = taggedContent.CreateSpanElement();
            span12.SetText(" and Span_12.");
            p1.SetText("Paragraph with ");
            p1.AppendChild(span11);
            p1.AppendChild(span12);


            ParagraphElement p2 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p2);
            SpanElement span21 = taggedContent.CreateSpanElement();
            span21.SetText("Span_21");
            SpanElement span22 = taggedContent.CreateSpanElement();
            span22.SetText("Span_22.");
            p2.AppendChild(span21);
            p2.SetText(" and ");
            p2.AppendChild(span22);


            ParagraphElement p3 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p3);
            SpanElement span31 = taggedContent.CreateSpanElement();
            span31.SetText("Span_31");
            SpanElement span32 = taggedContent.CreateSpanElement();
            span32.SetText(" and Span_32");
            p3.AppendChild(span31);
            p3.AppendChild(span32);
            p3.SetText(".");


            ParagraphElement p4 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p4);
            SpanElement span41 = taggedContent.CreateSpanElement();
            SpanElement span411 = taggedContent.CreateSpanElement();
            span411.SetText("Span_411, ");
            span41.SetText("Span_41, ");
            span41.AppendChild(span411);
            SpanElement span42 = taggedContent.CreateSpanElement();
            SpanElement span421 = taggedContent.CreateSpanElement();
            span421.SetText("Span 421 and ");
            span42.AppendChild(span421);
            span42.SetText("Span_42");
            p4.AppendChild(span41);
            p4.AppendChild(span42);
            p4.SetText(".");


            // Save Tagged Pdf Document
            document.Save(outFile);

            // Checking PDF/UA compliance
            document = new Document(outFile);
            bool isPdfUaCompliance = document.Validate(logFile, PdfFormat.PDF_UA_1);
            Console.WriteLine(String.Format("PDF/UA compliance: {0}", isPdfUaCompliance));
            // ExEnd:AddStructureElementIntoElement
        }
    }
}
