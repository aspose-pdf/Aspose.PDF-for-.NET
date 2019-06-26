using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class DefineAlignment
    {
        public static void Run()
        {
            // ExStart:DefineAlignment
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Instantiate Document object with input file
            Document doc = new Document(dataDir+ "DefineAlignment.pdf");
            // Instantiate FormattedText object with sample string
            FormattedText text = new FormattedText("This");
            // Add new text line to FormattedText
            text.AddNewLineText("is sample");
            text.AddNewLineText("Center Aligned");
            text.AddNewLineText("TextStamp");
            text.AddNewLineText("Object");
            // Create TextStamp object using FormattedText
            TextStamp stamp = new TextStamp(text);
            // Specify the Horizontal Alignment of text stamp as Center aligned
            stamp.HorizontalAlignment = HorizontalAlignment.Center;
            // Specify the Vertical Alignment of text stamp as Center aligned
            stamp.VerticalAlignment = VerticalAlignment.Center;
            // Specify the Text Horizontal Alignment of TextStamp as Center aligned
            stamp.TextAlignment = HorizontalAlignment.Center;
            // Set top margin for stamp object
            stamp.TopMargin = 20;
            // Add the stamp object over first page of document
            doc.Pages[1].AddStamp(stamp);

            dataDir = dataDir + "StampedPDF_out.pdf";
            // Save the udpated document
            doc.Save(dataDir);
            // ExEnd:DefineAlignment            
            Console.WriteLine("\nAlignment defined successfully for text stamp.\nFile saved at " + dataDir);
        }
    }
}