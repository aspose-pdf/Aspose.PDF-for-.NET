using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class DeterminePageColor
    {
        public static void Run()
        {
            // ExStart:DeterminePageColor
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open source PDF file
            Document pdfDocument = new Document( dataDir + "input.pdf");
            // Iterate through all the page of PDF file
            for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                // Get the color type information for particular PDF page
                Aspose.Pdf.ColorType pageColorType = pdfDocument.Pages[pageCount].ColorType;
                switch (pageColorType)
                {
                    case ColorType.BlackAndWhite:
                        Console.WriteLine("Page # -" + pageCount + " is Black and white..");
                        break;
                    case ColorType.Grayscale:
                        Console.WriteLine("Page # -" + pageCount + " is Gray Scale...");
                        break;
                    case ColorType.Rgb:
                        Console.WriteLine("Page # -" + pageCount + " is RGB..", pageCount);
                        break;
                    case ColorType.Undefined:
                        Console.WriteLine("Page # -" + pageCount + " Color is undefined..");
                        break;
                }
            }
            // ExEnd:DeterminePageColor
        }
    }
}