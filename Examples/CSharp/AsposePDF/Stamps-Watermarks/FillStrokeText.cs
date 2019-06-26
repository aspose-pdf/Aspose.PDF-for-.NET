using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class FillStrokeText
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();
            // Create TextState object to transfer advanced properties
            TextState ts = new TextState();
            // Set color for stroke
            ts.StrokingColor = Color.Gray;
            // Set text rendering mode
            ts.RenderingMode = TextRenderingMode.StrokeText;
            // Load an input PDF document
            Facades.PdfFileStamp fileStamp = new Facades.PdfFileStamp(new Aspose.Pdf.Document(dataDir + "input.pdf"));

            Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();
            stamp.BindLogo(new Facades.FormattedText("PAID IN FULL", System.Drawing.Color.Gray, "Arial", Facades.EncodingType.Winansi, true, 78));

            // Bind TextState
            stamp.BindTextState(ts);
            // Set X,Y origin
            stamp.SetOrigin(100, 100);
            stamp.Opacity = 5;
            stamp.BlendingSpace = Facades.BlendingColorSpace.DeviceRGB;
            stamp.Rotation = 45.0F;
            stamp.IsBackground = false;
            // Add Stamp
            fileStamp.AddStamp(stamp);
            fileStamp.Save(dataDir + "ouput_out.pdf");
            fileStamp.Close();
            // ExEnd:1
        }
    }
}
