using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class XPSToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:XPSToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

                // Instantiate LoadOption object using XPS load option
                Aspose.Pdf.LoadOptions options = new XpsLoadOptions();

                // Create document object 
                Aspose.Pdf.Document document = new Aspose.Pdf.Document(dataDir + "XPSToPDF.xps", options);

                // Save the resultant PDF document
                document.Save(dataDir + "XPSToPDF_out.pdf");
                // ExEnd:XPSToPDF
            }
            catch(Exception ex)
               
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}