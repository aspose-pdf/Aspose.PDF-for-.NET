using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class PrefixCSSClassNames
    {
        public static void Run()
        {
            try
            {
                // ExStart:PrefixCSSClassNames
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                Document pdfDocument = new Document(dataDir + "input.pdf");
                string outHtmlFile = dataDir + "PrefixCSSClassNames_out.html";
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                saveOptions.CssClassNamesPrefix = ".gDV__ .stl_";
                pdfDocument.Save(outHtmlFile, saveOptions);
                // ExEnd:PrefixCSSClassNames
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}