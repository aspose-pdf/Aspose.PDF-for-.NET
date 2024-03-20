using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class IllustrationStructureElements
    {
        public static void Run()
        {
            // ExStart:IllustrationStructureElements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Document
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Under Development
            IllustrationElement figure1 = taggedContent.CreateFigureElement();
            taggedContent.RootElement.AppendChild(figure1);
            figure1.AlternativeText = "Figure One";
            figure1.Title = "Image 1";
            figure1.SetTag("Fig1");
            figure1.SetImage(dataDir + "image.jpg");

            // Save Tagged Pdf Document
            document.Save(dataDir + "IllustrationStructureElements.pdf");
            // ExEnd:IllustrationStructureElements
        }
    }
}
