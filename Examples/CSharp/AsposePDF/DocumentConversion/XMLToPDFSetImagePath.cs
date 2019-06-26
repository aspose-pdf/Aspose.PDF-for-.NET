using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class XMLToPDFSetImagePath
    {
        public static void Run()
        {
            try
            {
                // ExStart:1
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
                string inXml = dataDir + "input.xml";
                string inFile = dataDir + "aspose-logo.jpg";
                string outFile = dataDir + "output_out.pdf";
                Document doc = new Document();
                doc.BindXml(inXml);
                Image image = (Image)doc.GetObjectById("testImg");
                image.File = inFile;
                doc.Save(outFile);
                // ExEnd:1
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
