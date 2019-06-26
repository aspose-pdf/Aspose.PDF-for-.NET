using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class AddImageStamp
    {
        public static void Run()
        {
            // ExStart:AddImageStamp
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "AddImageStamp.pdf");

            // Create image stamp
            ImageStamp imageStamp = new ImageStamp(dataDir + "aspose-logo.jpg");
            imageStamp.Background = true;
            imageStamp.XIndent = 100;
            imageStamp.YIndent = 100;
            imageStamp.Height = 300;
            imageStamp.Width = 300;
            imageStamp.Rotate = Rotation.on270;
            imageStamp.Opacity = 0.5;
            // Add stamp to particular page
            pdfDocument.Pages[1].AddStamp(imageStamp);

            dataDir = dataDir + "AddImageStamp_out.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:AddImageStamp
            Console.WriteLine("\nImage stamp added successfully.\nFile saved at " + dataDir);
            
        }
        public static void ControlImageQuality()
        {
            // ExStart:ControlImageQuality
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "AddImageStamp.pdf");

            // Create image stamp
            ImageStamp imageStamp = new ImageStamp(dataDir + "aspose-logo.jpg");

            imageStamp.Quality = 10;
            pdfDocument.Pages[1].AddStamp(imageStamp);
            pdfDocument.Save(dataDir + "ControlImageQuality_out.pdf");
            // ExEnd:ControlImageQuality
        }
    }
}