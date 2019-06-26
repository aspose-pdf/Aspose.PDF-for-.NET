using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.TechnicalArticles
{
    public class RemoveFilesFromPortfolio
    {
        public static void Run()
        {
            // ExStart:RemoveFilesFromPortfolio
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_TechnicalArticles();

            // Load source PDF Portfolio
            Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(dataDir + "PDFPortfolio.pdf");
            pdfDocument.Collection.Delete();
            pdfDocument.Save(dataDir + "No_PortFolio_out.pdf");
            // ExEnd:RemoveFilesFromPortfolio                      
        }
    }
}