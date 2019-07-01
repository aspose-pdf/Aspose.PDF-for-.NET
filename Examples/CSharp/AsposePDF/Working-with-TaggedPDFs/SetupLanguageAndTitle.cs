using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    /// <summary>
    /// This method is supported by version 18.12 or greater
    /// </summary>
    public class SetupLanguageAndTitle
    {
        public static void Run()
        {
            // ExStart:1
            Document document = new Document();
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Get TaggedContent
            Tagged.ITaggedContent taggedContent = document.TaggedContent;

            // Set Title and Language
            taggedContent.SetTitle("Example Tagged Document");
            taggedContent.SetLanguage("en-US");

            // Header (en-US, inherited from document)
            LogicalStructure.HeaderElement h1 = taggedContent.CreateHeaderElement(1);
            h1.SetText("Phrase on different languages");
            taggedContent.RootElement.AppendChild(h1);

            // Paragraph (English)
            LogicalStructure.ParagraphElement pEN = taggedContent.CreateParagraphElement();
            pEN.SetText("Hello, World!");
            pEN.Language = "en-US";
            taggedContent.RootElement.AppendChild(pEN);

            // Paragraph (German)
            LogicalStructure.ParagraphElement pDE = taggedContent.CreateParagraphElement();
            pDE.SetText("Hallo Welt!");
            pDE.Language = "de-DE";
            taggedContent.RootElement.AppendChild(pDE);

            // Paragraph (French)
            LogicalStructure.ParagraphElement pFR = taggedContent.CreateParagraphElement();
            pFR.SetText("Bonjour le monde!");
            pFR.Language = "fr-FR";
            taggedContent.RootElement.AppendChild(pFR);

            // Paragraph (Spanish)
            LogicalStructure.ParagraphElement pSP = taggedContent.CreateParagraphElement();
            pSP.SetText("¡Hola Mundo!");
            pSP.Language = "es-ES";
            taggedContent.RootElement.AppendChild(pSP);

            // Save Tagged Pdf Document
            document.Save(dataDir + "SetupLanguageAndTitle.pdf");
            // ExEnd:1
        }
    }
}
