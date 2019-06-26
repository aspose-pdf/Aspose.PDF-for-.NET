using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ManipulatePageProperties
{
    public class ResizePageContents
    {
        public static void Run()
        {
            // ExStart:ResizePageContents
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor Object
            PdfFileEditor fileEditor = new PdfFileEditor();

            // Open PDF Document
            Document doc = new Document(dataDir + "input.pdf");

            // Specify Parameter to be used for resizing
            PdfFileEditor.ContentsResizeParameters parameters = new PdfFileEditor.ContentsResizeParameters(
            // Left margin = 10% of page width
            PdfFileEditor.ContentsResizeValue.Percents(10),
            // New contents width calculated automatically as width - left margin - right margin (100% - 10% - 10% = 80%)
            null,
            // Right margin is 10% of page
            PdfFileEditor.ContentsResizeValue.Percents(10),
            // Top margin = 10% of height
            PdfFileEditor.ContentsResizeValue.Percents(10),
            // New contents height is calculated automatically (similar to width)
            null,
            // Bottom margin is 10%
            PdfFileEditor.ContentsResizeValue.Percents(10)
            );

            // Resize Page Contents
            fileEditor.ResizeContents(doc, new int[] { 1, 2 }, parameters);

            // Save document into new location.
            doc.Save(dataDir + "ResizePageContents_out.pdf");
            // ExEnd:ResizePageContents
        }
    }
}