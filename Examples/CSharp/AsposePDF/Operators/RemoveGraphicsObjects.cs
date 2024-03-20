using System.IO;
using System;
using Aspose.Pdf;
using System.Collections;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Operators
{
    public class RemoveGraphicsObjects
    {
        public static void Run()
        {
            // TODO: Fix 
            // ExStart:RemoveGraphicsObjects
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Operators();

            Document doc = new Document(dataDir+ "RemoveGraphicsObjects.pdf");
            Page page = doc.Pages[2];
            OperatorCollection oc = page.Contents;

            // Used path-painting operators
            Operator[] operators = new Operator[] {
                    new Aspose.Pdf.Operators.Stroke(),
                    new Aspose.Pdf.Operators.ClosePathStroke(),
                    new Aspose.Pdf.Operators.Fill()
            };

            // oc.Delete(operators);
            doc.Save(dataDir+ "No_Graphics_out.pdf");
            // ExEnd:RemoveGraphicsObjects
        }
    }
}