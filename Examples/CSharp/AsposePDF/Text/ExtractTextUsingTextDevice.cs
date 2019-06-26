using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Devices;
using System;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ExtractTextUsingTextDevice
    {
        public static void Run()
        {
            // ExStart:ExtractTextUsingTextDevice
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document( dataDir + "input.pdf");
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            // String to hold extracted text
            string extractedText = "";

            foreach (Page pdfPage in pdfDocument.Pages)
            {
                using (MemoryStream textStream = new MemoryStream())
                {
                    // Create text device
                    TextDevice textDevice = new TextDevice();

                    // Set text extraction options - set text extraction mode (Raw or Pure)
                    TextExtractionOptions textExtOptions = new
                    TextExtractionOptions(TextExtractionOptions.TextFormattingMode.Pure);
                    textDevice.ExtractionOptions = textExtOptions;

                    // Convert a particular page and save text to the stream
                    textDevice.Process(pdfPage, textStream);
                    // ExStart:SaveTextToStream
                    // Convert a particular page and save text to the stream
                    textDevice.Process(pdfDocument.Pages[1], textStream);
                    // ExEnd:SaveTextToStream

                    // Close memory stream
                    textStream.Close();

                    // Get text from memory stream
                    extractedText = Encoding.Unicode.GetString(textStream.ToArray());
                }
                builder.Append(extractedText);
            }

            dataDir = dataDir + "input_Text_Extracted_out.txt";
            // Save the extracted text in text file
            File.WriteAllText(dataDir, builder.ToString());
            // ExEnd:ExtractTextUsingTextDevice            
            Console.WriteLine("\nText extracted successfully using text device from page of PDF Document.\nFile saved at " + dataDir);
        }
   
    }
}