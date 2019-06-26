using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class ConvertPdfToXML
    {
        public static void Run()
        {
            // ExStart:ConvertPdfToXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create a file stream for FDF file - input file
            System.IO.FileStream fdfInputStream = new FileStream(dataDir + "inFile.pdf", FileMode.Open);
            // Create a file stream for XML file - output file
            System.IO.FileStream xmlOutputStream = new FileStream(dataDir + "ConvertPdfToXML_out.xml", FileMode.Create);
            // Create a file stream for XML file - output file
            FormDataConverter.ConvertFdfToXml(fdfInputStream, xmlOutputStream);
            // ExEnd:ConvertPdfToXML                      
        }
    }
}