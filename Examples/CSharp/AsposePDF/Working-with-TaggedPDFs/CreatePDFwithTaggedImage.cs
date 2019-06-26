using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class CreatePDFwithTaggedImage
    {
        public static void Run()
        {
            // ExStart:CreatePDFwithTaggedImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
     
            Document document = new Document();
            ITaggedContent taggedContent = document.TaggedContent;

            taggedContent.SetTitle("CreatePDFwithTaggedImage");
            taggedContent.SetLanguage("en-US");

            IllustrationElement figure1 = taggedContent.CreateFigureElement();
            taggedContent.RootElement.AppendChild(figure1);
            figure1.AlternativeText = "Aspose Logo";
            figure1.Title = "Image 1";
            figure1.SetTag("Fig");
            // Add image with resolution 300 DPI (by default)
            figure1.SetImage(dataDir + @"aspose-logo.jpg");

            // Save PDF Document
            document.Save(dataDir + "PDFwithTaggedImage.pdf");
            // ExEnd:CreatePDFwithTaggedImage
        }
    }
}
