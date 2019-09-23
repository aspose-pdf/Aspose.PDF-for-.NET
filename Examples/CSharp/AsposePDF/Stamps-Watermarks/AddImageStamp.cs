using System.IO;
using Aspose.Pdf;
using System;
using Aspose.Pdf.Text;

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

        public static void AddImageStampAsBackgroundInFloatingBox()
        {
            //ExStart: AddImageStampAsBackgroundInFloatingBox
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Instantiate Document object
            Document doc = new Document();
            // Add page to PDF document
            Page page = doc.Pages.Add();
            // Create FloatingBox object
            FloatingBox aBox = new FloatingBox(200, 100);
            // Set left position for FloatingBox
            aBox.Left = 40;
            // Set Top position for FloatingBox
            aBox.Top = 80;
            // Set the Horizontal alignment for FloatingBox
            aBox.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // Add text fragment to paragraphs collection of FloatingBox
            aBox.Paragraphs.Add(new TextFragment("main text"));
            // Set border for FloatingBox
            aBox.Border = new BorderInfo(BorderSide.All, Aspose.Pdf.Color.Red);
            // Add background image
            aBox.BackgroundImage = new Image
            {
                File = dataDir + "aspose-logo.jpg"
            };
            // Set background color for FloatingBox
            aBox.BackgroundColor = Aspose.Pdf.Color.Yellow;
            // Add FloatingBox to paragraphs collection of page object
            page.Paragraphs.Add(aBox);
            // Save the PDF document
            doc.Save(dataDir + "AddImageStampAsBackgroundInFloatingBox_out.pdf");
            //ExEnd: AddImageStampAsBackgroundInFloatingBox
        }
    }
}