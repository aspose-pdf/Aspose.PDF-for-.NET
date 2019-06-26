using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class ImportDataFromPdf
    {
        public static void Run()
        {
            // ExStart:ImportDataFromPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form();
            // Open Document
            form.BindPdf(dataDir + "input.pdf");

            // Open fdf file.
            System.IO.FileStream fdfInputStream = new FileStream(dataDir + "student.fdf", FileMode.Open);

            // Import data
            form.ImportFdf(fdfInputStream);

            // Close file stream
            fdfInputStream.Close();

            // Save updated document
            form.Save(dataDir + "ImportDataFromPdf_out.pdf");
            // ExEnd:ImportDataFromPdf
        }        
    }
}