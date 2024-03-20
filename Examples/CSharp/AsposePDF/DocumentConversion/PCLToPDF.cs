using System;
using System.Drawing.Text;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PCLToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:PCLToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

                // Instantiate LoadOption object using PCL load option
                Aspose.Pdf.LoadOptions loadopt = new Aspose.Pdf.PclLoadOptions();

                // Create Document object
                Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "hidetext.pcl", loadopt);

                // Save the resultant PDF document
                doc.Save(dataDir + "PCLToPDF_out.pdf");
                // ExEnd:PCLToPDF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void PCLstream()
        {
            // ExStart:PCLstream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            using (FileStream fileStream = new FileStream(dataDir + "sample.pcl", FileMode.Open))
            using (MemoryStream memoryStream = new MemoryStream())
            {
                PclLoadOptions pclLoadOptions = new PclLoadOptions
                {
                    ConversionEngine = PclLoadOptions.ConversionEngines.LegacyEngine
                };
                fileStream.CopyTo(memoryStream);

                memoryStream.Seek(0, SeekOrigin.Begin);

                using (Document document = new Document(memoryStream, pclLoadOptions))
                {
                    Console.WriteLine(document.Pages.Count);
                }
            }
            // ExEnd:PCLstream
        }
    }
}