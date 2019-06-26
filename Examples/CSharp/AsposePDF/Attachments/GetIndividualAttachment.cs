using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments
{
    public class GetIndividualAttachment
    {
        public static void Run()
        {
            // ExStart:GetIndividualAttachment
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Attachments();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetIndividualAttachment.pdf");

            // Get particular embedded file
            FileSpecification fileSpecification = pdfDocument.EmbeddedFiles[1];
            
            // Get the file properties
            Console.WriteLine("Name: {0}", fileSpecification.Name);
            Console.WriteLine("Description: {0}", fileSpecification.Description);
            Console.WriteLine("Mime Type: {0}", fileSpecification.MIMEType);
            
            // Check if parameter object contains the parameters
            if (fileSpecification.Params != null)
            {
                Console.WriteLine("CheckSum: {0}",
                fileSpecification.Params.CheckSum);
                Console.WriteLine("Creation Date: {0}",
                fileSpecification.Params.CreationDate);
                Console.WriteLine("Modification Date: {0}",
                fileSpecification.Params.ModDate);
                Console.WriteLine("Size: {0}", fileSpecification.Params.Size);
            }

            
            // Get the attachment and write to file or stream
            byte[] fileContent = new byte[fileSpecification.Contents.Length];
            fileSpecification.Contents.Read(fileContent, 0, fileContent.Length);

            FileStream fileStream = new FileStream(dataDir + "test_out" + ".txt", FileMode.Create);
            fileStream.Write(fileContent, 0, fileContent.Length);
            fileStream.Close();
            // ExEnd:GetIndividualAttachment
        }
    }
}