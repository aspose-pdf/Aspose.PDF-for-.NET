using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;
using Aspose.Pdf.Live.Demos.UI.Models;
using Document = Aspose.Pdf.Document;
using SaveFormat = Aspose.Pdf.SaveFormat;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	///<Summary>
	/// AsposePdfSignatureController class to sign pdf file
	///</Summary>
	public class AsposePdfSignatureController : AsposePdfBase
	{
		private const int ImageHeight = 100;
		private const int RightPadding = 10;
		private const int TopPadding = 10;

		///<Summary>
		/// Sign documents
		///</Summary>
		[MimeMultipart]
		[HttpPost]
		[AcceptVerbs("GET", "POST")]
		public async Task<Response> Sign(string outputType, string signatureType)
		{
			outputType = outputType == "-" ? "pdf" : outputType;
			try
			{
				var form = HttpContext.Current.Request.Form;
				string _imageFile = form["image"];
				string _text = form["text"];
				string _textColor = form["textColor"];
				var files = await UploadFiles();
				var docs = files.Where(x => x.Headers.ContentDisposition.Name != "\"imageFile\"").Select(x => new DocumentInfo() { FileName = x.LocalFileName, PdfDocument = new Document(x.LocalFileName) }).ToArray();
				if (docs.Length == 0 || docs.Length > MaximumUploadFiles)
					return MaximumFileLimitsResponse;


				SetDefaultOptions(docs, outputType);
				Opts.AppName = "Signature";
				Opts.MethodName = "SignDocument";
				Opts.ResultFileName = Path.GetFileNameWithoutExtension(docs[0].FileName) + "." + outputType;
				Opts.ZipFileName = "Signed documents";

				var imageFile = files.FirstOrDefault(x => x.Headers.ContentDisposition.Name == "\"imageFile\"")?.LocalFileName;
				if (signatureType == "image" && imageFile == null)
					return new Response
					{
						Status = "Can't process the image file",
						StatusCode = 500
					};
				


				return  Process((inFilePath, outPath, zipOutFolder) =>
				{
					var tasks = docs.Select(doc => Task.Factory.StartNew(() =>
					{
						switch (signatureType)
						{
							case "drawing":
								AddDrawing(doc, _imageFile);
								break;
							case "text":
								AddText(doc, _text, _textColor);
								break;
							case "image":
								AddImage(doc, imageFile);
								break;
						}
						doc.PdfDocument.Save(outPath, GetSaveFormat(outputType.ToLower()));
						//SaveDocument(doc, outPath, zipOutFolder, new SaveFormatType() { SaveOptions = new PdfSaveOptions(), SaveType = SaveType.pdf});
					})).ToArray();

					Task.WaitAll(tasks);
				});
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new Response
				{
					Status = "Error during processing your file",
					StatusCode = 500
				};
			}
		}

		private void AddImage(DocumentInfo doc, string imageFile)
		{
			string signatureImageName = imageFile;

			// Open document
			Document pdfDocument = doc.PdfDocument;
			var page = pdfDocument.Pages[1];

			using (var im = new Bitmap(signatureImageName))
			{
				var coeff = (double)im.Width / im.Height;
				var imageStamp = new ImageStamp(signatureImageName);
				// imageStamp.Background = true;
				//				imageStamp.XIndent = 100;
				//			imageStamp.YIndent = 100;
				imageStamp.HorizontalAlignment = HorizontalAlignment.Right;
				imageStamp.VerticalAlignment = VerticalAlignment.Bottom;
				imageStamp.Width = page.PageInfo.Width / 3;
				imageStamp.Height = imageStamp.Width / coeff;

				page.AddStamp(imageStamp);

			}
		}
		private FormattedText getFormattedText(string watermarkText)
		{
			FormattedText fmtText = new FormattedText();
			var lines = watermarkText.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (var line in lines)
			{
				fmtText.AddNewLineText(line);
			}
			return fmtText;
		}
		private void AddText(DocumentInfo doc, string signatureText, string signatureTextColor)
		{
			var page = doc.PdfDocument.Pages[1];

			// Create text stamp
			TextStamp textStamp = new TextStamp(getFormattedText(signatureText));
			// Set whether stamp is background
			// textStamp.Background = true;

			textStamp.HorizontalAlignment = HorizontalAlignment.Right;
			textStamp.VerticalAlignment = VerticalAlignment.Bottom;
			textStamp.TextAlignment = HorizontalAlignment.Center;

			// Set origin
			//textStamp.XIndent = 100;
			//textStamp.YIndent = 100;
			// Rotate stamp
			//textStamp.Rotate = Rotation.on90;
			// Set text properties
			textStamp.TextState.Font = FontRepository.FindFont("Arial");
			textStamp.TextState.FontSize = 50;
			textStamp.Width = page.PageInfo.Width / 3;


			if (signatureTextColor != "")
			{
				if (!signatureTextColor.StartsWith("#"))
				{
					signatureTextColor = "#" + signatureTextColor;
				}

				textStamp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.ColorTranslator.FromHtml(signatureTextColor));
			}
			else
			{

				textStamp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Aqua);
			}

			page.AddStamp(textStamp);
		}

		private void AddDrawing(DocumentInfo doc, string imageFile)
		{
			var page = doc.PdfDocument.Pages[1];
			// Convert base 64 string to byte[]
			byte[] imageBytes = Convert.FromBase64String(imageFile);
			// Convert byte[] to Image
			using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
			{

				var bitmap = new Bitmap(ms);
				var coeff = bitmap.Width / bitmap.Height;

				var imageStamp = new ImageStamp(ms);
				//  imageStamp.Background = true;
				//				imageStamp.XIndent = 100;
				//			imageStamp.YIndent = 100;
				imageStamp.HorizontalAlignment = HorizontalAlignment.Right;
				imageStamp.VerticalAlignment = VerticalAlignment.Bottom;
				imageStamp.Width = page.PageInfo.Width / 3;
				imageStamp.Height = imageStamp.Width / coeff;
				page.AddStamp(imageStamp);
			}

		}


		

		
		

        private static SaveFormat GetSaveFormat(string outputType)
		{
			switch (outputType)
			{
				case "pdf":
					return SaveFormat.Pdf;
				case "doc":
					return SaveFormat.Doc;
				case "docx":
					return SaveFormat.DocX;
				case "pptx":
					return SaveFormat.Pptx;
				case "tex":
					return SaveFormat.TeX;
				case "xls":
					return SaveFormat.Excel;
				case "xlsx":
					return SaveFormat.Excel;
				case "epub":
					return SaveFormat.Epub;
			}
			return SaveFormat.Pdf;
		}

	}
}
