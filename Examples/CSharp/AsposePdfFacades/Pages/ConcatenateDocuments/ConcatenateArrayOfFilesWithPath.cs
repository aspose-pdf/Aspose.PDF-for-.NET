using System.IO;
using System.Web;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ConcatenateDocuments
{
    public class ConcatenateArrayOfFilesWithPath
    {
        public static void Run()
        {
            // ExStart:ConcatenateArrayOfFilesWithPath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Array of files
            string[] filesArray = new string[2];
            filesArray[0] =  dataDir + "input.pdf";
            filesArray[1] = dataDir + "input2.pdf";
            // Concatenate files
            pdfEditor.Concatenate(filesArray, dataDir + "ConcatenateArrayOfFilesWithPath_out.pdf");
            // ExEnd:ConcatenateArrayOfFilesWithPath
        }
        public static void RenderInBrowser()
        {
            // ExStart:RenderInBrowser
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();
     
            // Array of files
            string[] filesArray = new string[2];
            filesArray[0] = dataDir + "input.pdf";
            filesArray[1] = dataDir + "input2.pdf";
            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Display the resultant concatenated PDF file in 
            pdfEditor.Concatenate(filesArray, dataDir + "RenderInBrowser_out.pdf");
            // ExEnd:RenderInBrowser
        }

        public static void CorruptedFiles()
        {
            // ExStart:CorruptedFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            Aspose.Pdf.Facades.PdfFileEditor pfe = new Aspose.Pdf.Facades.PdfFileEditor();
            pfe.CorruptedFileAction = Aspose.Pdf.Facades.PdfFileEditor.ConcatenateCorruptedFileAction.ConcatenateIgnoringCorrupted;
            pfe.Concatenate(new string[] { dataDir + "input.pdf", dataDir + "input2.pdf", dataDir + "input3.pdf" }, dataDir + "CorruptedFiles_out.pdf");
            if (pfe.CorruptedItems.Length > 0)
            {
                Console.WriteLine("Corrupted documents:");
                foreach (Aspose.Pdf.Facades.PdfFileEditor.CorruptedItem item in pfe.CorruptedItems)
                { Console.WriteLine(item.Index + " reason " + item.Exception.Message); }
            }

            else Console.WriteLine("No corrupted documents"); 
            // ExEnd:CorruptedFiles
        }
    }
}