using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class CreatePDFWithTaggedText
    {
        public static void Run()
        {
            // ExStart:CreatePDFwithTaggedText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Create Text Block-Level Structure Elements
            HeaderElement headerElement = taggedContent.CreateHeaderElement();
            headerElement.ActualText = "Heading 1";
            ParagraphElement paragraphElement1 = taggedContent.CreateParagraphElement();
            paragraphElement1.ActualText = "test1";
            ParagraphElement paragraphElement2 = taggedContent.CreateParagraphElement();
            paragraphElement2.ActualText = "test 2";
            ParagraphElement paragraphElement3 = taggedContent.CreateParagraphElement();
            paragraphElement3.ActualText = "test 3";
            ParagraphElement paragraphElement4 = taggedContent.CreateParagraphElement();
            paragraphElement4.ActualText = "test 4";
            ParagraphElement paragraphElement5 = taggedContent.CreateParagraphElement();
            paragraphElement5.ActualText = "test 5";
            ParagraphElement paragraphElement6 = taggedContent.CreateParagraphElement();
            paragraphElement6.ActualText = "test 6";
            ParagraphElement paragraphElement7 = taggedContent.CreateParagraphElement();
            paragraphElement7.ActualText = "test 7";

            // Save PDF Document
            document.Save( dataDir + "PDFwithTaggedText.pdf");
            // ExEnd:CreatePDFwithTaggedText
        }
    }
}
