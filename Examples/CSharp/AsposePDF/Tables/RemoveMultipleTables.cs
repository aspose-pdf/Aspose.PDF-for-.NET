using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class RemoveMultipleTables
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Load existing PDF document
            Document pdfDocument = new Document(dataDir + "Table_input2.pdf");

            // Create TableAbsorber object to find tables
            TableAbsorber absorber = new TableAbsorber();

            // Visit second page with absorber
            absorber.Visit(pdfDocument.Pages[1]);

            // Get copy of table collection
            AbsorbedTable[] tables = new AbsorbedTable[absorber.TableList.Count];
            absorber.TableList.CopyTo(tables, 0);

            // Loop through the copy of collection and removing tables
            foreach (AbsorbedTable table in tables)
                absorber.Remove(table);

            // Save document
            pdfDocument.Save(dataDir + "Table2_out.pdf");
            // ExEnd:1
        }
    }
}
