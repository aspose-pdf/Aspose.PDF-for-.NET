using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class ValidatePDF
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            string inputFileName = dataDir + "StructureElements.pdf";
            string outputLogName = dataDir + "ua-20.xml";

            using (var document = new Aspose.Pdf.Document(inputFileName))
            {
                bool isValid = document.Validate(outputLogName, Aspose.Pdf.PdfFormat.PDF_UA_1);

            }
            // ExStart:1

        }
    }
}
