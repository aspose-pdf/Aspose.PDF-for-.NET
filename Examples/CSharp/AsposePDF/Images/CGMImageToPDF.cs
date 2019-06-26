using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class CGMImageToPDF
    {
        public static void Run()
        {
            // ExStart:CGMImageToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            string inputFile = dataDir + "corvette.cgm";
            dataDir = dataDir + "CGMImageToPDF_out.pdf";
            // Save CGM into PDF format
            PdfProducer.Produce(inputFile, ImportFormat.Cgm, dataDir);
            // ExEnd:CGMImageToPDF
            Console.WriteLine("\nCGM file converted to pdf successfully.\nFile saved at " + dataDir); 
            
        }
        
    }
}