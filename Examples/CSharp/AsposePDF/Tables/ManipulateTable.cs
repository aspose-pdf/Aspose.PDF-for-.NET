using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class ManipulateTable
    {
        public static void Run()
        {
            try
            {
                // ExStart:ManipulateTable
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

                // Load existing PDF file
                Document pdfDocument = new Document(dataDir + "input.pdf");
                // Create TableAbsorber object to find tables
                TableAbsorber absorber = new TableAbsorber();

                // Visit first page with absorber
                absorber.Visit(pdfDocument.Pages[1]);

                // Get access to first table on page, their first cell and text fragments in it
                TextFragment fragment = absorber.TableList[0].RowList[0].CellList[0].TextFragments[1];

                // Change text of the first text fragment in the cell
                fragment.Text = "hi world";
                dataDir = dataDir + "ManipulateTable_out.pdf";
                pdfDocument.Save(dataDir);
                // ExEnd:ManipulateTable
                Console.WriteLine("\nTable manipulated successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}