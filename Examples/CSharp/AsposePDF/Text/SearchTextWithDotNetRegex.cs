using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class SearchTextWithDotNetRegex
    {
        public static void Run()
        {
            //ExStart: SearchTextWithDotNetRegex
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Create Regex object to find all words
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"[\S]+");

            // Open document
            Aspose.Pdf.Document document = new Aspose.Pdf.Document(dataDir + "SearchTextRegex.pdf");

            // Get a particular page
            Page page = document.Pages[1];

            // Create TextAbsorber object to find all instances of the input regex
            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber(regex);
            textFragmentAbsorber.TextSearchOptions.IsRegularExpressionUsed = true;

            // Accept the absorber for the page
            page.Accept(textFragmentAbsorber);

            // Get the extracted text fragments
            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;

            // Loop through the fragments
            foreach (TextFragment textFragment in textFragmentCollection)
            {
                Console.WriteLine(textFragment.Text);
            }
            //ExEnd: SearchTextWithDotNetRegex
        }
    }
}
