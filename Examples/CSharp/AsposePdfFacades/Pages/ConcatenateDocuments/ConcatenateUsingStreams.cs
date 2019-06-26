using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ConcatenateDocuments
{
    public class ConcatenateUsingStreams
    {
        public static void Run()
        {
            // ExStart:ConcatenateUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Output stream
            FileStream outputStream = new FileStream( dataDir + "ConcatenateUsingStreams_out.pdf", FileMode.Create);
            // Input streams
            FileStream inputStream1 = new FileStream( dataDir + "input.pdf", FileMode.Open);
            FileStream inputStream2 = new FileStream( dataDir + "input2.pdf", FileMode.Open);
            // Concatenate file
            pdfEditor.Concatenate(inputStream1, inputStream2, outputStream);
            // ExEnd:ConcatenateUsingStreams
        }
        public static void ConcatenateTaggedFiles()
        {
            // ExStart:ConcatenateTaggedFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            FileStream fileInputStream1 = new FileStream(dataDir + "input.pdf", FileMode.Open, FileAccess.Read);
            FileStream fileInputStream2 = new FileStream(dataDir + "input2.pdf", FileMode.Open, FileAccess.Read);
            FileStream fileOutputStream = new FileStream(dataDir + "ConcatenateTaggedFiles_out.pdf" , FileMode.Create, FileAccess.Write);
            // Concatenate files
            PdfFileEditor editor = new PdfFileEditor();
            editor.CopyLogicalStructure = true;
            bool success = editor.Concatenate(fileInputStream1, fileInputStream2, fileOutputStream);
            Console.Out.WriteLine("Successful... " + success);
            // Close the streams
            fileOutputStream.Close();
            fileInputStream1.Close();
            fileInputStream2.Close();

            // ExEnd:ConcatenateTaggedFiles
 
        }
    }
}