using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments
{
    public class AddAttachment
    {
        public static void Run()
        {
            // ExStart:AddAttachment
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Attachments();

            // Open document
            Document pdfDocument = new Document(dataDir + "AddAttachment.pdf");

            // Setup new file to be added as attachment
            FileSpecification fileSpecification = new FileSpecification(dataDir + "test.txt", "Sample text file");

            // Add attachment to document's attachment collection
            pdfDocument.EmbeddedFiles.Add(fileSpecification);

            dataDir = dataDir + "AddAttachment_out.pdf";

            // Save new output
            pdfDocument.Save(dataDir);
            // ExEnd:AddAttachment
            Console.WriteLine("\nSample text file attached successfully.\nFile saved at " + dataDir);
        }
    }
}