using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System.Drawing;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ImageToPDF
    {
        public static void Run()
        {
            // ExStart:ImageToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Instantiate Document Object
            Document doc = new Document();
            // Add a page to pages collection of document
            Page page = doc.Pages.Add();
            // Load the source image file to Stream object
            using (FileStream fs = new FileStream(dataDir + "aspose-logo.jpg", FileMode.Open, FileAccess.Read))
            {
                byte[] tmpBytes = new byte[fs.Length];
                fs.Read(tmpBytes, 0, int.Parse(fs.Length.ToString()));

                MemoryStream mystream = new MemoryStream(tmpBytes);
                // Instantiate BitMap object with loaded image stream
                Bitmap b = new Bitmap(mystream);

                // Set margins so image will fit, etc.
                page.PageInfo.Margin.Bottom = 0;
                page.PageInfo.Margin.Top = 0;
                page.PageInfo.Margin.Left = 0;
                page.PageInfo.Margin.Right = 0;

                page.CropBox = new Aspose.Pdf.Rectangle(0, 0, b.Width, b.Height);
                // Create an image object
                Aspose.Pdf.Image image1 = new Aspose.Pdf.Image();
                // Add the image into paragraphs collection of the section
                page.Paragraphs.Add(image1);
                // Set the image file stream
                image1.ImageStream = mystream;
                dataDir = dataDir + "ImageToPDF_out.pdf";
                // Save resultant PDF file
                doc.Save(dataDir);

                // Close memoryStream object
                mystream.Close();

            }
            // ExEnd:ImageToPDF
            Console.WriteLine("\nImage converted to pdf successfully.\nFile saved at " + dataDir);
        }
    }
}