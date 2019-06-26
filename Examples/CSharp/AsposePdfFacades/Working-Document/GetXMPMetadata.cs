using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.WorkingDocument
{
    public class GetXMPMetadata
    {
        public static void Run()
        {
            // ExStart:GetXMPMetadata
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();

            // Create PdfXmpMetadata object
            PdfXmpMetadata xmpMetaData = new PdfXmpMetadata();

            // Bind pdf file to the object
            xmpMetaData.BindPdf( dataDir + "input.pdf");

            // Get XMP Meta Data properties
            Console.WriteLine(": {0}", xmpMetaData[DefaultMetadataProperties.CreateDate].ToString());
            Console.WriteLine(": {0}", xmpMetaData[DefaultMetadataProperties.MetadataDate].ToString());
            Console.WriteLine(": {0}", xmpMetaData[DefaultMetadataProperties.CreatorTool].ToString());
            Console.WriteLine(": {0}", xmpMetaData["customNamespace:UserPropertyName"].ToString());

            Console.ReadLine();
            // ExEnd:GetXMPMetadata
        }
    }
}