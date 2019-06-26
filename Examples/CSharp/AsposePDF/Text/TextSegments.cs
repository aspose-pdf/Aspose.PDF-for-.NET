using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class TextSegments
    {
        public static void Run()
        {

            // ExStart:TextSegments
            TextFragmentAbsorber textFragmentAbsorber;
            // In order to search exact match of a word, you may consider using regular expression.
            textFragmentAbsorber = new TextFragmentAbsorber(@"\bWord\b", new TextSearchOptions(true));

            // In order to search a string in either upper case or lowercase, you may consider using regular expression.
            textFragmentAbsorber = new TextFragmentAbsorber("(?i)Line", new TextSearchOptions(true));

            // In order to search all the strings (parse all strings) inside PDF document, please try using following regular expression.
            textFragmentAbsorber = new TextFragmentAbsorber(@"[\S]+");

            // Find match of search string and get anything after the string till line break.
            textFragmentAbsorber = new TextFragmentAbsorber(@"(?i)the ((.)*)");

            // Please use following regular expression to find text following to the regex match.
            textFragmentAbsorber = new TextFragmentAbsorber(@"(?<=word).*");

            // In order to search Hyperlink/URL's inside PDF document, please try using following regular expression.
            textFragmentAbsorber = new TextFragmentAbsorber(@"(http|ftp|https):\/\/([\w\-_]+(?:(?:\.[\w\-_]+)+))([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?");

            // ExEnd: TextSegments
        }
    }
}