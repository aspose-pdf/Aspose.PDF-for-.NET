using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ConvertPDFPages
    {
        public static void Run()
        {
            // ExStart:ConvertPDFPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();

            // Create PdfConverter object
            PdfConverter objConverter = new PdfConverter();

            // Bind input pdf file
            objConverter.BindPdf(dataDir+ "ConvertPDFPages.pdf");

            // Initialize the converting process
            objConverter.DoConvert();

            objConverter.CoordinateType = PageCoordinateType.CropBox;           

            // Check if pages exist and then convert to image one by one
            while (objConverter.HasNextImage())
                objConverter.GetNextImage(dataDir+ DateTime.Now.Ticks.ToString() + "_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Close the PdfConverter object
            objConverter.Close();
            // ExEnd:ConvertPDFPages
            
        }
    }
}