using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class FootAndEndNotes
    {
        public static void Run()
        {
            AddFootNote();
            CustomLineStyleForFootNote();
            CustomizeFootNoteLabel();
            AddImageAndTable();
            CreateEndNotes();
        }
        public static void AddFootNote()
        {
            // ExStart:AddFootNote
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Create Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF
            Page page = doc.Pages.Add();
            // Create GraphInfo object
            Aspose.Pdf.GraphInfo graph = new Aspose.Pdf.GraphInfo();
            // Set line width as 2
            graph.LineWidth = 2;
            // Set the color for graph object
            graph.Color = Aspose.Pdf.Color.Red;
            // Set dash array value as 3
            graph.DashArray = new int[] { 3 };
            // Set dash phase value as 1
            graph.DashPhase = 1;
            // Set footnote line style for page as graph
            page.NoteLineStyle = graph;
            // Create TextFragment instance
            TextFragment text = new TextFragment("Hello World");
            // Set FootNote value for TextFragment
            text.FootNote = new Note("foot note for test text 1");
            // Add TextFragment to paragraphs collection of first page of document
            page.Paragraphs.Add(text);
            // Create second TextFragment
            text = new TextFragment("Aspose.Pdf for .NET");
            // Set FootNote for second text fragment
            text.FootNote = new Note("foot note for test text 2");
            // Add second text fragment to paragraphs collection of PDF file
            page.Paragraphs.Add(text);

            dataDir = dataDir + "AddFootNote_out.pdf";

            // Save resulting PDF document.
            doc.Save(dataDir);
            // ExEnd:AddFootNote
            Console.WriteLine("\nFootNote added successfully.\nFile saved at " + dataDir); 
        }
        public static void CustomLineStyleForFootNote()
        {
            // ExStart:CustomLineStyleForFootNote
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Create Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF
            Page page = doc.Pages.Add();
            // Create GraphInfo object
            Aspose.Pdf.GraphInfo graph = new Aspose.Pdf.GraphInfo();
            // Set line width as 2
            graph.LineWidth = 2;
            // Set the color for graph object
            graph.Color = Aspose.Pdf.Color.Red;
            // Set dash array value as 3
            graph.DashArray = new int[] { 3 };
            // Set dash phase value as 1
            graph.DashPhase = 1;
            // Set footnote line style for page as graph
            page.NoteLineStyle = graph;
            // Create TextFragment instance
            TextFragment text = new TextFragment("Hello World");
            // Set FootNote value for TextFragment
            text.FootNote = new Note("foot note for test text 1");
            // Add TextFragment to paragraphs collection of first page of document
            page.Paragraphs.Add(text);
            // Create second TextFragment
            text = new TextFragment("Aspose.Pdf for .NET");
            // Set FootNote for second text fragment
            text.FootNote = new Note("foot note for test text 2");
            // Add second text fragment to paragraphs collection of PDF file
            page.Paragraphs.Add(text);

            dataDir = dataDir + "CustomLineStyleForFootNote_out.pdf";

            // Save resulting PDF document.
            doc.Save(dataDir);
            // ExEnd:CustomLineStyleForFootNote
            Console.WriteLine("\nCustom line style defined successfully.\nFile saved at " + dataDir);
        }
        public static void CustomizeFootNoteLabel()
        {
            // ExStart:CustomizeFootNoteLabel
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Create Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF
            Page page = doc.Pages.Add();
            // Create GraphInfo object
            Aspose.Pdf.GraphInfo graph = new Aspose.Pdf.GraphInfo();
            // Set line width as 2
            graph.LineWidth = 2;
            // Set the color for graph object
            graph.Color = Aspose.Pdf.Color.Red;
            // Set dash array value as 3
            graph.DashArray = new int[] { 3 };
            // Set dash phase value as 1
            graph.DashPhase = 1;
            // Set footnote line style for page as graph
            page.NoteLineStyle = graph;
            // Create TextFragment instance
            TextFragment text = new TextFragment("Hello World");
            // Set FootNote value for TextFragment
            text.FootNote = new Note("foot note for test text 1");
            // Specify custom label for FootNote
            text.FootNote.Text = " Aspose(2015)";
            // Add TextFragment to paragraphs collection of first page of document
            page.Paragraphs.Add(text);

            dataDir = dataDir + "CustomizeFootNoteLabel_out.pdf";
            // ExEnd:CustomizeFootNoteLabel
            Console.WriteLine("\nFootNote label customized successfully.\nFile saved at " + dataDir);
        }
        public static void AddImageAndTable()
        {
            // ExStart:AddImageAndTable
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            
            Document doc = new Document();
            Page page = doc.Pages.Add();
            TextFragment text = new TextFragment("some text");
            page.Paragraphs.Add(text);

            text.FootNote = new Note();
            Aspose.Pdf.Image image = new Aspose.Pdf.Image();
            image.File = dataDir + "aspose-logo.jpg";
            image.FixHeight = 20;
            text.FootNote.Paragraphs.Add(image);
            TextFragment footNote = new TextFragment("footnote text");
            footNote.TextState.FontSize = 20;
            footNote.IsInLineParagraph = true;
            text.FootNote.Paragraphs.Add(footNote);
            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            table.Rows.Add().Cells.Add().Paragraphs.Add(new TextFragment("Row 1 Cell 1"));
            text.FootNote.Paragraphs.Add(table);

            dataDir = dataDir + "AddImageAndTable_out.pdf";

            // Save resulting PDF document.
            doc.Save(dataDir);
            // ExEnd:AddImageAndTable
            Console.WriteLine("\nTable and image added successfully to FootNote.\nFile saved at " + dataDir);
        }
        public static void CreateEndNotes()
        {
            // ExStart:CreateEndNotes
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Create Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF
            Page page = doc.Pages.Add();
            // Create TextFragment instance
            TextFragment text = new TextFragment("Hello World");
            // Set FootNote value for TextFragment
            text.EndNote = new Note("sample End note");
            // Specify custom label for FootNote
            text.EndNote.Text = " Aspose(2015)";
            // Add TextFragment to paragraphs collection of first page of document
            page.Paragraphs.Add(text);

            dataDir = dataDir + "CreateEndNotes_out.pdf";
            // Save resulting PDF document.
            doc.Save(dataDir);
            // ExEnd:CreateEndNotes
            Console.WriteLine("\nEndNotes created successfully.\nFile saved at " + dataDir);
        }        
        
    }
}