using System.IO;
using System;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class ConcatenateMultiplePDFUsingMemoryStream
    {
        public static void Run()
        {
            // ExStart:ConcatenateMultiplePDFUsingMemoryStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create two file streams to read pdf files
            FileStream fs1 = new FileStream(dataDir + "inFile.pdf", FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(dataDir + "inFile2.pdf", FileMode.Open, FileAccess.Read);

            // Create byte arrays to keep the contents of PDF files
            byte[] buffer1 = new byte[Convert.ToInt32(fs1.Length)];
            byte[] buffer2 = new byte[Convert.ToInt32(fs2.Length)];


            int i = 0;
            // Read PDF file contents into byte arrays
            i = fs1.Read(buffer1, 0, Convert.ToInt32(fs1.Length));
            i = fs2.Read(buffer2, 0, Convert.ToInt32(fs2.Length));

            // Now, first convert byte arrays into MemoryStreams and then concatenate those streams
            using (MemoryStream pdfStream = new MemoryStream())
            {
                using (MemoryStream fileStream1 = new MemoryStream(buffer1))
                {
                    using (MemoryStream fileStream2 = new MemoryStream(buffer2))
                    {
                        // Create instance of PdfFileEditor class to concatenate streams
                        PdfFileEditor pdfEditor = new PdfFileEditor();
                        // Concatenate both input MemoryStreams and save to putput MemoryStream
                        pdfEditor.Concatenate(fileStream1, fileStream2, pdfStream);
                        // Convert MemoryStream back to byte array
                        byte[] data = pdfStream.ToArray();
                        // Create a FileStream to save the output PDF file
                        FileStream output = new FileStream(dataDir + "merged_out.pdf", FileMode.Create,
                        FileAccess.Write);
                        // Write byte array contents in the output file stream
                        output.Write(data, 0, data.Length);
                        // Close output file
                        output.Close();
                    }
                }
            }
            // Close input files
            fs1.Close();
            fs2.Close();
            // ExEnd:ConcatenateMultiplePDFUsingMemoryStream                      
        }
    }
}