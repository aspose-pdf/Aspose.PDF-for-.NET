using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class SetXMPMetadata
    {
        public static void Run()
        {
            // ExStart:SetXMPMetadata
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "SetXMPMetadata.pdf");

            // Set properties
            pdfDocument.Metadata["xmp:CreateDate"] = DateTime.Now;
            pdfDocument.Metadata["xmp:Nickname"] = "Nickname";
            pdfDocument.Metadata["xmp:CustomProperty"] = "Custom Value";

            dataDir = dataDir + "SetXMPMetadata_out.pdf";
            // Save document
            pdfDocument.Save(dataDir);
            // ExEnd:SetXMPMetadata
            Console.WriteLine("\nXMP metadata in a pdf file setup successfully.\nFile saved at " + dataDir);
        }
        public static void SetPrefixMetadata()
        {
            // ExStart:SetPrefixMetadata
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "SetXMPMetadata.pdf");
            pdfDocument.Metadata.RegisterNamespaceUri("xmp", "http:// Ns.adobe.com/xap/1.0/"); // Xmlns prefix was removed
            pdfDocument.Metadata["xmp:ModifyDate"] = DateTime.Now;

            dataDir = dataDir + "SetPrefixMetadata_out.pdf";
            // Save document
            pdfDocument.Save(dataDir);
            // ExEnd:SetPrefixMetadata

        }
    }
}