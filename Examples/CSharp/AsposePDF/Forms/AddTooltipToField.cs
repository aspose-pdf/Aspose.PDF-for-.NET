using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class AddTooltipToField
    {
        public static void Run()
        {
            // ExStart:AddTooltipToField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load source PDF form
            Document doc = new Document(dataDir + "AddTooltipToField.pdf");

            // Set the tooltip for textfield
            (doc.Form["textbox1"] as Field).AlternateName = "Text box tool tip";

            dataDir = dataDir + "AddTooltipToField_out.pdf";
            // Save the updated document
            doc.Save(dataDir);
            // ExEnd:AddTooltipToField   
            Console.WriteLine("\nTooltip added successfully.\nFile saved at " + dataDir);
        }
    }
}