using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.WorkingDocument
{
    public class PageBreak
    {
        public static void Run()
        {
            try
            {
                // ExStart:PageBreak
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();
                // Instantiate Document instance
                Document doc = new Document(dataDir + "input.pdf");
                // Instantiate blank Document instance
                Document dest = new Document();
                // Create PdfFileEditor object
                PdfFileEditor fileEditor = new PdfFileEditor();
                fileEditor.AddPageBreak(doc, dest, new PdfFileEditor.PageBreak[] 
                { 
                    new PdfFileEditor.PageBreak(1, 450) 
                });
                // Save resultant file
                dest.Save(dataDir + "PageBreak_out.pdf");
                // ExEnd:PageBreak  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
        public static void PageBreakWithDestPath()
        {
            try
            {
                // ExStart:PageBreakWithDestPath
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();
               
                // Create PdfFileEditor object
                PdfFileEditor fileEditor = new PdfFileEditor();

                fileEditor.AddPageBreak(dataDir + "input.pdf", dataDir + "PageBreakWithDestPath_out.pdf", new PdfFileEditor.PageBreak[] 
                { 
                    new PdfFileEditor.PageBreak(1, 450) 
                });                                
                // ExEnd:PageBreakWithDestPath  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
        public static void PageBreakWithStream()
        {
            try
            {
                // ExStart:PageBreakWithStream
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();

                Stream src = new FileStream( dataDir + "input.pdf", FileMode.Open, FileAccess.Read);
                Stream dest = new FileStream(dataDir + "PageBreakWithStream_out.pdf", FileMode.Create, FileAccess.ReadWrite);
                PdfFileEditor fileEditor = new PdfFileEditor();
                fileEditor.AddPageBreak(src, dest, new PdfFileEditor.PageBreak[] 
                { 
                    new PdfFileEditor.PageBreak(1, 450) 
                });
                dest.Close();
                src.Close();
                // ExEnd:PageBreakWithStream  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }   

}