using System;
using System.IO;

namespace Examples.Web
{
    public partial class SendPdfToBrowserForDownload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerateDownload_Click(object sender, EventArgs e)
        {
            // ExStart:1
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document();
            doc.Pages.Add().Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World"));
            MemoryStream ms = new MemoryStream();
            doc.Save(ms);
            Response.Clear();
            Response.ClearHeaders();
            Response.ClearContent();
            Response.Charset = "UTF-8";
            Response.AddHeader("content-length", ms.Length.ToString());
            Response.AddHeader("content-disposition", String.Format("attachment;filename=TestDocument.pdf", "FileName"));
            Response.ContentType = "application/pdf"; Response.BinaryWrite(ms.ToArray());
            Response.Flush();
            Response.End();
            // ExEnd:1
        }
    }
}