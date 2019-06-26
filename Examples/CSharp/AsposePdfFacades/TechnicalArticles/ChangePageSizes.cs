using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class ChangePageSizes
    {
        public static void Run()
        {
            // ExStart:ChangePageSizes
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create PdfPageEditor object
            PdfPageEditor pEdit = new PdfPageEditor();

            // Bind pdf file
            pEdit.BindPdf(dataDir + "FilledForm.pdf");

            // Change page size of the selected pages
            pEdit.ProcessPages = new int[] { 1};

            // Here we select a member named 'LETTER' from the list of members of PageSize class and assign it to PageSize property of the PdfPageEditor class
            pEdit.PageSize = PageSize.PageLetter;

            // Save the file
            pEdit.Save(dataDir + "ChangePageSizes_out.pdf");

            // Find at what size a page has been assigned
            pEdit.BindPdf(dataDir + "FilledForm.pdf");
            PageSize size = pEdit.GetPageSize(1);
            pEdit = null;
            // ExEnd:ChangePageSizes                      
        }
    }
}