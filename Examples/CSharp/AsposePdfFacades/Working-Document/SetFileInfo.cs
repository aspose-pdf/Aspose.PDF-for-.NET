using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.WorkingDocument
{
    public class SetFileInfo
    {
        public static void Run()
        {
            // ExStart:SetFileInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();
            // Open document
            PdfFileInfo fileInfo = new PdfFileInfo(dataDir+ "SetFileInfo.pdf");
            // Set PDF information
            fileInfo.Author = "Aspose";
            fileInfo.Title = "Hello World!";
            fileInfo.Keywords = "Peace and Development";
            fileInfo.Creator = "Aspose";             
            // Save updated file
            fileInfo.SaveNewInfo(dataDir+ "SetFileInfo_out.pdf");
            // ExEnd:SetFileInfo           
            
        }
    }
}