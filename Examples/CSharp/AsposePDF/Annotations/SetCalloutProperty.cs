using Aspose.Pdf.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    class SetCalloutProperty
    {
        /// <summary>
        /// This feature is supported by version 19.6 or greater
        /// </summary>
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            Document doc = new Document();
            Page page = doc.Pages.Add();
            DefaultAppearance da = new DefaultAppearance();
            da.TextColor = System.Drawing.Color.Red;
            da.FontSize = 10;
            FreeTextAnnotation fta = new FreeTextAnnotation(page, new Rectangle(422.25, 645.75, 583.5, 702.75), da);
            fta.Intent = FreeTextIntent.FreeTextCallout;
            fta.EndingStyle = LineEnding.OpenArrow;
            fta.Callout = new Point[]
            {
                new Point(428.25,651.75), new Point(462.75,681.375), new Point(474,681.375)
            };
            page.Annotations.Add(fta);
            fta.RichText = "<body xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:xfa=\"http://www.xfa.org/schema/xfa-data/1.0/\" xfa:APIVersion=\"Acrobat:11.0.23\" xfa:spec=\"2.0.2\"  style=\"color:#FF0000;font-weight:normal;font-style:normal;font-stretch:normal\"><p dir=\"ltr\"><span style=\"font-size:9.0pt;font-family:Helvetica\">This is a sample</span></p></body>";
            doc.Save(dataDir + "SetCalloutProperty.pdf");

            // ExEnd:1
        }
        /// <summary>
        /// This feature is supported by version 19.6 or greater
        /// If you use import from XFDF file please use callout-line name instead just "callout"
        /// </summary>
        public static void SetCalloutPropertyXFDF()
        {
            // ExStart:SetCalloutPropertyXFDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();
            Document pdfDocument = new Document( dataDir + "AddAnnotation.pdf");
            StringBuilder Xfdf = new StringBuilder();
            Xfdf.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?><xfdf xmlns=\"http://ns.adobe.com/xfdf/\" xml:space=\"preserve\"><annots>");
            CreateXfdf(ref Xfdf);
            Xfdf.AppendLine("</annots></xfdf>");
            pdfDocument.ImportAnnotationsFromXfdf(new MemoryStream(Encoding.UTF8.GetBytes(Xfdf.ToString())));
            pdfDocument.Save(dataDir + "SetCalloutPropertyXFDF.pdf");
            // ExEnd:SetCalloutPropertyXFDF
        }
        /// <summary>
        /// Create XFDF
        /// </summary>
        /// <param name="pXfdf"></param>
        static void CreateXfdf(ref StringBuilder pXfdf)
        {
            pXfdf.Append("<freetext");
            pXfdf.Append(" page=\"0\"");
            pXfdf.Append(" rect=\"422.25,645.75,583.5,702.75\"");
            pXfdf.Append(" intent=\"FreeTextCallout\"");
            pXfdf.Append(" callout-line=\"428.25,651.75,462.75,681.375,474,681.375\"");
            pXfdf.Append(" tail=\"OpenArrow\"");
            pXfdf.AppendLine(">");
            pXfdf.Append("<contents-richtext><body ");
            pXfdf.Append(" style=\"font-size:10.0pt;text-align:left;color:#FF0000;font-weight:normal;font-style:normal;font-family:Helvetica;font-stretch:normal\">");
            pXfdf.Append("<p dir=\"ltr\">This is a sample</p>");
            pXfdf.Append("</body></contents-richtext>");
            pXfdf.AppendLine("<defaultappearance>/Helv 12 Tf 1 0 0 rg</defaultappearance>");
            pXfdf.AppendLine("</freetext>");
        }
    }
}
