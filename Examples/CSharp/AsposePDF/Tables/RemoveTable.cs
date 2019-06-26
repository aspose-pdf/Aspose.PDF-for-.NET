using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class RemoveTable
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Load existing PDF document
            Document pdfDocument = new Document(dataDir + "Table_input.pdf");

            // Create TableAbsorber object to find tables
            TableAbsorber absorber = new TableAbsorber();

            // Visit first page with absorber
            absorber.Visit(pdfDocument.Pages[1]);

            // Get first table on the page
            AbsorbedTable table = absorber.TableList[0];

            // Remove the table
            absorber.Remove(table);

            // Save PDF
            pdfDocument.Save(dataDir + "Table_out.pdf");
            // ExEnd:1
        }
    }
}
