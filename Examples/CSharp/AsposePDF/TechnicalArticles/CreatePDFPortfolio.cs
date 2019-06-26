using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.TechnicalArticles
{
    public class CreatePDFPortfolio
    {
        public static void Run()
        {
            // ExStart:CreatePDFPortfolio
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_TechnicalArticles();

            // Instantiate Document Object
            Document doc = new Document();

            // Instantiate document Collection object
            doc.Collection = new Collection();

            // Get Files to add to Portfolio
            FileSpecification excel = new FileSpecification( dataDir + "HelloWorld.xlsx");
            FileSpecification word = new FileSpecification( dataDir + "HelloWorld.docx");
            FileSpecification image = new FileSpecification(dataDir + "aspose-logo.jpg");

            // Provide description of the files
            excel.Description = "Excel File";
            word.Description = "Word File";
            image.Description = "Image File";

            // Add files to document collection
            doc.Collection.Add(excel);
            doc.Collection.Add(word);
            doc.Collection.Add(image);

            // Save Portfolio document
            doc.Save(dataDir + "CreatePDFPortfolio_out.pdf");
            // ExEnd:CreatePDFPortfolio                      
        }
    }
}