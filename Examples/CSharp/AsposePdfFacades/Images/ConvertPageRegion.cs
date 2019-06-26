using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ConvertPageRegion
    {
        public static void Run()
        {
            // ExStart:ConvertPageRegion
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // Instantiate PdfPageEditor class to get particular page region
            Aspose.Pdf.Facades.PdfPageEditor editor = new Aspose.Pdf.Facades.PdfPageEditor();
            // Bind the source PDF file
            editor.BindPdf(dataDir + "Convert-PageRegion.pdf");
            // Move the origin of PDF file to particular point
            editor.MovePosition(0, 700);
            // Create a memory stream object
            MemoryStream ms = new MemoryStream();
            // Save the updated document to stream object
            editor.Save(ms);
            // Create PdfConverter object
            PdfConverter objConverter = new PdfConverter();
            // Bind input pdf file
            objConverter.BindPdf(ms);
            // Set StartPage and EndPage properties to the page number to
            // You want to convert images from
            objConverter.StartPage = 1;
            objConverter.EndPage = 1;
            // Counter
            int page = 1;
            // Initialize the converting process
            objConverter.DoConvert();
            // Check if pages exist and then convert to image one by one
            while (objConverter.HasNextImage())
                objConverter.GetNextImage(dataDir+ "Specific_Region-Image" + page++ + "_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            // Close the PdfConverter object
            objConverter.Close();
            // Close MemoryStream object holding the updated document
            ms.Close();
            // ExEnd:ConvertPageRegion
            
        }
    }
}