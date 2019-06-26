using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ManipulatePageProperties
{
    public class GetPageProperties
    {
        public static void Run()
        {
            // ExStart:GetPageProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Open document
            PdfPageEditor pageEditor = new PdfPageEditor();
            pageEditor.BindPdf(dataDir + "input.pdf");

            // Get page properties
            Console.WriteLine(pageEditor.GetPageRotation(1));
            Console.WriteLine(pageEditor.GetPages());
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "trim"));
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "art"));
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "bleed"));
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "crop"));
            Console.WriteLine(pageEditor.GetPageBoxSize(1, "media"));
            // ExEnd:GetPageProperties
        }
    }
}