using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToDOC
    {
        public static void Run()
        {
            // ExStart:PDFToDOC
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();          
            
            // Open the source PDF document
            Document pdfDocument = new Document(dataDir + "PDFToDOC.pdf");

            // Save the file into MS document format
            pdfDocument.Save(dataDir + "PDFToDOC_out.doc", SaveFormat.Doc);
            // ExEnd:PDFToDOC        
            
        }
        public  static void SaveUsingSaveOptions()
        {
            // ExStart:SaveUsingSaveOptions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();           
          
            // Open the source PDF document
            Document pdfDocument = new Document(dataDir + "PDFToDOC.pdf");            

            // Save using save options
            // Create DocSaveOptions object
            DocSaveOptions saveOptions = new DocSaveOptions();

            // Set the recognition mode as Flow
            saveOptions.Mode = DocSaveOptions.RecognitionMode.Flow;

            // Set the Horizontal proximity as 2.5
            saveOptions.RelativeHorizontalProximity = 2.5f;

            // Enable the value to recognize bullets during conversion process
            saveOptions.RecognizeBullets = true;

            // Save the resultant DOC file
            pdfDocument.Save(dataDir + "saveOptionsOutput_out.doc", saveOptions);
            // ExEnd:SaveUsingSaveOptions
        }
        public static void ConvertToDOCX()
        {
            // ExStart:ConvertToDOCX
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Open the source PDF document
            Document pdfDocument = new Document(dataDir + "PDFToDOC.pdf");

            // Instantiate DocSaveOptions object
            DocSaveOptions saveOptions = new DocSaveOptions();
            // Specify the output format as DOCX
            saveOptions.Format = DocSaveOptions.DocFormat.DocX;
            // Save document in docx format
            pdfDocument.Save("ConvertToDOCX_out.docx", saveOptions);
            // ExEnd:ConvertToDOCX
        }
    }
}