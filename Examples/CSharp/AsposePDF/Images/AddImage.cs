using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class AddImage
    {
        public static void Run()
        {
            // ExStart:AddImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "AddImage.pdf");

            // Set coordinates
            int lowerLeftX = 100;
            int lowerLeftY = 100;
            int upperRightX = 200;
            int upperRightY = 200;

            // Get the page where image needs to be added
            Page page = pdfDocument.Pages[1];
            // Load image into stream
            FileStream imageStream = new FileStream(dataDir + "aspose-logo.jpg", FileMode.Open);
            // Add image to Images collection of Page Resources
            page.Resources.Images.Add(imageStream);
            // Using GSave operator: this operator saves current graphics state
            page.Contents.Add(new Aspose.Pdf.Operators.GSave());
            // Create Rectangle and Matrix objects
            Aspose.Pdf.Rectangle rectangle = new Aspose.Pdf.Rectangle(lowerLeftX, lowerLeftY, upperRightX, upperRightY);
            Matrix matrix = new Matrix(new double[] { rectangle.URX - rectangle.LLX, 0, 0, rectangle.URY - rectangle.LLY, rectangle.LLX, rectangle.LLY });
            // Using ConcatenateMatrix (concatenate matrix) operator: defines how image must be placed
            page.Contents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(matrix));
            XImage ximage = page.Resources.Images[page.Resources.Images.Count];
            // Using Do operator: this operator draws image
            page.Contents.Add(new Aspose.Pdf.Operators.Do(ximage.Name));
            // Using GRestore operator: this operator restores graphics state
            page.Contents.Add(new Aspose.Pdf.Operators.GRestore());
            dataDir = dataDir + "AddImage_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:AddImage
            Console.WriteLine("\nImage added successfully.\nFile saved at " + dataDir); 
        }

        public static void AddDicomImage()
        {
            //ExStart: AddDicomImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            using (Document pdfDocument = new Document())
            {
                pdfDocument.Pages.Add();
                Aspose.Pdf.Image image = new Aspose.Pdf.Image();
                image.FileType = ImageFileType.Dicom;
                image.ImageStream = new FileStream(dataDir + "0002.dcm", FileMode.Open, FileAccess.Read);
                pdfDocument.Pages[1].Paragraphs.Add(image);
                // Save output as PDF format
                pdfDocument.Save(dataDir + "PdfWithDicomImage_out.pdf");
            }
            //ExEnd: AddDicomImage
        }
    }
}