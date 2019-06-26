using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ExtractColumnsText
    {
        public static void Run()
        {
            // ExStart:ExtractColumnsText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "ExtractTextPage.pdf");                

            TextFragmentAbsorber tfa = new TextFragmentAbsorber();
            pdfDocument.Pages.Accept(tfa);
            TextFragmentCollection tfc = tfa.TextFragments;
            foreach (TextFragment tf in tfc)
            {
                // Need to reduce font size at least for 70%
                tf.TextState.FontSize = tf.TextState.FontSize * 0.7f;
            }
            Stream st = new MemoryStream();
            pdfDocument.Save(st);
            pdfDocument = new Document(st);
            TextAbsorber textAbsorber = new TextAbsorber();
            pdfDocument.Pages.Accept(textAbsorber);
            String extractedText = textAbsorber.Text;
            textAbsorber.Visit(pdfDocument); 

            dataDir = dataDir + "ExtractColumnsText_out.txt";

            System.IO.File.WriteAllText(dataDir, extractedText);           
            // ExEnd:ExtractColumnsText            
            Console.WriteLine("\nColumns text extracted successfully from Pages of PDF Document.\nFile saved at " + dataDir);
        }
        public static void UsingScaleFactor()
        {
            // ExStart:UsingScaleFactor
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "ExtractTextPage.pdf");

            TextAbsorber textAbsorber = new TextAbsorber();
            textAbsorber.ExtractionOptions = new TextExtractionOptions(TextExtractionOptions.TextFormattingMode.Pure);
            // Setting scale factor to 0.5 is enough to split columns in the majority of documents
            // Setting of zero allows to algorithm choose scale factor automatically
            textAbsorber.ExtractionOptions.ScaleFactor = 0.5; /* 0; */
            pdfDocument.Pages.Accept(textAbsorber);
            String extractedText = textAbsorber.Text;
            System.IO.File.WriteAllText( dataDir + "ExtractTextUsingScaleFactor_out.text", extractedText);
            // ExEnd:UsingScaleFactor
        }
    }
}