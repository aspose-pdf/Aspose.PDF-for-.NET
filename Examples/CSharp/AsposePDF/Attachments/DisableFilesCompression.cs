using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments
{
    public class DisableFilesCompression
    {
        public static void Run()
        {
            // ExStart:DisableFilesCompression
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Attachments();

            Document pdfDocument = new Document(dataDir + "GetAlltheAttachments.pdf");
            // Setup new file to be added as attachment
            FileSpecification fileSpecification = new FileSpecification("test_out.txt", "Sample text file");
            // Specify Encoding proparty setting it to FileEncoding.None
            fileSpecification.Encoding = FileEncoding.None;
            // Add attachment to document's attachment collection
            pdfDocument.EmbeddedFiles.Add(fileSpecification);
            dataDir = dataDir + "DisableFilesCompression_out.pdf";
            // Save new output
            pdfDocument.Save(dataDir);
            // ExEnd:DisableFilesCompression
            Console.WriteLine("\nFile compression disabled successfully.\nFile saved at " + dataDir);
        }
    }
}