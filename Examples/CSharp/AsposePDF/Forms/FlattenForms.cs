using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class FlattenForms
    {
        public static void Run()
        {
            // ExStart:FlattenForms
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load source PDF form
            Document doc = new Document(dataDir + "input.pdf");

            // Flatten Forms
            if (doc.Form.Fields.Count() > 0)
            {
                foreach (var item in doc.Form.Fields)
                {
                    item.Flatten();
                }
            }

            dataDir = dataDir + "FlattenForms_out.pdf";
            // Save the updated document
            doc.Save(dataDir);
            // ExEnd:FlattenForms   
            Console.WriteLine("\nForms flattened successfully.\nFile saved at " + dataDir);
        }
    }
}
