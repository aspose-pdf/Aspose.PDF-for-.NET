using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class CreateStructureElementsTree
    {
        public static void Run()
        {
            // ExStart:CreateStructureElementsTree
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Create Pdf Document
            Document document = new Document();

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language for Documnet
            taggedContent.SetTitle("Tagged Pdf Document");
            taggedContent.SetLanguage("en-US");

            // Get root structure element (Document)
            StructureElement rootElement = taggedContent.RootElement;

            // Create Logical Structure
            SectElement sect1 = taggedContent.CreateSectElement();
            rootElement.AppendChild(sect1);

            SectElement sect2 = taggedContent.CreateSectElement();
            rootElement.AppendChild(sect2);

            DivElement div11 = taggedContent.CreateDivElement();
            sect1.AppendChild(div11);

            DivElement div12 = taggedContent.CreateDivElement();
            sect1.AppendChild(div12);

            ArtElement art21 = taggedContent.CreateArtElement();
            sect2.AppendChild(art21);

            ArtElement art22 = taggedContent.CreateArtElement();
            sect2.AppendChild(art22);

            DivElement div211 = taggedContent.CreateDivElement();
            art21.AppendChild(div211);

            DivElement div212 = taggedContent.CreateDivElement();
            art21.AppendChild(div212);

            DivElement div221 = taggedContent.CreateDivElement();
            art22.AppendChild(div221);

            DivElement div222 = taggedContent.CreateDivElement();
            art22.AppendChild(div222);

            SectElement sect3 = taggedContent.CreateSectElement();
            rootElement.AppendChild(sect3);

            DivElement div31 = taggedContent.CreateDivElement();
            sect3.AppendChild(div31);

            // Save Tagged Pdf Document
            document.Save(dataDir + "StructureElementsTree.pdf");
            // ExEnd:CreateStructureElementsTree
        }
    }
}
