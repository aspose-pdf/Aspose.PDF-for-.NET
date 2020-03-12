using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    class CustomizePageNumbesWhileAddingTOC
    {
        public static void Run()
        {
            //ExStart: CustomizePageNumbesWhileAddingTOC
            string inFile = RunExamples.GetDataDir_AsposePdf_WorkingDocuments() + "42824.pdf";
            string outFile = RunExamples.GetDataDir_AsposePdf_WorkingDocuments() + "42824_out.pdf";
            // Load an existing PDF files
            Document doc = new Document(inFile);
            // Get access to first page of PDF file
            Aspose.Pdf.Page tocPage = doc.Pages.Insert(1);
            // Create object to represent TOC information
            TocInfo tocInfo = new TocInfo();
            TextFragment title = new TextFragment("Table Of Contents");
            title.TextState.FontSize = 20;
            title.TextState.FontStyle = FontStyles.Bold;
            // Set the title for TOC
            tocInfo.Title = title;
            tocInfo.PageNumbersPrefix = "P";
            tocPage.TocInfo = tocInfo;
            for (int i = 1; i<doc.Pages.Count; i++)
            {
                // Create Heading object
                Aspose.Pdf.Heading heading2 = new Aspose.Pdf.Heading(1);
                TextSegment segment2 = new TextSegment();
                heading2.TocPage = tocPage;
                heading2.Segments.Add(segment2);
                // Specify the destination page for heading object
                heading2.DestinationPage = doc.Pages[i + 1];
                // Destination page
                heading2.Top = doc.Pages[i + 1].Rect.Height;
                // Destination coordinate
                segment2.Text = "Page " + i.ToString();
                // Add heading to page containing TOC
                tocPage.Paragraphs.Add(heading2);
            }

            // Save the updated document
            doc.Save(outFile);
            //ExEnd: CustomizePageNumbesWhileAddingTOC
        }
    }
}
