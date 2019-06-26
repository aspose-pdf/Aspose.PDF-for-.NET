using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class ConcatenatePdfFilesAndCreateTOC
    {
        public static void Run()
        {
            // ExStart:ConcatenatePdfFilesAndCreateTOC
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Save concatenated output file
            pdfEditor.Concatenate(new FileStream(dataDir + "input1.pdf", FileMode.Open), new FileStream(dataDir + "input2.pdf", FileMode.Open), new FileStream(dataDir + "ConcatenatePdfFilesAndCreateTOC_out.pdf", FileMode.Create));
            // ExEnd:ConcatenatePdfFilesAndCreateTOC                      
        }
        public static void InsertBlankPage()
        {
            // ExStart:InsertBlankPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Insert a blank page at the begining of concatenated file to display Table of Contents
            Aspose.Pdf.Document concatenated_pdfDocument = new Aspose.Pdf.Document(new FileStream(dataDir + "Concatenated_Table_Of_Contents.pdf", FileMode.Open));
            // Insert a empty page in a PDF
            concatenated_pdfDocument.Pages.Insert(1);
            // ExEnd:InsertBlankPage
        }
        public static void AddTextStamps()
        {
            // ExStart:AddTextStamps
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Set Text Stamp to display string Table Of Contents
            Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();
            stamp.BindLogo(new FormattedText("Table Of Contents", System.Drawing.Color.Maroon, System.Drawing.Color.Transparent, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, true, 18));
            // Specify the origin of Stamp. We are getting the page width and specifying the X coordinate for stamp
            stamp.SetOrigin((new PdfFileInfo(new FileStream(dataDir + "input1.pdf", FileMode.Open)).GetPageWidth(1) / 3), 700);
            // Set particular pages
            stamp.Pages = new int[] { 1 };           
            // ExEnd:AddTextStamps
        }
        public static void CreateLocalLinks()
        {
            // ExStart:CreateLocalLinks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Now we need to add Heading for Table Of Contents and links for documents
            PdfContentEditor contentEditor = new PdfContentEditor();
            // Bind the PDF file in which we added the blank page
            contentEditor.BindPdf(new FileStream(dataDir + "Concatenated_Table_Of_Contents.pdf", FileMode.Open));
            // Create link for first document
            contentEditor.CreateLocalLink(new System.Drawing.Rectangle(150, 650, 100, 20), 2, 1, System.Drawing.Color.Transparent);
            // ExEnd:CreateLocalLinks
        }
        public static void CompletedCode()
        {
            // ExStart:CompletedCode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create a MemoryStream object to hold the resultant PDf file
            using (MemoryStream Concatenated_Stream = new MemoryStream())
            {
                // Save concatenated output file
                pdfEditor.Concatenate(new FileStream(dataDir + "input1.pdf", FileMode.Open), new FileStream(dataDir + "input2.pdf", FileMode.Open), Concatenated_Stream);
                // Insert a blank page at the begining of concatenated file to display Table of Contents
                Aspose.Pdf.Document concatenated_pdfDocument = new Aspose.Pdf.Document(Concatenated_Stream);
                // Insert a empty page in a PDF
                concatenated_pdfDocument.Pages.Insert(1);

                // Hold the resultnat file with empty page added
                using (MemoryStream Document_With_BlankPage = new MemoryStream())
                {
                    // Save output file
                    concatenated_pdfDocument.Save(Document_With_BlankPage);

                    using (var Document_with_TOC_Heading = new MemoryStream())
                    {
                        // Add Table Of Contents logo as stamp to PDF file
                        PdfFileStamp fileStamp = new PdfFileStamp();
                        // Find the input file
                        fileStamp.BindPdf(Document_With_BlankPage);

                        // Set Text Stamp to display string Table Of Contents
                        Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();
                        stamp.BindLogo(new FormattedText("Table Of Contents", System.Drawing.Color.Maroon, System.Drawing.Color.Transparent, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, true, 18));
                        // Specify the origin of Stamp. We are getting the page width and specifying the X coordinate for stamp
                        stamp.SetOrigin((new PdfFileInfo(Document_With_BlankPage).GetPageWidth(1) / 3), 700);
                        // Set particular pages
                        stamp.Pages = new int[] { 1 };
                        // Add stamp to PDF file
                        fileStamp.AddStamp(stamp);

                        // Create stamp text for first item in Table Of Contents
                        var Document1_Link = new Aspose.Pdf.Facades.Stamp();
                        Document1_Link.BindLogo(new FormattedText("1 - Link to Document 1", System.Drawing.Color.Black, System.Drawing.Color.Transparent, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, true, 12));
                        // Specify the origin of Stamp. We are getting the page width and specifying the X coordinate for stamp
                        Document1_Link.SetOrigin(150, 650);
                        // Set particular pages on which stamp should be displayed
                        Document1_Link.Pages = new int[] { 1 };
                        // Add stamp to PDF file
                        fileStamp.AddStamp(Document1_Link);

                        // Create stamp text for second item in Table Of Contents
                        var Document2_Link = new Aspose.Pdf.Facades.Stamp();
                        Document2_Link.BindLogo(new FormattedText("2 - Link to Document 2", System.Drawing.Color.Black, System.Drawing.Color.Transparent, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, true, 12));
                        // Specify the origin of Stamp. We are getting the page width and specifying the X coordinate for stamp
                        Document2_Link.SetOrigin(150, 620);
                        // Set particular pages on which stamp should be displayed
                        Document2_Link.Pages = new int[] { 1 };
                        // Add stamp to PDF file
                        fileStamp.AddStamp(Document2_Link);

                        // Save updated PDF file
                        fileStamp.Save(Document_with_TOC_Heading);
                        fileStamp.Close();

                        // Now we need to add Heading for Table Of Contents and links for documents
                        PdfContentEditor contentEditor = new PdfContentEditor();
                        // Bind the PDF file in which we added the blank page
                        contentEditor.BindPdf(Document_with_TOC_Heading);
                        // Create link for first document
                        contentEditor.CreateLocalLink(new System.Drawing.Rectangle(150, 650, 100, 20), 2, 1, System.Drawing.Color.Transparent);
                        // Create link for Second document
                        // We have used   new PdfFileInfo("d:/pdftest/Input1.pdf").NumberOfPages + 2   as PdfFileInfo.NumberOfPages(..) returns the page count for first document
                        // And 2 is because, second document will start at Input1+1 and 1 for the page containing Table Of Contents.
                        contentEditor.CreateLocalLink(new System.Drawing.Rectangle(150, 620, 100, 20), new PdfFileInfo(dataDir + "Input1.pdf").NumberOfPages + 2, 1, System.Drawing.Color.Transparent);

                        // Save updated PDF
                        contentEditor.Save( dataDir + "Concatenated_Table_Of_Contents.pdf");
                    }
                }
            }
            // ExEnd:CompletedCode
        }
    }
}