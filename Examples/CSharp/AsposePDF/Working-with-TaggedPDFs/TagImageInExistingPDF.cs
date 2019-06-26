using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class TagImageInExistingPDF
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            string inFile = dataDir + "TH.pdf";
            string outFile = dataDir + "TH_out.pdf";
            string logFile = dataDir + "TH_out.xml";

            // Open document
            Document document = new Document(inFile);

            // Gets tagged content and root structure element
            ITaggedContent taggedContent = document.TaggedContent;
            StructureElement rootElement = taggedContent.RootElement;

            // Set title for tagged pdf document
            taggedContent.SetTitle("Document with images");

            foreach (FigureElement figureElement in rootElement.FindElements<FigureElement>(true))
            {
                // Set Alternative Text  for Figure
                figureElement.AlternativeText = "Figure alternative text (technique 2)";


                // Create and Set BBox Attribute
                StructureAttribute bboxAttribute = new StructureAttribute(AttributeKey.BBox);
                bboxAttribute.SetRectangleValue(new Rectangle(0.0, 0.0, 100.0, 100.0));

                StructureAttributes figureLayoutAttributes = figureElement.Attributes.GetAttributes(AttributeOwnerStandard.Layout);
                figureLayoutAttributes.SetAttribute(bboxAttribute);
            }

            // Move Span Element into Paragraph (find wrong span and paragraph in first TD)
            TableElement tableElement = rootElement.FindElements<TableElement>(true)[0];
            SpanElement spanElement = tableElement.FindElements<SpanElement>(true)[0];
            TableTDElement firstTdElement = tableElement.FindElements<TableTDElement>(true)[0];
            ParagraphElement paragraph = firstTdElement.FindElements<ParagraphElement>(true)[0];

            // Move Span Element into Paragraph
            spanElement.ChangeParentElement(paragraph);


            // Save document
            document.Save(outFile);



            // Checking PDF/UA Compliance for out document
            document = new Document(outFile);

            bool isPdfUaCompliance = document.Validate(logFile, PdfFormat.PDF_UA_1);
            Console.WriteLine(String.Format("PDF/UA compliance: {0}", isPdfUaCompliance));
        }
    }
}
