using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments
{
    public class GetAlltheAttachments
    {
        public static void Run()
        {
            // ExStart:GetAlltheAttachments
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Attachments();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetAlltheAttachments.pdf");
            
            // Get embedded files collection
            EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
            
            // Get count of the embedded files
            Console.WriteLine("Total files : {0}", embeddedFiles.Count);

            int count = 1;
            
            // Loop through the collection to get all the attachments
            foreach (FileSpecification fileSpecification in embeddedFiles)
            {
                Console.WriteLine("Name: {0}", fileSpecification.Name);
                Console.WriteLine("Description: {0}",
                fileSpecification.Description);
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
                fileSpecification.Contents.Read(fileContent, 0,
                fileContent.Length);
                FileStream fileStream = new FileStream(dataDir + count + "_out" + ".txt",
                FileMode.Create);
                fileStream.Write(fileContent, 0, fileContent.Length);
                fileStream.Close();
                count+=1;
            }
            // ExEnd:GetAlltheAttachments
        }
    }
}