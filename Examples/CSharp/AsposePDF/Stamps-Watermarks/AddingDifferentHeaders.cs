using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class AddingDifferentHeaders
    {
        public static void Run()
        {
            // ExStart:AddingDifferentHeaders
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open source document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir+ "AddingDifferentHeaders.pdf");

            // Create three stamps
            Aspose.Pdf.TextStamp stamp1 = new Aspose.Pdf.TextStamp("Header 1");
            Aspose.Pdf.TextStamp stamp2 = new Aspose.Pdf.TextStamp("Header 2");
            Aspose.Pdf.TextStamp stamp3 = new Aspose.Pdf.TextStamp("Header 3");

            // Set stamp alignment (place stamp on page top, centered horiznotally)
            stamp1.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            stamp1.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // Specify the font style as Bold
            stamp1.TextState.FontStyle = FontStyles.Bold;
            // Set the text fore ground color information as red
            stamp1.TextState.ForegroundColor = Color.Red;
            // Specify the font size as 14
            stamp1.TextState.FontSize = 14;

            // Now we need to set the vertical alignment of 2nd stamp object as Top
            stamp2.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            // Set Horizontal alignment information for stamp as Center aligned
            stamp2.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // Set the zooming factor for stamp object
            stamp2.Zoom = 10;

            // Set the formatting of 3rd stamp object
            // Specify the Vertical alignment information for stamp object as TOP
            stamp3.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            // Set the Horizontal alignment inforamtion for stamp object as Center aligned
            stamp3.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // Set the rotation angle for stamp object
            stamp3.RotateAngle = 35;
            // Set pink as background color for stamp
            stamp3.TextState.BackgroundColor = Color.Pink;
            // Change the font face information for stamp to Verdana
            stamp3.TextState.Font = FontRepository.FindFont("Verdana");
            // First stamp is added on first page;
            doc.Pages[1].AddStamp(stamp1);
            // Second stamp is added on second page;
            doc.Pages[2].AddStamp(stamp2);
            // Third stamp is added on third page.
            doc.Pages[3].AddStamp(stamp3);
            dataDir = dataDir + "multiheader_out.pdf";
            // Save the updated document
            doc.Save(dataDir);
            // ExEnd:AddingDifferentHeaders 
            Console.WriteLine("\nDifferent headers added successfully.\nFile saved at " + dataDir);
        }
    }
}