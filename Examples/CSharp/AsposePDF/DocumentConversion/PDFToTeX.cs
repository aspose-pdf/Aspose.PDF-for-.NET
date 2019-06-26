using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToTeX
    {
        public static void Run()
        {
            // ExStart:PDFToTeX
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Create Document object
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "PDFToTeX.pdf");

            // Instantiate LaTex save option            
            LaTeXSaveOptions saveOptions = new LaTeXSaveOptions();

            // Specify the output directory 
            string pathToOutputDirectory = dataDir;

            // Set the output directory path for save option object
            saveOptions.OutDirectoryPath = pathToOutputDirectory;

            // Save PDF file into LaTex format            
            doc.Save(dataDir + "PDFToTeX_out.tex", saveOptions);
            // ExEnd:PDFToTeX
        }
    }
}