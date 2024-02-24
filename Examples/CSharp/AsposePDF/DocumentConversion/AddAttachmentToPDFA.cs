using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class AddAttachmentToPDFA
    {
        public static void Run()
        {
            // ExStart:AddAttachmentToPDFA
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Instantiate Document instance to load existing file
            Aspose.Pdf.Document doc = new Document(dataDir + "input.pdf");
            // Setup new file to be added as attachment
            using (FileSpecification fileSpecification = new FileSpecification(dataDir + "aspose-logo.jpg", "Large Image file"))
            {
                // Add attachment to document's attachment collection
                doc.EmbeddedFiles.Add(fileSpecification);
                // Perform conversion to PDF/A_3a so attachment is included in resultant file
                doc.Convert(dataDir + "log.txt", Aspose.Pdf.PdfFormat.PDF_A_3A, ConvertErrorAction.Delete);
                // Save resultant file
                doc.Save(dataDir + "AddAttachmentToPDFA_out.pdf");
                // ExEnd:AddAttachmentToPDFA
                Console.WriteLine("\nAttachment added successfully to PDF/A file.\nFile saved at " + dataDir);
            }
        }
    }
}