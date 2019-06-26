using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class SetImageSize
    {
        public static void Run()
        {
            // ExStart:SetImageSize
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();
            // Instantiate Document object
            Document doc = new Document();
            // add page to pages collection of PDF file
            Aspose.Pdf.Page page = doc.Pages.Add();
            // Create an image instance
            Aspose.Pdf.Image img = new Aspose.Pdf.Image();
            // Set Image Width and Height in Points
            img.FixWidth = 100;
            img.FixHeight = 100;
            // Set image type as SVG
            img.FileType = Aspose.Pdf.ImageFileType.Unknown;
            // Path for source file
            img.File = dataDir + "aspose-logo.jpg";
            page.Paragraphs.Add(img);
            //Set page properties
            page.PageInfo.Width = 800;
            page.PageInfo.Height = 800;
            dataDir = dataDir + "SetImageSize_out.pdf";
            // save resultant PDF file
            doc.Save(dataDir);
            // ExEnd:SetImageSize
            Console.WriteLine("\nImage size added successfully.\nFile saved at " + dataDir);
        }
    }
}
