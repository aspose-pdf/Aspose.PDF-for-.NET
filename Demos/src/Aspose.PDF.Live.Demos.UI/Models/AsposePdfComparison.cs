using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
	public class AsposePdfComparison : AsposePdfBase
	{
		///<Summary>
		/// Compare pdf documents
		///</Summary>
		
		public Response Compare(string sourceFolder, DocumentInfo[] docs )
		{
			
			if (docs == null)
				return BadDocumentResponse;
			if (docs.Length != 2)
				return new Response()
				{
					Status = "Number of files should be 2",
					StatusCode = 500
				};

			SetDefaultOptions(docs, "");
			Opts.AppName = "Comparison";
			Opts.MethodName = "Compare";
			Opts.ResultFileName = $"{Path.GetFileName(docs[0].FileName)} compared to {Path.GetFileName(docs[1].FileName)}";
			Opts.OutputType = "pdf";
			Opts.CreateZip = false;
			Opts.FolderName = sourceFolder;

			return  Process((inFilePath, outPath, zipOutFolder) =>
			{
				var doc1 = new Document(docs[0].FileName);
				var doc2 = new Document(docs[1].FileName);
				Document doc3 = Compare(doc1, doc2);
				doc3.Save(outPath);
			});
		}
	

		#region private
		private Document Compare(Document pdfDocument1, Document pdfDocument2)
		{
			var pdfDocument3 = new Aspose.Pdf.Document();
			var paragraphAbsorber1 = new Aspose.Pdf.Text.ParagraphAbsorber();
			var paragraphAbsorber2 = new Aspose.Pdf.Text.ParagraphAbsorber();
			paragraphAbsorber1.Visit(pdfDocument1);
			paragraphAbsorber2.Visit(pdfDocument2);
			for (int i = 1; i <= pdfDocument1.Pages.Count; i++)
			{
				var paragraphs1 = paragraphAbsorber1.PageMarkups.Where(pm => pm.Number == i);
				string text1 = GetTextContent(paragraphs1);
				var page = pdfDocument3.Pages.Add();
				if (i <= pdfDocument2.Pages.Count)
				{
					string text2 = GetTextContent(paragraphAbsorber2.PageMarkups.Where(pm => pm.Number == i));
					var htmlDiff = new Aspose.Pdf.Live.Demos.UI.Helpers.HtmlDiff(text1, text2);
					var htmlContent = htmlDiff.Build();

					HtmlFragment htmlFragment = new HtmlFragment(htmlContent);
					page.Paragraphs.Add(htmlFragment);
				}
				else
				{
					HtmlFragment htmlFragment = new HtmlFragment(text1);
					page.Paragraphs.Add(htmlFragment);
				}
			}
			if (pdfDocument2.Pages.Count > pdfDocument1.Pages.Count)
			{
				for (int i = pdfDocument1.Pages.Count+1; i <= pdfDocument2.Pages.Count; i++)
				{
					string text2 = GetTextContent(paragraphAbsorber2.PageMarkups.Where(pm => pm.Number == i));
					HtmlFragment htmlFragment = new HtmlFragment(text2);
					var page = pdfDocument3.Pages.Add();
					page.Paragraphs.Add(htmlFragment);
				}
			}
			return pdfDocument3;
		}

		private static string GetTextContent(IEnumerable<PageMarkup> paragraphs1)
		{

			string strPageText = "<style>del.diffmod{color:red}ins.diffins{color:green}</style><article>";
			foreach (PageMarkup markup in paragraphs1)
			{
				strPageText += "<section>";
				foreach (MarkupSection section in markup.Sections)
				{
					foreach (MarkupParagraph paragraph in section.Paragraphs)
					{
						StringBuilder paragraphText = new StringBuilder();
						paragraphText.AppendFormat("<p>{0}</p>", paragraph.Text);
						strPageText += paragraphText.ToString();
					}
				}
				strPageText += "</section>";
			}
			strPageText += "</article>";
			return strPageText;
		}
		#endregion
	}
}
