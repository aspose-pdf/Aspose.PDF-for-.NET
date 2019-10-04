using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class UseLatexScript3
    {
        public static void Run()
        {
            //ExStart: UseLatexScript3
            var dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            var s = @"
            \usepackage{amsmath,amsthm}
            \begin{document}
            \begin{proof} The proof is a follows: 
            \begin{align}
            (x+y)^3&=(x+y)(x+y)^2
            (x+y)(x^2+2xy+y^2)\\
            &=x^3+3x^2y+3xy^3+x^3.\qedhere
            \end{align}
            \end{proof}
            \end{document}";

            var doc = new Document();
            var page = doc.Pages.Add();

            var latex = new LatexFragment(s);

            page.Paragraphs.Add(latex);
            doc.Save(dataDir + "Script_out.pdf");
            //ExEnd: UseLatexScript3
        }
    }
}
