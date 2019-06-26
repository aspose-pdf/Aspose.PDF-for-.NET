using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.WorkingDocument
{
    public class SetViewerPreference
    {
        public static void Run()
        {
            // ExStart:SetViewerPreference
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();
            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir + "SetViewerPreference.pdf");

            // Change Viewer Preferences
            contentEditor.ChangeViewerPreference(ViewerPreference.CenterWindow);
            contentEditor.ChangeViewerPreference(ViewerPreference.HideMenubar);
            contentEditor.ChangeViewerPreference(ViewerPreference.PageModeUseNone);

            // Save output PDF file
            contentEditor.Save(dataDir+ "SetViewerPreference_out.pdf");
            // ExEnd:SetViewerPreference            
        }
    }
}