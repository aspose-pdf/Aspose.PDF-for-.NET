using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class TeXToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:TeXToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
                // Instantiate Latex Load option object
                LatexLoadOptions Latexoptions = new LatexLoadOptions();
                // Create Document object
                Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "samplefile.tex", Latexoptions);
                // Save the output in PDF file
                doc.Save(dataDir + "TeXToPDF_out.pdf");
                // ExEnd:TeXToPDF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}