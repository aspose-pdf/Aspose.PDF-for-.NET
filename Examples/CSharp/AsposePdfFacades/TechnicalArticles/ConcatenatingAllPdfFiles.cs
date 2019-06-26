using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class ConcatenatingAllPdfFiles
    {
        public static void Run()
        {
            // ExStart:ConcatenatingAllPdfFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Retrieve names of all the Pdf files in a particular Directory
            string[] fileEntries = Directory.GetFiles(dataDir, "*.pdf");

            // Get the current System date and set its format
            string date = DateTime.Now.ToString("MM-dd-yyyy");
            // Get the current System time and set its format
            string hoursSeconds = DateTime.Now.ToString("hh-mm");
            // Set the value for the final Resultant Pdf document
            string masterFileName = date + "_" + hoursSeconds + "_out.pdf";

            // Instantiate PdfFileEditor object
            Aspose.Pdf.Facades.PdfFileEditor pdfEditor = new PdfFileEditor();

            // Call Concatenate method of PdfFileEditor object to concatenate all input files
            // Into a single output file
            pdfEditor.Concatenate(fileEntries, dataDir + masterFileName);
            // ExEnd:ConcatenatingAllPdfFiles                      
        }
    }
}