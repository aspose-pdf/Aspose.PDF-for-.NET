using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class StyleTextStructure
    {
        public static void Run()
        {
            // ExStart:StyleTextStructure
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            ParagraphElement p = taggedContent.CreateParagraphElement();
            taggedContent.RootElement.AppendChild(p);

            // Under Development
            p.StructureTextState.FontSize = 18F;
            p.StructureTextState.ForegroundColor = Color.Red;
            p.StructureTextState.FontStyle = FontStyles.Italic;

            p.SetText("Red italic text.");

            // Save Tagged Pdf Document
            document.Save(dataDir + "StyleTextStructure.pdf");
            // ExEnd:StyleTextStructure
        }
    }
}
