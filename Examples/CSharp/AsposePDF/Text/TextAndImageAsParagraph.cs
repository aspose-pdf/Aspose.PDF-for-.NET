using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class TextAndImageAsParagraph
    {
        public static void Run()
        {
            // ExStart:TextAndImageAsParagraph
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Instantiate Document instance
            Document doc = new Document();
            // Add page to pages collection of Document instance
            Page page = doc.Pages.Add();
            // Create TextFragmnet
            TextFragment text = new TextFragment("Hello World.. ");
            // Add text fragment to paragraphs collection of Page object
            page.Paragraphs.Add(text);
            // Create an image instance
            Aspose.Pdf.Image image = new Aspose.Pdf.Image();
            // Set image as inline paragraph so that it appears right after 
            // The previous paragraph object (TextFragment)
            image.IsInLineParagraph = true;
            // Specify image file path 
            image.File = dataDir + "aspose-logo.jpg";
            // Set image Height (optional)
            image.FixHeight = 30;
            // Set Image Width (optional)
            image.FixWidth = 100;
            // Add image to paragraphs collection of page object
            page.Paragraphs.Add(image);
            // Re-initialize TextFragment object with different contents
            text = new TextFragment(" Hello Again..");
            // Set TextFragment as inline paragraph
            text.IsInLineParagraph = true;
            // Add newly created TextFragment to paragraphs collection of page
            page.Paragraphs.Add(text);

            dataDir = dataDir + "TextAndImageAsParagraph_out.pdf";
            doc.Save(dataDir);
            // ExEnd:TextAndImageAsParagraph
            Console.WriteLine("\nText and image added successfully as an inline paragraphs.\nFile saved at " + dataDir);
        }
    }
}