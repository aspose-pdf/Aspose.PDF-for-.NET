using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class AddPageNumber
    {
        public static void Run()
        {
            // ExStart:AddPageNumber
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            // Create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();

            // Open Document
            fileStamp.BindPdf(dataDir + "AddPageNumber.pdf");
            
            // Get total number of pages
            int totalPages = new PdfFileInfo(dataDir + "AddPageNumber.pdf").NumberOfPages;

            // Create formatted text for page number
            FormattedText formattedText = new FormattedText("Page # Of " + totalPages, System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, false, 14);

            // Set starting number for first page; you might want to start from 2 or more
            fileStamp.StartingNumber = 1;

            // Add page number
            fileStamp.AddPageNumber(formattedText, 0);

            // Save updated PDF file
            fileStamp.Save(dataDir + "AddPageNumber_out.pdf");

            // Close fileStamp
            fileStamp.Close();
            // ExEnd:AddPageNumber
            
        }
        public static void CustomNumberStyle()
        {
            // ExStart:CustomNumberStyle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();
            // Create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();
            // Open Document
            fileStamp.BindPdf(dataDir + "AddPageNumber.pdf");
            // Specify numbering style as Numerals Roman UpperCase
            fileStamp.NumberingStyle = NumberingStyle.NumeralsRomanUppercase;
            // Add page number stamp at Bottom-Center of page
            fileStamp.AddPageNumber("#");
            // Save updated PDF file
            fileStamp.Save(dataDir + "CustomNumberStyle_out.pdf");
            // ExEnd:CustomNumberStyle
        }
    }
}