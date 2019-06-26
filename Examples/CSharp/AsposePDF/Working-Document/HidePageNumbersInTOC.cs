using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class HidePageNumbersInTOC
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            string outFile = dataDir + "HiddenPageNumbers_out.pdf";
            Document doc = new Document();
            Page tocPage = doc.Pages.Add();
            TocInfo tocInfo = new TocInfo();
            TextFragment title = new TextFragment("Table Of Contents");
            title.TextState.FontSize = 20;
            title.TextState.FontStyle = FontStyles.Bold;
            tocInfo.Title = title;
            //Add the list section to the sections collection of the Pdf document
            tocPage.TocInfo = tocInfo;
            //Define the format of the four levels list by setting the left margins and
            //text format settings of each level

            tocInfo.IsShowPageNumbers = false;
            tocInfo.FormatArrayLength = 4;
            tocInfo.FormatArray[0].Margin.Right = 0;
            tocInfo.FormatArray[0].TextState.FontStyle = FontStyles.Bold | FontStyles.Italic;
            tocInfo.FormatArray[1].Margin.Left = 30;
            tocInfo.FormatArray[1].TextState.Underline = true;
            tocInfo.FormatArray[1].TextState.FontSize = 10;
            tocInfo.FormatArray[2].TextState.FontStyle = FontStyles.Bold;
            tocInfo.FormatArray[3].TextState.FontStyle = FontStyles.Bold;
            Page page = doc.Pages.Add();
            //Add four headings in the section
            for (int Level = 1; Level != 5; Level++)

            { Heading heading2 = new Heading(Level); TextSegment segment2 = new TextSegment(); heading2.TocPage = tocPage; heading2.Segments.Add(segment2); heading2.IsAutoSequence = true; segment2.Text = "this is heading of level " + Level; heading2.IsInList = true; page.Paragraphs.Add(heading2); }
            doc.Save(outFile);
            // ExEnd:1
        }
    }
}
