using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class ImportDataFromXFDF
    {
        public static void Run()
        {
            // ExStart:ImportDataFromXFDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form();
            // Open Document
            form.BindPdf(dataDir + "input.pdf");

            // Open xfdf file.
            System.IO.FileStream xfdfInputStream = new FileStream("student1.xfdf", FileMode.Open);

            // Import data
            form.ImportXfdf(xfdfInputStream);

            // Close file stream
            xfdfInputStream.Close();

            // Save updated document
            form.Save(dataDir + "ImportDataFromXFDF_out.pdf");
            // ExEnd:ImportDataFromXFDF
        }        
    }
}