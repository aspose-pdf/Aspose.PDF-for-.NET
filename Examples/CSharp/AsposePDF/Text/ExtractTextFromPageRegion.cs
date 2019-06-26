using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ExtractTextFromPageRegion
    {
        public static void Run()
        {
            // ExStart:ExtractTextFromPageRegion
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "ExtractTextAll.pdf");

            // Create TextAbsorber object to extract text
            TextAbsorber absorber = new TextAbsorber();
            absorber.TextSearchOptions.LimitToPageBounds = true;
            absorber.TextSearchOptions.Rectangle = new Aspose.Pdf.Rectangle(100, 200, 250, 350);

            // Accept the absorber for first page
            pdfDocument.Pages[1].Accept(absorber);

            // Get the extracted text
            string extractedText = absorber.Text;
            // Create a writer and open the file
            TextWriter tw = new StreamWriter(dataDir + "extracted-text.txt");
            // Write a line of text to the file
            tw.WriteLine(extractedText);
            // Close the stream
            tw.Close();
            // ExEnd:ExtractTextFromPageRegion          
            
        }
    }
}