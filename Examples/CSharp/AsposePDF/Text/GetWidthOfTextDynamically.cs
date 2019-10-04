using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class GetWidthOfTextDynamically
    {
        public static void Run()
        {
            //ExStart: GetWidthOfTextDynamically
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            Aspose.Pdf.Text.Font font = FontRepository.FindFont("Arial");
            TextState ts = new TextState();
            ts.Font = font;
            ts.FontSize = 14;

            if (Math.Abs(font.MeasureString("A", 14) - 9.337) > 0.001)
                Console.WriteLine("Unexpected font string measure!");

            if (Math.Abs(ts.MeasureString("z") - 7.0) > 0.001)
                Console.WriteLine("Unexpected font string measure!");

            for (char c = 'A'; c <= 'z'; c++)
            {
                double fnMeasure = font.MeasureString(c.ToString(), 14);
                double tsMeasure = ts.MeasureString(c.ToString());

                if (Math.Abs(fnMeasure - tsMeasure) > 0.001)
                    Console.WriteLine("Font and state string measuring doesn't match!");
            }
            //ExEnd: GetWidthOfTextDynamically
        }
    }
}
