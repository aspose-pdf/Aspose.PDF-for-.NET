using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class ReplaceMissingFonts
    {
        public static void Run()
        {
            // ExStart:ReplaceMissingFonts
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            Aspose.Pdf.Text.Font originalFont = null;
            try
            {
                originalFont = FontRepository.FindFont("AgencyFB");
            }
            catch (Exception)
            {
                // Font is missing on destination machine
                FontRepository.Substitutions.Add(new SimpleFontSubstitution("AgencyFB", "Arial"));
            }
            var fileNew = new FileInfo(dataDir + "newfile_out.pdf");
            var pdf = new Document(dataDir + "input.pdf");
            pdf.Convert( dataDir +  "log.xml", PdfFormat.PDF_A_1B, ConvertErrorAction.Delete);
            pdf.Save(fileNew.FullName);
            // ExEnd:ReplaceMissingFonts
        }
    }
}