using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Stamps_Watermarks
{
    class ExtractTextFromStampAnnotation
    {
        public static void Run()
        {
            //ExStart:ExtractTextFromStampAnnotation
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();
            Document doc = new Document(dataDir + "test.pdf");
            StampAnnotation annot = doc.Pages[1].Annotations[3] as StampAnnotation;
            TextAbsorber ta = new TextAbsorber();
            XForm ap = annot.Appearance["N"];
            ta.Visit(ap);
            Console.WriteLine(ta.Text);
            //ExEnd: ExtractTextFromStampAnnotation
        }
    }
}
