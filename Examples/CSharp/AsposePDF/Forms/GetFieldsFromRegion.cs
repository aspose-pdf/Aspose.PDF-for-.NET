using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Forms;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class GetFieldsFromRegion
    {
        public static void Run()
        {
            // ExStart:GetFieldsFromRegion
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open pdf file
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "GetFieldsFromRegion.pdf");

            // Create rectangle object to get fields in that area
            Aspose.Pdf.Rectangle rectangle = new Aspose.Pdf.Rectangle(35, 30, 500, 500);

            // Get the PDF form
           Aspose.Pdf.Forms.Form form = doc.Form;

            // Get fields in the rectangular area
           Aspose.Pdf.Forms.Field[] fields = form.GetFieldsInRect(rectangle);

            // Display Field names and values
            foreach (Field field in fields)
            {
                // Display image placement properties for all placements
                Console.Out.WriteLine("Field Name: " + field.FullName + "-" + "Field Value: " + field.Value);
            }
            // ExEnd:GetFieldsFromRegion
        }
    }
}