
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;
using System.IO;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class RemoveHyperlinksAfterConvertingFromHtml
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            Document doc = new Document(dataDir + "SampleHtmlFile.html", new HtmlLoadOptions());
            doc.Save(new MemoryStream());
            foreach (Annotation a in doc.Pages[1].Annotations)
            {
                if (a.AnnotationType == AnnotationType.Link)
                {
                    LinkAnnotation la = (LinkAnnotation)a;
                    if (la.Action is GoToURIAction)
                    {
                        GoToURIAction gta = (GoToURIAction)la.Action;
                        gta.URI = "";
                        TextFragmentAbsorber tfa = new TextFragmentAbsorber();
                        tfa.TextSearchOptions = new TextSearchOptions(a.Rect);
                        doc.Pages[a.PageIndex].Accept(tfa);
                        foreach (TextFragment tf in tfa.TextFragments)
                        {
                            tf.TextState.Underline = false;
                            tf.TextState.ForegroundColor = Color.Black;
                        }
                    }
                    doc.Pages[a.PageIndex].Annotations.Delete(a);
                }
            }
            doc.Save(dataDir + "RemoveHyperlinksFromText_out.pdf");
            // ExEnd:1
        }
    }
}
