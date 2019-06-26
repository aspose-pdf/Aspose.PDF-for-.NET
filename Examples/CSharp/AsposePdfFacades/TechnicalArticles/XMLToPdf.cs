using System.IO;
using System;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class XMLToPdf
    {
        public static void Run()
        {
            // ExStart:XMLToPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            Stream src = new FileStream(dataDir + "log.xml", FileMode.Open, FileAccess.Read);
            Stream dest = new FileStream(dataDir + "XMLToPdf_out.pdf", FileMode.Create, FileAccess.ReadWrite);
            FormDataConverter.ConvertXmlToFdf(src, dest);
            dest.Close();
            src.Close();
            // ExEnd:XMLToPdf                      
        }
    }
}