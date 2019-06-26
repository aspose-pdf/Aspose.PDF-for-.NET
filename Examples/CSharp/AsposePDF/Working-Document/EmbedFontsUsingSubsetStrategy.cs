using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    class EmbedFontsUsingSubsetStrategy
    {
        public static void Run()
        {
            // ExStart:EmbedFontsUsingSubsetStrategy 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            Document doc = new Document(dataDir + "input.pdf");
            // All fonts will be embedded as subset into document in case of SubsetAllFonts.
            doc.FontUtilities.SubsetFonts(FontSubsetStrategy.SubsetAllFonts);
            // Font subset will be embedded for fully embedded fonts but fonts which are not embedded into document will not be affected.
            doc.FontUtilities.SubsetFonts(FontSubsetStrategy.SubsetEmbeddedFontsOnly);
            doc.Save(dataDir + "Output_out.pdf");
            // ExEnd:EmbedFontsUsingSubsetStrategy 

        }
    }
}
