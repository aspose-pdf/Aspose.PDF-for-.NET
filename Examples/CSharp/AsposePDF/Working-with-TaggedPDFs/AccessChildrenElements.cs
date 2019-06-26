using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class AccessChildrenElements
    {
        public static void Run()
        {
            // ExStart:AccessChildrenElements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open Pdf Document
            Document document = new Document(dataDir + "StructureElementsTree.pdf");

            // Get Content for work with TaggedPdf
            ITaggedContent taggedContent = document.TaggedContent;

            // Access to root element(s)
            ElementList elementList = taggedContent.StructTreeRootElement.ChildElements;
            foreach (Element element in elementList)
            {
                if (element is StructureElement)
                {
                    StructureElement structureElement = element as StructureElement;

                    // Get properties
                    string title = structureElement.Title;
                    string language = structureElement.Language;
                    string actualText = structureElement.ActualText;
                    string expansionText = structureElement.ExpansionText;
                    string alternativeText = structureElement.AlternativeText;
                }
            }

            // Access to children elements of first element in root element
            elementList = taggedContent.RootElement.ChildElements[1].ChildElements;
            foreach (Element element in elementList)
            {
                if (element is StructureElement)
                {
                    StructureElement structureElement = element as StructureElement;

                    // Set properties
                    structureElement.Title = "title";
                    structureElement.Language = "fr-FR";
                    structureElement.ActualText = "actual text";
                    structureElement.ExpansionText = "exp";
                    structureElement.AlternativeText = "alt";
                }
            }

            // Save Tagged Pdf Document
            document.Save(dataDir + "AccessChildrenElements.pdf");

            // ExEnd:AccessChildrenElements
        }
    }
}
