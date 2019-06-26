using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ExtractTextPage
    {
        public static void Run()
        {
            // ExStart:ExtractTextPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "ExtractTextPage.pdf");

            // Create TextAbsorber object to extract text
            TextAbsorber textAbsorber = new TextAbsorber();
  
            // Accept the absorber for a particular page
            pdfDocument.Pages[1].Accept(textAbsorber);
            
            // Get the extracted text
            string extractedText = textAbsorber.Text;

            dataDir = dataDir + "extracted-text_out.txt";
            // Create a writer and open the file
            TextWriter tw = new StreamWriter(dataDir);
            
            // Write a line of text to the file
            tw.WriteLine(extractedText);
            
            // Close the stream
            tw.Close();
            // ExEnd:ExtractTextPage            
            Console.WriteLine("\nText extracted successfully from Pages of PDF Document.\nFile saved at " + dataDir);
        }
    }
}