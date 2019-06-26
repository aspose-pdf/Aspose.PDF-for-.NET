using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class ConcatenatePDFForms
    {
        public static void Run()
        {
            // ExStart:ConcatenatePDFForms
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Set input and output file paths
            string inputFile1 = dataDir + "inFile1.pdf";
            string inputFile2 = dataDir + "inFile2.pdf";
            string outFile = dataDir + "ConcatenatePDFForms_out.pdf";

            // Instantiate PdfFileEditor Object
            PdfFileEditor fileEditor = new PdfFileEditor();
            // To keep unique field Id for all the fields 
            fileEditor.KeepFieldsUnique = true;
            // Format of the suffix which is added to field name to make it unique when forms are concatenated.
            fileEditor.UniqueSuffix = "_%NUM%";

            // Concatenate the files into a resultant Pdf file
            fileEditor.Concatenate(inputFile1, inputFile2, outFile); 
            // ExEnd:ConcatenatePDFForms                      
        }
    }
}