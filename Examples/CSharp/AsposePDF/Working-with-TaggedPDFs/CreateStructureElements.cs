using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class CreateStructureElements
    {
        public static void Run()
        {
            // ExStart:CreateStructureElements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Create Grouping Elements
            PartElement partElement = taggedContent.CreatePartElement();
            ArtElement artElement = taggedContent.CreateArtElement();
            SectElement sectElement = taggedContent.CreateSectElement();
            DivElement divElement = taggedContent.CreateDivElement();
            BlockQuoteElement blockQuoteElement = taggedContent.CreateBlockQuoteElement();
            CaptionElement captionElement = taggedContent.CreateCaptionElement();
            TOCElement tocElement = taggedContent.CreateTOCElement();
            TOCIElement tociElement = taggedContent.CreateTOCIElement();
            IndexElement indexElement = taggedContent.CreateIndexElement();
            NonStructElement nonStructElement = taggedContent.CreateNonStructElement();
            PrivateElement privateElement = taggedContent.CreatePrivateElement();

            // Create Text Block-Level Structure Elements
            ParagraphElement paragraphElement = taggedContent.CreateParagraphElement();
            HeaderElement headerElement = taggedContent.CreateHeaderElement();
            HeaderElement h1Element = taggedContent.CreateHeaderElement(1);

            // Create Text Inline-Level Structure Elements
            SpanElement spanElement = taggedContent.CreateSpanElement();
            QuoteElement quoteElement = taggedContent.CreateQuoteElement();
            NoteElement noteElement = taggedContent.CreateNoteElement();

            // Create Illustration Structure Elements
            FigureElement figureElement = taggedContent.CreateFigureElement();
            FormulaElement formulaElement = taggedContent.CreateFormulaElement();

            // Methods are under development
            ListElement listElement = taggedContent.CreateListElement();
            TableElement tableElement = taggedContent.CreateTableElement();
            ReferenceElement referenceElement = taggedContent.CreateReferenceElement();
            BibEntryElement bibEntryElement = taggedContent.CreateBibEntryElement();
            CodeElement codeElement = taggedContent.CreateCodeElement();
            LinkElement linkElement = taggedContent.CreateLinkElement();
            AnnotElement annotElement = taggedContent.CreateAnnotElement();
            RubyElement rubyElement = taggedContent.CreateRubyElement();
            WarichuElement warichuElement = taggedContent.CreateWarichuElement();
            FormElement formElement = taggedContent.CreateFormElement();

            // Save Tagged Pdf Document
            document.Save(dataDir + "StructureElements.pdf");
            // ExEnd:CreateStructureElements
        }
    }
}
