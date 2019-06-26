using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class TextToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:TextToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
                // Read the source text file
                TextReader tr = new StreamReader(dataDir + "log.txt");

                // Instantiate a Document object by calling its empty constructor
                Document doc = new Document();

                // Add a new page in Pages collection of Document
                Page page = doc.Pages.Add();

                // Create an instance of TextFragmet and pass the text from reader object to its constructor as argument
                TextFragment text = new TextFragment(tr.ReadToEnd());
                // Text.TextState.Font = FontRepository.FindFont("Arial Unicode MS");

                // Add a new text paragraph in paragraphs collection and pass the TextFragment object
                page.Paragraphs.Add(text);

                // Save resultant PDF file
                doc.Save(dataDir + "TexttoPDF_out.pdf"); 
                // ExEnd:TextToPDF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}