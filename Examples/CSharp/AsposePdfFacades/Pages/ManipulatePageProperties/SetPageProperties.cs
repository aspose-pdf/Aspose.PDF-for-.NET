using System.IO;
using System;
using System.Collections;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ManipulatePageProperties
{
    public class SetPageProperties
    {
        public static void Run()
        {
            // ExStart:SetPageProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Open document
            PdfPageEditor pageEditor = new PdfPageEditor();
            pageEditor.BindPdf(dataDir + "input.pdf");

            // Set page properties
            // Move origin from (0,0)
            pageEditor.MovePosition(100, 100);
            // Set page rotations
            Hashtable pageRotations = new Hashtable();
            pageRotations.Add(1, 90);
            pageRotations.Add(2, 180);
            pageRotations.Add(3, 270);
            // PageEditor.PageRotations = pageRotations;
            // Set zoom where 1.0f = 100% zoom
            pageEditor.Zoom = 2.0f;
            // Save updated PDF file
            pageEditor.Save(dataDir + "SetPageProperties_out.pdf");
            // ExEnd:SetPageProperties
        }
    }
}