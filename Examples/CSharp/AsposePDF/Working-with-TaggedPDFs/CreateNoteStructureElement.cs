using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class CreateNoteStructureElement
    {
        public static void Run()
        {
            // ExStart:CreateNoteStructureElement
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            string outFile = dataDir + "45929_doc.pdf";
            string logFile = dataDir + "45929_log.xml";

            // Create Pdf Document
            Document document = new Document();
            ITaggedContent taggedContent = document.TaggedContent;

            taggedContent.SetTitle("Sample of Note Elements");
            taggedContent.SetLanguage("en-US");

            // Add Paragraph Element
            ParagraphElement paragraph = taggedContent.CreateParagraphElement();
            taggedContent.RootElement.AppendChild(paragraph);

            // Add NoteElement
            NoteElement note1 = taggedContent.CreateNoteElement();
            paragraph.AppendChild(note1);
            note1.SetText("Note with auto generate ID. ");

            // Add NoteElement
            NoteElement note2 = taggedContent.CreateNoteElement();
            paragraph.AppendChild(note2);
            note2.SetText("Note with ID = 'note_002'. ");
            note2.SetId("note_002");

            // Add NoteElement
            NoteElement note3 = taggedContent.CreateNoteElement();
            paragraph.AppendChild(note3);
            note3.SetText("Note with ID = 'note_003'. ");
            note3.SetId("note_003");

            // Must throw exception - Aspose.Pdf.Tagged.TaggedException : Structure element with ID='note_002' already exists
            //note3.SetId("note_002");

            // Resultant document does not compliance to PDF/UA If ClearId() used for Note Structure Element
            //note3.ClearId();


            // Save Tagged Pdf Document
            document.Save(outFile);

            // Checking PDF/UA compliance
            document = new Document(outFile);
            bool isPdfUaCompliance = document.Validate(logFile, PdfFormat.PDF_UA_1);
            Console.WriteLine(String.Format("PDF/UA compliance: {0}", isPdfUaCompliance));
            // ExEnd:CreateNoteStructureElement
        }
    }
}
