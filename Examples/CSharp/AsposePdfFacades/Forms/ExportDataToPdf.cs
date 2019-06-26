using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class ExportDataToPdf
    {
        public static void Run()
        {
            // ExStart:ExportDataToPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form();
            // Open Document
            form.BindPdf(dataDir + "input.pdf");

            // Create fdf file.
            System.IO.FileStream fdfOutputStream = new FileStream(dataDir + "student.fdf", FileMode.Create);

            // Export data
            form.ExportFdf(fdfOutputStream);

            // Close file stream
            fdfOutputStream.Close();

            // Save updated document
            form.Save(dataDir + "ExportDataToPdf_out.pdf"); 
            // ExEnd:ExportDataToPdf
        }        
    }
}