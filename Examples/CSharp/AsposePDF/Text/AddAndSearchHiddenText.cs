using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddAndSearchHiddenText
    {
        public static void Run()
        {
            //ExStart: AddAndSearchHiddenText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            //Create document with hidden text
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document();
            Page page = doc.Pages.Add();
            TextFragment frag1 = new TextFragment("This is common text.");
            TextFragment frag2 = new TextFragment("This is invisible text.");
            
            //Set text property - invisible
            frag2.TextState.Invisible = true;

            page.Paragraphs.Add(frag1);
            page.Paragraphs.Add(frag2);
            doc.Save(dataDir + "39400_out.pdf");
            doc.Dispose();

            //Search text in the document
            doc = new Aspose.Pdf.Document(dataDir + "39400_out.pdf");
            TextFragmentAbsorber absorber = new TextFragmentAbsorber();
            absorber.Visit(doc.Pages[1]);

            foreach (TextFragment fragment in absorber.TextFragments)
            {
                //Do something with fragments
                Console.WriteLine("Text '{0}' on pos {1} invisibility: {2} ",
                fragment.Text, fragment.Position.ToString(), fragment.TextState.Invisible);
            }
            doc.Dispose();
            //ExEnd: AddAndSearchHiddenText
        }
    }
}
