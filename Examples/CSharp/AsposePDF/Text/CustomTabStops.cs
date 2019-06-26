using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class CustomTabStops
    {
        public static void Run()
        {
            // ExStart:CustomTabStops
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            Document _pdfdocument = new Document();
            Page page = _pdfdocument.Pages.Add();

            Aspose.Pdf.Text.TabStops ts = new Aspose.Pdf.Text.TabStops();
            Aspose.Pdf.Text.TabStop ts1 = ts.Add(100);
            ts1.AlignmentType = TabAlignmentType.Right;
            ts1.LeaderType = TabLeaderType.Solid;
            Aspose.Pdf.Text.TabStop ts2 = ts.Add(200);
            ts2.AlignmentType = TabAlignmentType.Center;
            ts2.LeaderType = TabLeaderType.Dash;
            Aspose.Pdf.Text.TabStop ts3 = ts.Add(300);
            ts3.AlignmentType = TabAlignmentType.Left;
            ts3.LeaderType = TabLeaderType.Dot;

            TextFragment header = new TextFragment("This is a example of forming table with TAB stops", ts);
            TextFragment text0 = new TextFragment("#$TABHead1 #$TABHead2 #$TABHead3", ts);
            
            TextFragment text1 = new TextFragment("#$TABdata11 #$TABdata12 #$TABdata13", ts);
            TextFragment text2 = new TextFragment("#$TABdata21 ", ts);
            text2.Segments.Add(new TextSegment("#$TAB"));
            text2.Segments.Add(new TextSegment("data22 "));
            text2.Segments.Add(new TextSegment("#$TAB"));
            text2.Segments.Add(new TextSegment("data23"));

            page.Paragraphs.Add(header);
            page.Paragraphs.Add(text0);
            page.Paragraphs.Add(text1);
            page.Paragraphs.Add(text2);

            dataDir = dataDir + "CustomTabStops_out.pdf";
            _pdfdocument.Save(dataDir);
            // ExEnd:CustomTabStops            
            Console.WriteLine("\nCustom tab stops setup successfully.\nFile saved at " + dataDir);
        }
    }
}