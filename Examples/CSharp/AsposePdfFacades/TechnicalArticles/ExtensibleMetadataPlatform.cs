using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class ExtensibleMetadataPlatform
    {
        public static void Run()
        {
            // ExStart:ExtensibleMetadataPlatform
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create an object of PdfXmpMetadata class
            Aspose.Pdf.Facades.PdfXmpMetadata xmpMetaData = new Aspose.Pdf.Facades.PdfXmpMetadata();

            // Create input and output file streams
            FileStream input = new FileStream(dataDir + "FilledForm.pdf", FileMode.Open);

            FileStream output = new FileStream(dataDir + "xmp_out.pdf", FileMode.Create);
             
            // Set input file stream
            xmpMetaData.BindPdf(input);

            // Add base URL property to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.BaseURL, "xmlns:pdf=http:// Ns.adobe.com/pdf/1.3/");

            // Add creation date property to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.CreateDate, System.DateTime.Now.ToString());

            // Add Metadata Date property to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.MetadataDate, System.DateTime.Now.ToString());

            // Add Creator Tool property to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.CreatorTool, "Creator Tool Name");

            // Add Modify Date to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.ModifyDate, System.DateTime.Now.ToString());

            // Add Nick Name to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.Nickname, "Test");

            // Save xmp meta data in the pdf file
            xmpMetaData.Save(output);

            // Close input and output file streams
            input.Close();
            output.Close();
            // ExEnd:ExtensibleMetadataPlatform                      
        }
    }
}