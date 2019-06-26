using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class AddTextStamp
    {
        public static void Run()
        {
            // ExStart:AddTextStamp
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "AddTextStamp.pdf");

            // Create text stamp
            TextStamp textStamp = new TextStamp("Sample Stamp");
            // Set whether stamp is background
            textStamp.Background = true;
            // Set origin
            textStamp.XIndent = 100;
            textStamp.YIndent = 100;
            // Rotate stamp
            textStamp.Rotate = Rotation.on90;
            // Set text properties
            textStamp.TextState.Font = FontRepository.FindFont("Arial");
            textStamp.TextState.FontSize = 14.0F;
            textStamp.TextState.FontStyle = FontStyles.Bold;
            textStamp.TextState.FontStyle = FontStyles.Italic;
            textStamp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Aqua);
            // Add stamp to particular page
            pdfDocument.Pages[1].AddStamp(textStamp);

            dataDir = dataDir + "AddTextStamp_out.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:AddTextStamp
            Console.WriteLine("\nText stamp added successfully.\nFile saved at " + dataDir);            
            
        }
    }
}