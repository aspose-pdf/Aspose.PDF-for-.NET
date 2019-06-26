using System.IO;
using System;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Miscellaneous
{
    public class ReadMeasure
    {
        public static void Run()
        {
            try
            {
                // ExStart:ReadMeasure
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Miscellaneous();

                Document doc = new Document(dataDir + "ReadMeasure.pdf");
                Console.WriteLine((doc.Pages[1].Annotations[1] as LineAnnotation).Measure.ScaleRatio);
                Console.WriteLine((doc.Pages[1].Annotations[1] as LineAnnotation).Measure.AreaFormat[1].UnitLabel);
                Console.WriteLine((doc.Pages[1].Annotations[1] as LineAnnotation).Measure.AreaFormat[1].ConvresionFactor);
                Console.WriteLine((doc.Pages[1].Annotations[1] as LineAnnotation).Measure.AreaFormat[1].FractionSeparator);
                // ExEnd:ReadMeasure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}