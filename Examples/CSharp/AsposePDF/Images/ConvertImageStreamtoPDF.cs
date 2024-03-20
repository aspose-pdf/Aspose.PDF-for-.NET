using System.IO;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ConvertImageStreamToPDF
    {
        public static void Run()
        {
            // ExStart:ConvertImageStreamtoPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Instantiate Document instance by calling its empty constructor
            Aspose.Pdf.Document pdf1 = new Aspose.Pdf.Document();
            // Add a Page into the pdf document
            Aspose.Pdf.Page sec = pdf1.Pages.Add();

            // Create a FileStream object to read the imag file
            FileStream fs = File.OpenRead(dataDir + "aspose.jpg");
            // Read the image into Byte array
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);

            // Create a MemoryStream object from image Byte array
            MemoryStream ms = new MemoryStream(data);
            // Create an image object
            Aspose.Pdf.Image imageht = new Aspose.Pdf.Image();

            // Specify the image source as MemoryStream
            imageht.ImageStream = ms;
            // Add image object into the Paragraphs collection of the section
            sec.Paragraphs.Add(imageht);

            // Save the Pdf
            pdf1.Save(dataDir + "ConvertMemoryStreamImageToPdf_out.pdf");
            // Close the MemoryStream Object
            ms.Close();
            // ExEnd:ConvertImageStreamtoPDF
        }
    }
}
