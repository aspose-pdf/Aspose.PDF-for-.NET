using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class LinkStructureElements
    {
        public static void Run()
        {
            // ExStart:LinkStructureElements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            string outFile = dataDir + "LinkStructureElements_Output.pdf";
            string logFile = dataDir + "46035_log.xml";
            string imgFile = dataDir + "google-icon-512.png";

            // Creation document and getting Tagged Pdf Content
            Document document = new Document(); 
            ITaggedContent taggedContent = document.TaggedContent;


            // Setting Title and Nature Language for document
            taggedContent.SetTitle("Link Elements Example");
            taggedContent.SetLanguage("en-US");

            // Getting Root structure element (Document structure element)
            StructureElement rootElement = taggedContent.RootElement;


            ParagraphElement p1 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p1);
            LinkElement link1 = taggedContent.CreateLinkElement();
            p1.AppendChild(link1);
            link1.Hyperlink = new WebHyperlink("http://google.com");
            link1.SetText("Google");
            link1.AlternateDescriptions = "Link to Google";


            ParagraphElement p2 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p2);
            LinkElement link2 = taggedContent.CreateLinkElement();
            p2.AppendChild(link2);
            link2.Hyperlink = new WebHyperlink("http://google.com");
            SpanElement span2 = taggedContent.CreateSpanElement();
            span2.SetText("Google");
            link2.AppendChild(span2);
            link2.AlternateDescriptions = "Link to Google";


            ParagraphElement p3 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p3);
            LinkElement link3 = taggedContent.CreateLinkElement();
            p3.AppendChild(link3);
            link3.Hyperlink = new WebHyperlink("http://google.com");
            SpanElement span31 = taggedContent.CreateSpanElement();
            span31.SetText("G");
            SpanElement span32 = taggedContent.CreateSpanElement();
            span32.SetText("oogle");
            link3.AppendChild(span31);
            link3.SetText("-");
            link3.AppendChild(span32);
            link3.AlternateDescriptions = "Link to Google";


            ParagraphElement p4 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p4);
            LinkElement link4 = taggedContent.CreateLinkElement();
            p4.AppendChild(link4);
            link4.Hyperlink = new WebHyperlink("http://google.com");
            link4.SetText("The multiline link: Google Google Google Google Google Google Google Google Google Google Google Google Google Google Google Google Google Google Google Google");
            link4.AlternateDescriptions = "Link to Google (multiline)";


            ParagraphElement p5 = taggedContent.CreateParagraphElement();
            rootElement.AppendChild(p5);
            LinkElement link5 = taggedContent.CreateLinkElement();
            p5.AppendChild(link5);
            link5.Hyperlink = new WebHyperlink("http://google.com");
            FigureElement figure5 = taggedContent.CreateFigureElement();
            figure5.SetImage(imgFile, 1200);
            figure5.AlternativeText = "Google icon";
            StructureAttributes linkLayoutAttributes = link5.Attributes.GetAttributes(AttributeOwnerStandard.Layout);
            StructureAttribute placementAttribute = new StructureAttribute(AttributeKey.Placement);
            placementAttribute.SetNameValue(AttributeName.Placement_Block);
            linkLayoutAttributes.SetAttribute(placementAttribute);
            link5.AppendChild(figure5);
            link5.AlternateDescriptions = "Link to Google";


            // Save Tagged Pdf Document
            document.Save(outFile);

            // Checking PDF/UA compliance
            document = new Document(outFile);
            bool isPdfUaCompliance = document.Validate(logFile, PdfFormat.PDF_UA_1);
            Console.WriteLine(String.Format("PDF/UA compliance: {0}", isPdfUaCompliance));
            // ExEnd:LinkStructureElements
        }
    }
}
