using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class PdfFileEditorFeatures
    {
        public static void Run()
        {
            // ExStart:PdfFileEditorFeatures
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create instance of PdfFileEditor class
            PdfFileEditor pdfEditor = new PdfFileEditor();

            // Append pages from input file to the port file and save in output file
            int start = 1;
            int end = 3;
            pdfEditor.Append(dataDir + "inFile.pdf", dataDir + "portFile.pdf", start, end, dataDir + "outFile.pdf");

            // Concatenate two files and save in the third one
            pdfEditor.Concatenate(dataDir + "inFile1.pdf", dataDir + "inFile2.pdf", dataDir + "outFile.pdf");

            // Delete specified number of pages from the file
            int[] pages = new int[] { 1, 2, 4, 10 };
            pdfEditor.Delete(dataDir + "inFile.pdf", pages, dataDir + "outFile.pdf");

            // Extract any pages from the file
            start = 0;
            end = 3;
            pdfEditor.OwnerPassword = "ownerpass";
            pdfEditor.Extract(dataDir + "inFile.pdf", start, end, dataDir + "outFile.pdf");

            // Insert pages from another file into the output file at a specified position
            start = 2;
            end = 5;
            pdfEditor.Insert(dataDir + "inFile.pdf", 4, dataDir + "portFile.pdf", start, end, dataDir + "outFile.pdf");

            // Make booklet
            pdfEditor.MakeBooklet(dataDir + "inFile.Pdf", dataDir + "outFile.Pdf");

            // Make N-Ups
            pdfEditor.MakeNUp(dataDir + "inFile.pdf", dataDir + "nupOutFile.pdf", 3, 2);

            // Split the front part of the file
            pdfEditor.SplitFromFirst(dataDir + "inFile.pdf", 3, dataDir + "outFile.pdf");

            // Split the rear part of the file
            pdfEditor.SplitToEnd(dataDir + "inFile.pdf", 3, dataDir + "outFile.pdf");

            // Split to individual pages
            int fileNum = 1;
            MemoryStream[] outBuffer = pdfEditor.SplitToPages(dataDir + "inFile.pdf");
            foreach (MemoryStream aStream in outBuffer)
            {
                FileStream outStream = new FileStream("oneByone" + fileNum.ToString() + ".pdf",
                FileMode.Create);
                aStream.WriteTo(outStream);
                outStream.Close();
                fileNum++;
            }
            
            // Split to several multi-page pdf documents
            fileNum = 1;
            int[][] numberofpage = new int[][] { new int[] { 1, 4 }};
            MemoryStream[] outBuffer2 = pdfEditor.SplitToBulks(dataDir + "inFile.pdf", numberofpage);
            foreach (MemoryStream aStream in outBuffer2)
            {
                FileStream outStream = new FileStream("oneByone" + fileNum.ToString() + ".pdf",
                FileMode.Create);
                aStream.WriteTo(outStream);
                outStream.Close();
                fileNum++;
            }
            // ExEnd:PdfFileEditorFeatures                      
        }
    }
}