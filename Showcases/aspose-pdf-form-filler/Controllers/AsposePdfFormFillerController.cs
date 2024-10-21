using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Aspose.App.Models;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using Aspose.PDF.Shared.Controllers;
using Aspose.Pdf.Text;
using Aspose.Shared.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Aspose.PDF.FormFiller.Models.API;
using System.Threading;
using System.Globalization;

namespace Aspose.App.Controllers
{
    public class AsposePdfFormFillerController : NewApiControllerBase
	{
        private const string searchMarker = "Aspose.PDF Form Filler Free App Search";
        
        public AsposePdfFormFillerController(IStorageService storage, IConfiguration configuration, ILogger<AsposePdfFormFillerController> logger) 
            : base(storage, configuration, logger)
        {
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		}

        [HttpPost]
        [ActionName("UploadFile")]
        public async Task<FileSafeResult> UploadFile() => (await Upload(Guid.NewGuid().ToString())).First();

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        private async Task<IEnumerable<FileSafeResult>> Upload(string folder)
        {
            var files = await UploadFiles("pdf");
            var workFolder = $"{Path.GetDirectoryName(AppSettings.WorkingDirectory)}/{folder}";
            Directory.CreateDirectory(workFolder);
            var tempFileName = $"{workFolder}/{files[0].FileName}";
            using (var fileStream = new FileStream(tempFileName, FileMode.CreateNew))
            {
                files[0].CopyTo(fileStream);
            }

            return
                from fileData in files
                let localFileName = fileData.FileName
                select new FileSafeResult(tempFileName)
                {
                    id = Path.GetFileName(Path.GetDirectoryName(tempFileName)),
                    FileName = Path.GetFileName(localFileName),
                    idUpload = null,
                };
        }

		[HttpPost]
        public async Task<IActionResult> Upload()
        {
            var httpRequest = HttpContext.Request;
            var fullPath = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", httpRequest.Form["documentId"]);

            var postedFile = httpRequest.Form.Files[0];
            if (postedFile == null)
                return BadRequest();


			if (httpRequest.Form["Opp"].ToString().StartsWith("uploading"))
			{
				var guid = Guid.NewGuid().ToString();
				var tempFolder = string.Format("{0}FormFiller/{1}", AppSettings.WorkingDirectory, guid);
				Directory.CreateDirectory(tempFolder);
				var filePath = Path.Combine(tempFolder, "document.pdf");
                using (var fileStream = new FileStream(filePath, FileMode.CreateNew))
                {
                    postedFile.CopyTo(fileStream);
                }
				var model = new DocStatusModel
				{
					d = ImageConverter(filePath),
					Path = guid,
					OriginalFileName = postedFile.FileName
				};
				return Ok(model);
			}
			else if (httpRequest.Form["Opp"].ToString().StartsWith("appending"))
			{
				string appPages = httpRequest.Form["pages"];
				string appRatios = httpRequest.Form["ratios"];
				string appHeights = httpRequest.Form["heights"];
				var filePath = Path.Combine(fullPath, "append.pdf");
                using (var fileStream = new FileStream(filePath, FileMode.CreateNew))
                {
                    postedFile.CopyTo(fileStream);
                }
				var model = new DocStatusModel
				{
					d = AppendConverter(fullPath, appPages, appRatios, appHeights),
					Path = httpRequest.Form["documentId"]
				};
				return Ok(model);
			}
			else if (httpRequest.Form["Opp"].ToString().StartsWith("addAttachment"))
			{
				var documentFileName = Path.Combine(fullPath, "document.pdf");

				PdfContentEditor contentEditor = new PdfContentEditor();
				contentEditor.BindPdf(documentFileName);
				contentEditor.AddDocumentAttachment(postedFile.OpenReadStream(), postedFile.FileName, "File added by Aspose.PDF FormFiller");
				contentEditor.Save(documentFileName);

				return Ok(new DocStatusModel
				{
					d = postedFile.FileName,
					Path = httpRequest.Form["documentId"]
				});
			}
			else
			{
				//Or just save it locally              
				var filePath = Path.Combine(fullPath, postedFile.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.CreateNew))
                {
                    postedFile.CopyTo(fileStream);
				}

				var model = new DocStatusModel
				{
					d = postedFile.FileName,
					Path = httpRequest.Form["documentId"]
				};
				return Ok(model);
			}
		}

		[HttpGet]
		[Route("/pdf/form-filler/api/ExistFile")]
		public async Task<IActionResult> ExistFile(string fileName)
		{
			string resourceName = GetFormResourceName(fileName);
			var assembly = Assembly.GetExecutingAssembly();
			if (!assembly.GetManifestResourceNames().Any(name => string.Equals(name, resourceName, StringComparison.OrdinalIgnoreCase)))
			{
				return NotFound($"Template not found {resourceName}, list: {string.Join("\n", assembly.GetManifestResourceNames())}");
			}

			var stream = assembly.GetManifestResourceStream(assembly.GetManifestResourceNames().First(name => string.Equals(name, resourceName, StringComparison.OrdinalIgnoreCase)));

			var model = new DocStatusModel
			{
				d = ImageConverter(stream, fileName),
				OriginalFileName = fileName
			};
			return Ok(model);
		}


		[HttpGet]
		[Route("/pdf/form-filler/api/ExistFileCustom")]
		public async Task<IActionResult> ExistFileCustom(string folder, string fileName)
		{
			var downloadFileName = "document.pdf";

			var rootDir = $"{AppSettings.WorkingDirectory}FormFiller";
			var tempFolder = $"{rootDir}/{folder}";
			Directory.CreateDirectory(rootDir);
			Directory.CreateDirectory(tempFolder);
			var fullPath = Path.Combine(tempFolder, downloadFileName);
			try
			{
				string resourceName = GetFormResourceName(fileName);
				var assembly = Assembly.GetExecutingAssembly();
				if (!assembly.GetManifestResourceNames().Contains(resourceName))
				{
                    return NotFound($"Template not found {resourceName}, list: {string.Join("\n", assembly.GetManifestResourceNames())}");
				}

				var stream = assembly.GetManifestResourceStream(resourceName);
				using (var fileStream = System.IO.File.Create(fullPath))
				{
					stream.CopyTo(fileStream);
				}
			}
			catch (Exception ex)
			{
				logger.FileMoveError(fileName, fullPath, ex);
			}

			var model = new DocStatusModel
			{
				d = ImageConverter(fullPath),
				Path = folder,
				OriginalFileName = Path.GetFileName(fullPath)
			};
			return Ok(model);
		}

		[HttpPost]
		[ActionName("upload-pic")]
        public async Task<IActionResult> UploadPic([FromBody] UploadPicModel uploadPicModel)
		{
			var fullPath = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", uploadPicModel.documentId);
			var downloadFileName = "document.pdf";
			var documentFileName = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", uploadPicModel.documentId, downloadFileName);
			Document doc = new Document(documentFileName);

			for (int i = 0; i < uploadPicModel.shapes.Count; i++)
			{
				//create stamp
				Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();

                //Console.WriteLine(float.Parse(uploadPicModel.shapes[i].x));
                //Console.WriteLine(uploadPicModel.shapes[i].ratio);
                //Console.WriteLine(decimal.Parse(uploadPicModel.shapes[i].ratio.Replace('.', ',').Trim()));

				float shapeX = (float.Parse(uploadPicModel.shapes[i].x.Replace(',', '.')) * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio.Replace(',', '.'));
				float shapeY = (float.Parse(uploadPicModel.shapes[i].y.Replace(',', '.')) * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio.Replace(',', '.'));
				float shapeW = (float.Parse(uploadPicModel.shapes[i].w.Replace(',', '.')) * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio.Replace(',', '.'));
				float shapeH = (float.Parse(uploadPicModel.shapes[i].h.Replace(',', '.')) * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio.Replace(',', '.'));

				double yaxis = (float)(doc.Pages[int.Parse(uploadPicModel.shapes[i].p)].Rect.URY - (shapeH + shapeY));

				var isSpecial = true;//regexItem.IsMatch(uploadPicModel.shapes[i].imName);

				if (uploadPicModel.shapes[i].Itype == "highlight" || uploadPicModel.shapes[i].Itype == "image")
				{
                    //Create image stamp
                    ImageStamp imageStamp = null;
                    Stream stream = null;

					if (uploadPicModel.shapes[i].Itype == "highlight")
					{
                        var assembly = Assembly.GetExecutingAssembly();
                        var resourcePath = assembly.GetManifestResourceNames().FirstOrDefault(name => name.EndsWith("Test.png")); ;
                        stream = assembly.GetManifestResourceStream(resourcePath);
                        imageStamp = new ImageStamp(stream);
					}
					else
                    {
                        imageStamp = new ImageStamp(Path.Combine(fullPath, uploadPicModel.shapes[i].imName));

                    }

                    imageStamp.Background = false;
                    imageStamp.XIndent = (float)(shapeX);
                    imageStamp.YIndent = (float)(yaxis);
                    imageStamp.Height = shapeH;
                    imageStamp.Width = shapeW;

                    //Add stamp to particular page
                    doc.Pages[int.Parse(uploadPicModel.shapes[i].p)].AddStamp(imageStamp);
                    if (stream != null) stream.Dispose();
                }
				else if (uploadPicModel.shapes[i].Itype == "text")
				{
					//create text stamp
					TextStamp textStamp = new TextStamp(uploadPicModel.shapes[i].t);
					textStamp.XIndent = (float)(shapeX);
					textStamp.YIndent = (float)(yaxis);
					//rotate stamp
					textStamp.RotateAngle = 360 - (Convert.ToDouble(uploadPicModel.shapes[i].fieldType) * 180 / Math.PI);

					//set text properties
					var fonts = System.Drawing.FontFamily.Families;
					if(fonts.Any(f => string.Equals(f.Name, uploadPicModel.shapes[i].n)))
                    {
						textStamp.TextState.Font = FontRepository.FindFont(uploadPicModel.shapes[i].n);
					}
					
					textStamp.TextState.FontSize = Convert.ToInt32(uploadPicModel.shapes[i].s) * 0.75f;

					if (uploadPicModel.shapes[i].wt == "bold")
					{
						textStamp.TextState.FontStyle = FontStyles.Bold;
					}

					if (uploadPicModel.shapes[i].st == "italic")
					{
						textStamp.TextState.FontStyle = FontStyles.Italic;
					}


					textStamp.TextState.ForegroundColor = GetColor(uploadPicModel.shapes[i].c);
					//add stamp to particular page
					doc.Pages[int.Parse(uploadPicModel.shapes[i].p)].AddStamp(textStamp);

				}
				else if (uploadPicModel.shapes[i].Itype == "field" && isSpecial)
				{
					if (uploadPicModel.shapes[i].fieldType == "Text")
					{
						// Get a field
						TextBoxField textBoxField = doc.Form.Fields[Convert.ToInt32(uploadPicModel.shapes[i].imName)] as TextBoxField;
						// Modify field value
						textBoxField.Value = uploadPicModel.shapes[i].t;

					}
					else if (uploadPicModel.shapes[i].fieldType == "CheckBox")
					{

						// Get a field
						CheckboxField checkBoxField = doc.Form.Fields[Convert.ToInt32(uploadPicModel.shapes[i].imName)] as CheckboxField;
						if (uploadPicModel.shapes[i].t != "")
							// Modify field value
							checkBoxField.Checked = Convert.ToBoolean(uploadPicModel.shapes[i].t);
					}
					else if (uploadPicModel.shapes[i].fieldType == "Radio")
					{
						RadioButtonOptionField field = (RadioButtonOptionField)doc.Form.Fields[Convert.ToInt32(uploadPicModel.shapes[i].imName)];

						RadioButtonField rbf = (RadioButtonField)field.Parent;
						if (Convert.ToBoolean(uploadPicModel.shapes[i].t))
						{
							rbf.Selected = rbf.Options[field.OptionName].Index;

						}
						else
						{
							field.ActiveState = "Off";

						}
					}
					else if (uploadPicModel.shapes[i].fieldType == "ComboBox")
					{

						// Get a field
						ComboBoxField comboBoxField = doc.Form.Fields[Convert.ToInt32(uploadPicModel.shapes[i].imName)] as ComboBoxField;
						var values = uploadPicModel.shapes[i].t.Split(new[] { "^^^" }, StringSplitOptions.None)[0];

						foreach (var item in comboBoxField.Options.Cast<Option>())
						{
							if (item.Value == values)
							{

								comboBoxField.Selected = item.Index;
							}
						}
					}
				}

			}

			//doc.Save(HttpContext.Current.Server.MapPath("Convert/Export.pdf"));
			doc.Save(documentFileName);
			return Ok(new DocStatusModel());
		}

        [HttpGet]
        [Route("/pdf/form-filler/api/image/{folder}/{filename}")]
        public async Task<IActionResult> Image(string folder, string filename, string Dummy)
        {
			//converting Pdf file into bytes array              
			int extensionPosition = filename.LastIndexOf('-');
			int extensionPosition2 = filename.LastIndexOf('.');
			if (extensionPosition != -1 && extensionPosition2 < extensionPosition)
            {
				filename = filename.Remove(extensionPosition, 1).Insert(extensionPosition, ".");
			}
			var fullPath = $"{AppSettings.WorkingDirectory}FormFiller/{folder}/";
			var imagePath = fullPath + filename;

            var dataBytes = System.IO.File.ReadAllBytes(imagePath);
            //var dataStream = new MemoryStream(dataBytes);

            //HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            //httpResponseMessage.Content = new StreamContent(dataStream);
            //httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
            return File(dataBytes, "image/png");
		}

		[HttpGet]
		[Route("/pdf/form-filler/api/image-custom/{folder}/{filename}")]
		public async Task<IActionResult> ImageCustom(string folder, string filename, string Dummy)
		{
			//converting Pdf file into bytes array              
			int extensionPosition = filename.LastIndexOf('-');
			int extensionPosition2 = filename.LastIndexOf('.');
			if (extensionPosition != -1 && extensionPosition2 < extensionPosition)
			{
				filename = filename.Remove(extensionPosition, 1).Insert(extensionPosition, ".");
			}
			var imagePath = string.Format("{0}FormFiller/{1}/{2}", AppSettings.WorkingDirectory, folder, filename);

			var dataBytes = System.IO.File.ReadAllBytes(imagePath);
			//var dataStream = new MemoryStream(dataBytes);

			//HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
			//httpResponseMessage.Content = new StreamContent(dataStream);
			//httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
			return File(dataBytes, "image/png");
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/download/{fileName}")]
        public async Task<IActionResult> Download(string fileName, [FromBody] UploadPicModel uploadPicModel)
        {
			string resourceName = GetFormResourceName(fileName);
			var assembly = Assembly.GetExecutingAssembly();
			if (!assembly.GetManifestResourceNames().Contains(resourceName))
			{
                return NotFound($"Template not found {resourceName}, list: {string.Join("\n", assembly.GetManifestResourceNames())}");
			}

			var stream = assembly.GetManifestResourceStream(resourceName);

			Document doc = new Document(stream);

			for (int i = 0; i < uploadPicModel.shapes.Count; i++)
			{
				//create stamp
				Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();

				//Console.WriteLine(float.Parse(uploadPicModel.shapes[i].x));
				//Console.WriteLine(uploadPicModel.shapes[i].ratio);
				//Console.WriteLine(decimal.Parse(uploadPicModel.shapes[i].ratio.Replace('.', ',').Trim()));

				float shapeX = (float.Parse(uploadPicModel.shapes[i].x.Replace(',', '.')) * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio.Replace(',', '.'));
				float shapeY = (float.Parse(uploadPicModel.shapes[i].y.Replace(',', '.')) * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio.Replace(',', '.'));
				float shapeW = (float.Parse(uploadPicModel.shapes[i].w.Replace(',', '.')) * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio.Replace(',', '.'));
				float shapeH = (float.Parse(uploadPicModel.shapes[i].h.Replace(',', '.')) * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio.Replace(',', '.'));

				double yaxis = (float)(doc.Pages[int.Parse(uploadPicModel.shapes[i].p)].Rect.URY - (shapeH + shapeY));

				var isSpecial = true;//regexItem.IsMatch(uploadPicModel.shapes[i].imName);

				if (uploadPicModel.shapes[i].Itype == "field" && isSpecial)
				{
					if (uploadPicModel.shapes[i].fieldType == "Text")
					{
						// Get a field
						TextBoxField textBoxField = doc.Form.Fields[Convert.ToInt32(uploadPicModel.shapes[i].imName)] as TextBoxField;
						// Modify field value
						textBoxField.Value = uploadPicModel.shapes[i].t;

					}
					else if (uploadPicModel.shapes[i].fieldType == "CheckBox")
					{

						// Get a field
						CheckboxField checkBoxField = doc.Form.Fields[Convert.ToInt32(uploadPicModel.shapes[i].imName)] as CheckboxField;
						if (uploadPicModel.shapes[i].t != "")
							// Modify field value
							checkBoxField.Checked = Convert.ToBoolean(uploadPicModel.shapes[i].t);
					}
					else if (uploadPicModel.shapes[i].fieldType == "Radio")
					{
						RadioButtonOptionField field = (RadioButtonOptionField)doc.Form.Fields[Convert.ToInt32(uploadPicModel.shapes[i].imName)];

						RadioButtonField rbf = (RadioButtonField)field.Parent;
						if (Convert.ToBoolean(uploadPicModel.shapes[i].t))
						{
							rbf.Selected = rbf.Options[field.OptionName].Index;

						}
						else
						{
							field.ActiveState = "Off";

						}
					}
					else if (uploadPicModel.shapes[i].fieldType == "ComboBox")
					{

						// Get a field
						ComboBoxField comboBoxField = doc.Form.Fields[Convert.ToInt32(uploadPicModel.shapes[i].imName)] as ComboBoxField;
						var values = uploadPicModel.shapes[i].t.Split(new[] { "^^^" }, StringSplitOptions.None)[0];

						foreach (var item in comboBoxField.Options.Cast<Option>())
						{
							if (item.Value == values)
							{

								comboBoxField.Selected = item.Index;
							}
						}
					}
				}
			}

			//doc.Save(HttpContext.Current.Server.MapPath("Convert/Export.pdf"));
			MemoryStream resultStream = new MemoryStream();
			doc.Save(resultStream);

			string contentType = "application/pdf";

			var flattenDoc = new Document(resultStream);
			flattenDoc.Flatten();
			var memoryStream = new MemoryStream();
			flattenDoc.Save(memoryStream);
			return File(memoryStream, contentType);
        }

		[HttpGet]
		[Route("/pdf/form-filler/api/download-custom/{fileType}/{folder}")]
		public async Task<IActionResult> DownloadCustom(string fileType, string folder)
		{
			var fullPath = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", folder);
			var downloadFileName = "document.pdf";
			var documentFileName = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", folder, downloadFileName);
			string contentType = "application/pdf";
			switch (fileType)
			{
				case "docx":
					downloadFileName = "document.docx";
					contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
					break;
				case "svg":
					downloadFileName = "document.svg";
					contentType = "image/svg+xml";
					break;
				case "xps":
					downloadFileName = "document.xps";
					contentType = "application/oxps, application/vnd.ms-xpsdocument";
					break;
				case "xls":
					downloadFileName = "document.xlsx";
					contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
					break;
				case "html":
					downloadFileName = "document.html";
					contentType = "text/html";
					break;

			}
			documentFileName = string.Format("{0}/{1}", fullPath, downloadFileName);
			if (fileType == "pdf")
			{
				var flattenDoc = new Document(documentFileName);
				flattenDoc.Flatten();
				var memoryStream = new MemoryStream();
				flattenDoc.Save(memoryStream);
				return File(memoryStream, contentType);
			}
			else
			{
				var dataBytes = System.IO.File.ReadAllBytes(documentFileName);
				return File(dataBytes, contentType);
			}
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/exportfile/")]
		public async Task<IActionResult> ExportFile(string fileType, string folder)
		{
			var fullPath = string.Format("{0}FormFiller/{1}", AppSettings.WorkingDirectory, folder);
			var pdfDocumentPath = string.Format("{0}/document.pdf", fullPath);
			var doc = new Document(pdfDocumentPath);
			try
			{
				switch (fileType)
				{
					case "txt":
						TextAbsorber textAbsorber = new TextAbsorber();
						doc.Pages.Accept(textAbsorber);
						string extractedText = textAbsorber.Text;
						System.IO.File.WriteAllText(string.Format("{0}/document.txt", fullPath), extractedText);
						break;
					case "docx":
						doc.Save(string.Format("{0}/document.docx", fullPath), SaveFormat.DocX);
						break;
					case "svg":
						doc.Save(string.Format("{0}/document.svg", fullPath), SaveFormat.Svg);
						break;
					case "xps":
						doc.Save(string.Format("{0}/document.xps", fullPath), SaveFormat.Xps);
						break;
					case "xls":
						doc.Save(string.Format("{0}/document.xlsx", fullPath), SaveFormat.Excel);
						break;
					case "html":
						doc.Save(string.Format("{0}/document.html", fullPath), SaveFormat.Html);
						break;
				}
			}
			catch (Exception ex)
			{
				logger.HTMLEditorExportFileError(fullPath, fileType, ex);
                return new BadRequestObjectResult(ex);
			}
			return Ok(new DocStatusModel());
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/exportfile-custom/")]
		public async Task<IActionResult> ExportFileCustom(string fileType, string folder)
		{
			var fullPath = string.Format("{0}FormFiller/{1}", AppSettings.WorkingDirectory, folder);
			var pdfDocumentPath = string.Format("{0}/document.pdf", fullPath);
			var doc = new Document(pdfDocumentPath);
			try
			{
				switch (fileType)
				{
					case "txt":
						TextAbsorber textAbsorber = new TextAbsorber();
						doc.Pages.Accept(textAbsorber);
						string extractedText = textAbsorber.Text;
						System.IO.File.WriteAllText(string.Format("{0}/document.txt", fullPath), extractedText);
						break;
					case "docx":
						doc.Save(string.Format("{0}/document.docx", fullPath), SaveFormat.DocX);
						break;
					case "svg":
						doc.Save(string.Format("{0}/document.svg", fullPath), SaveFormat.Svg);
						break;
					case "xps":
						doc.Save(string.Format("{0}/document.xps", fullPath), SaveFormat.Xps);
						break;
					case "xls":
						doc.Save(string.Format("{0}/document.xlsx", fullPath), SaveFormat.Excel);
						break;
					case "html":
						doc.Save(string.Format("{0}/document.html", fullPath), SaveFormat.Html);
						break;
				}
			}
			catch (Exception ex)
			{
				logger.HTMLEditorExportFileError(fullPath, fileType, ex);
				return new BadRequestObjectResult(ex);
			}
			return Ok(new DocStatusModel());
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/add-page/{folder}")]
		public async Task<IActionResult> AddPage(string folder)
		{
			var fullPath = string.Format("{0}FormFiller/{1}", AppSettings.WorkingDirectory, folder);
			var pdfDocumentPath = string.Format("{0}/document.pdf", fullPath);

			try
			{
				Document doc = new Document(pdfDocumentPath);
				doc.Pages.Add();

				doc.Save(pdfDocumentPath);

				string height = "";
				string Aratio = "";
				//int counter = GetHighestPage();


				using (FileStream imageStream = new FileStream(fullPath + "/image" + doc.Pages.Count + ".png", FileMode.Create))
				{
					//create PNG device with specified attributes
					PngDevice pngDevice = new PngDevice(new Resolution(150));
					//Convert a particular page and save the image to stream
					pngDevice.Process(doc.Pages[doc.Pages.Count], imageStream);
					//Close stream
					imageStream.Close();

					//System.Drawing.Image image = System.Drawing.Image.FromFile(fullPath + "/image" + doc.Pages.Count + ".png");
					ScaleImage(fullPath + "/image" + doc.Pages.Count + ".png", 1138, 760, out height, out Aratio);
					//image.Dispose();
				}

				return Ok(new DocStatusModel
				{
					d = $"image{doc.Pages.Count}.png#{height}#{Aratio}",
					Path = folder
				});
			}
			catch (Exception ex)
			{
				logger.EditorAddPageError(pdfDocumentPath, ex);
				return new BadRequestObjectResult(ex);
			}
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/delete-page")]
		public async Task<IActionResult> DeletePage([FromBody] DeletePageModel deletePageModel)
		{
			var documentFileName = System.IO.Path.Combine(AppSettings.WorkingDirectory, "FormFiller", deletePageModel.documentId, "document.pdf");
			var imageFileName = System.IO.Path.Combine(AppSettings.WorkingDirectory, "FormFiller", deletePageModel.documentId, deletePageModel.imageName);
			try
			{
				Document doc = new Document(documentFileName);
				doc.Pages.Delete(Convert.ToInt32(deletePageModel.imageData));
				doc.Save(documentFileName);
				System.IO.File.Delete(imageFileName);
				return Ok(deletePageModel);
			}
			catch (Exception ex)
			{
				logger.EditorDeletePageError(documentFileName, ex);
				return new BadRequestObjectResult(ex);
			}
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/search-data")]
		public async Task<IActionResult> SearchData([FromBody] SearchDataModel searchDataModel)
		{
			//'searchText': moveTo, 'pageList': Npages, 'documentId': documentId            
			var fullPath = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", searchDataModel.documentId);
			var documentFileName = Path.Combine(fullPath, "document.pdf");
			//string name = DateTime.Now.Millisecond.ToString();
			var documentFolderInfo = new DirectoryInfo(fullPath);
			foreach (FileInfo file in documentFolderInfo.GetFiles("image*.png"))
				file.Delete();

			Document document = new Document(documentFileName);
			TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber(searchDataModel.searchText);
			textFragmentAbsorber.Visit(document);
			foreach (var textFragment in textFragmentAbsorber.TextFragments)
			{
				textFragment.Page.Annotations.Add(
					new Pdf.Annotations.HighlightAnnotation(textFragment.Page, textFragment.Rectangle)
					{
						Title = searchMarker
					}
					);
			}
			document.Save(documentFileName);
			var model = new DocStatusModel
			{
				d = ImageConverter(documentFileName),
				Path = searchDataModel.documentId,
				OriginalFileName = ""
			};
			return Ok(model);
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/search-clear")]
		public async Task<IActionResult> SearchClear([FromBody] SearchDataModel searchDataModel)
		{
			//'searchText': moveTo, 'pageList': Npages, 'documentId': documentId            
			var fullPath = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", searchDataModel.documentId);
			var documentFileName = Path.Combine(fullPath, "document.pdf");
			//string name = DateTime.Now.Millisecond.ToString();
			var documentFolderInfo = new DirectoryInfo(fullPath);
			foreach (FileInfo file in documentFolderInfo.GetFiles("image*.png"))
				file.Delete();

			Document document = new Document(documentFileName);
			foreach (var page in document.Pages)
			{
				var annotations = page.Annotations.Where(a => a.AnnotationType == Pdf.Annotations.AnnotationType.Highlight).Cast<Pdf.Annotations.HighlightAnnotation>();
				foreach (var highlightAnnotation in annotations)
				{
					if (highlightAnnotation.Title.Equals(searchMarker))
						page.Annotations.Delete(highlightAnnotation);
				}
			}
			document.Save(documentFileName);
			var model = new DocStatusModel
			{
				d = ImageConverter(documentFileName),
				Path = searchDataModel.documentId,
				OriginalFileName = ""
			};
			return Ok(model);
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/replace-text")]
		public async Task<IActionResult> ReplaceText([FromBody] ReplaceTextModel replaceTextModel)
		{
			var documentFileName = System.IO.Path.Combine(AppSettings.WorkingDirectory, "FormFiller", replaceTextModel.documentId, "document.pdf");
			try
			{
				Document doc = new Document(documentFileName);

				// TODO: Imporve alghorithm
				//create TextAbsorber object to find all instances of the input search phrase
				//TextFragmentAbsorber textFragmentAbsorber =
				//    new TextFragmentAbsorber("(?i)" + replaceTextModel.txtFind, new TextSearchOptions(true))
				//    {
				//        TextReplaceOptions =
				//        {
				//            ReplaceAdjustmentAction = TextReplaceOptions.ReplaceAdjustment.WholeWordsHyphenation
				//        }
				//    };

				TextFragmentAbsorber textFragmentAbsorber =
					new TextFragmentAbsorber(replaceTextModel.txtFind);

				doc.Pages.Accept(textFragmentAbsorber);

				//get the extracted text fragments
				TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;

				//loop through the fragments
				foreach (TextFragment textFragment in textFragmentCollection)
				{
					//update text and other properties
					textFragment.Text = replaceTextModel.txtReplace;
				}

				doc.Save(documentFileName);

				//doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

				var downloadedMessageInfo = new DirectoryInfo(Path.GetDirectoryName(documentFileName));
				foreach (FileInfo file in downloadedMessageInfo.GetFiles("*.png"))
					file.Delete();

				var model = new DocStatusModel
				{
					d = ImageConverter(documentFileName),
					Path = replaceTextModel.documentId
				};

				return Ok(replaceTextModel);
			}
			catch (Exception ex)
			{
				logger.EditorReplaceTextError(documentFileName, ex);
				return new BadRequestObjectResult(ex);
			}
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/move-pages")]
		public async Task<IActionResult> MovePages([FromBody] MovePagesModel movePagesModel)
		{
			var documentFileName = System.IO.Path.Combine(AppSettings.WorkingDirectory, "FormFiller", movePagesModel.documentId, "document.pdf");
			try
			{
				int pageFrom = Convert.ToInt32(movePagesModel.moveFrom);
				int pageTo = Convert.ToInt32(movePagesModel.moveTo);
				System.Collections.Generic.List<string> str = movePagesModel.pageList.ToList();

				var doc = new Document(documentFileName);
				var page = doc.Pages[pageFrom];

				doc.Pages.Insert(pageTo + 1, page);

				if (pageFrom > pageTo)
				{
					doc.Pages.Delete(pageFrom + 1);
					str.Insert(pageTo, movePagesModel.pageList[pageFrom - 1]);
					str.RemoveAt(pageFrom);
				}
				else
				{
					doc.Pages.Delete(pageFrom);
					str.Insert(pageTo, movePagesModel.pageList[pageFrom - 1]);
					str.RemoveAt(pageFrom - 1);
				}

				doc.Save(documentFileName);
				movePagesModel.pageList = str.ToArray();

				return Ok(movePagesModel);
			}
			catch (Exception ex)
			{
				logger.EditorMovePagesError(documentFileName, ex);
				return new BadRequestObjectResult(ex);
			}
		}

		[HttpGet]
		[Route("/pdf/form-filler/api/createNewFile")]
		public async Task<IActionResult> CreateNewFile()
		{
			var guid = Guid.NewGuid().ToString();
			var tempFolder = string.Format("{0}FormFiller/{1}", AppSettings.WorkingDirectory, guid);
			System.IO.Directory.CreateDirectory(tempFolder);
			var fullPath = System.IO.Path.Combine(tempFolder, "document.pdf");
			Document doc = new Document();
#if DEBUG
			var debugDocument = new Document(@"C:\Tmp\FormTest1.pdf");
			doc.Pages.Add(debugDocument.Pages);
#else
            doc.Pages.Add();
#endif
			doc.Save(fullPath);
			var model = new DocStatusModel
			{
				d = ImageConverter(fullPath),
				Path = guid
			};
			return Ok(model);
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/GetFileAttachments/{folder}")]
		public async Task<IActionResult> GetFileAttachments(string folder)
		{
			var fullPath = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", folder);
			var pdfDocumentPath = string.Format("{0}/document.pdf", fullPath);

			string outAttach = "";

			// Open document
			using (Document pdfDocument = new Document(pdfDocumentPath))
			{

				// Get embedded files collection
				EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
				// Loop through the collection to get all the attachments
				foreach (FileSpecification fileSpecification in embeddedFiles)
				{
					outAttach = outAttach + "," + fileSpecification.Name + "," + fileSpecification.Description;
				}
				if (outAttach.Length > 1)
				{
					outAttach = outAttach.Substring(1);
				}
			}
			var model = new FileAttachmentsModel
			{
				d = outAttach
			};
			return Ok(model);
		}

		//[HttpGet]
		//[Route("api/asposepdfeditor/GetFileAttachment/{folder}/{attachmentFileName}")]
		//public HttpResponseMessage GetFileAttachment(string folder, string attachmentFileName)
		//{
		//	var fullPath = Path.Combine(AppSettings.WorkingDirectory, "Editor", folder);
		//	var pdfDocumentPath = string.Format("{0}/document.pdf", fullPath);
		//	attachmentFileName = ReplaceLastUnderscore(attachmentFileName);

		//	Document pdfDocument = new Document(pdfDocumentPath);
		//	EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
		//	var index = 0;
		//	for (int i = 1; i <= pdfDocument.EmbeddedFiles.Count; i++)
		//	{
		//		if (pdfDocument.EmbeddedFiles[i].Name == attachmentFileName)
		//			index = i;
		//	}

		//	var attachment = embeddedFiles[index];

		//	HttpResponseMessage httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);
		//	httpResponseMessage.Content = new StreamContent(attachment.Contents);
		//	httpResponseMessage.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
		//	httpResponseMessage.Content.Headers.ContentDisposition.FileName = attachment.Name;
		//	httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
		//	return httpResponseMessage;
		//}

		[HttpPost]
		[Route("/pdf/form-filler/api/remove-attachment")]
		public async Task<IActionResult> RemoveFileAttachment([FromBody] RemoveAttachmentModel removeAttachmentModel)
		{
			var httpRequest = HttpContext.Request;
			var fullPath = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", removeAttachmentModel.documentId);
			var pdfDocumentPath = string.Format("{0}/document.pdf", fullPath);

			// Open document
			try
			{
				using (Document pdfDocument = new Document(pdfDocumentPath))
				{
					EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
					pdfDocument.EmbeddedFiles.Delete(removeAttachmentModel.attachmentFileName);
				}
				var model = new FileAttachmentsModel
				{
					d = "Success",
					Path = HttpContext.Request.Form["documentId"]
				};
				return Ok(model);
			}
			catch (Exception ex)
			{
				logger.EditorRemoveFileAttachmentError(removeAttachmentModel.attachmentFileName, ex);
				return new BadRequestObjectResult(ex);
			}
		}

		[HttpPost]
		[Route("/pdf/form-filler/api/create-signature")]
		public async Task<IActionResult> CreateSignature([FromBody] SignatureModel signatureModel)
		{
			var httpRequest = HttpContext.Request;
			var fullPath = Path.Combine(AppSettings.WorkingDirectory, "FormFiller", signatureModel.documentId);

			Random random = new Random();
			int rand = random.Next(1000000);
			string fileNameWitPath = $"{fullPath}/sign{rand}.png";
			using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
			{
				using (BinaryWriter bw = new BinaryWriter(fs))
				{
					byte[] data = Convert.FromBase64String(signatureModel.imageData);
					bw.Write(data);
					bw.Close();
				}
			}
			var model = new DocStatusModel
			{
				d = $"sign{rand}.png"
			};
			return Ok(model);
		}

		private string AppendConverter(string fullPath, string appPages, string appRatios, string appHeights)
		{
			var originalDocumentFileName = Path.Combine(fullPath, "document.pdf");
			var appendedDocumentFileName = Path.Combine(fullPath, "append.pdf");

			Document doc = new Document(originalDocumentFileName);
			int initialPageCount = doc.Pages.Count;

			//open second document
			Document pdfDocument2 = new Document(appendedDocumentFileName);

			//add pages of second document to the first
			doc.Pages.Add(pdfDocument2.Pages);

			//save concatenated output file
			doc.Save(originalDocumentFileName);

			string Aratio = "";
			//string pages = "";
			string height = "";
			//string Allheights = "";

			for (int pageIndex = initialPageCount + 1; pageIndex <= doc.Pages.Count; pageIndex++)
			{
				var imageFileName = Path.Combine(fullPath, "image" + pageIndex + ".png");
				using (FileStream imageStream = new FileStream(imageFileName, FileMode.Create))
				{
					PngDevice pngDevice = new PngDevice(new Resolution(150));
					pngDevice.Process(doc.Pages[pageIndex], imageStream);
					imageStream.Close();

					ScaleImage(imageFileName, 1138, 760, out height, out Aratio);
					appPages = appPages + "," + "image" + pageIndex + ".png";
					appRatios = appRatios + "," + Aratio;
					appHeights = appHeights + "," + height;
				}
			}
			return appPages + "%#" + appRatios + "%#" + appHeights;
		}

		private string ImageConverter(string fullName)
		{
			Document doc = new Document(fullName);
			string Aratio;
			string pages = "";
			string Ratios = "";
			string height;
			string Allheights = "";
			string fields = "";
			int TotalPages = doc.Pages.Count;
			var fullPath = System.IO.Path.GetDirectoryName(fullName);
			for (int pageCount = 1; pageCount <= TotalPages; pageCount++)
			{
				using (FileStream imageStream = new FileStream(fullPath + "/image" + pageCount + ".png", FileMode.Create))
				{
					PngDevice pngDevice = new PngDevice(new Resolution(150));
					pngDevice.Process(doc.Pages[pageCount], imageStream);
					imageStream.Close();

					//System.Drawing.Image image = System.Drawing.Image.FromFile(fullPath + "/image" + pageCount + ".png");
					ScaleImage(fullPath + "/image" + pageCount + ".png", 1138, 760, out height, out Aratio);

					//image.Dispose();

					if (pageCount == 1)
						fields = CheckFields(doc, pageCount, "image" + pageCount + ".png", fields, Convert.ToDouble(Aratio));

					pages = pages + "," + "image" + pageCount + ".png";
					//IFormatProvider formatProvider = new CultureInfo("en-US");
					Ratios = $"{Ratios},{Aratio.ToString().Replace(',', '.')}";
					Allheights = Allheights + "," + height;
				}
			}

			Ratios = Ratios.Substring(1, Ratios.Length - 1);
			pages = pages.Substring(1, pages.Length - 1);
			Allheights = Allheights.Substring(1, Allheights.Length - 1);
			if (fields != "")
			{
				fields = fields.Substring(3, fields.Length - 3);
			}
			return pages + "%#" + Ratios + "%#" + Allheights + "%#" + fields;
		}

		private string ImageConverter(Stream stream, string fileName)
		{
			Document doc = new Document(stream);
			string Aratio;
			string pages = "";
			string Ratios = "";
			string height;
			string Allheights = "";
			string fields = "";
			int TotalPages = doc.Pages.Count;
			var fullPath = $"{AppSettings.WorkingDirectory}FormFiller/{fileName}";
			for (int pageCount = 1; pageCount <= TotalPages; pageCount++)
			{
				var imageFile = fullPath + "/image" + pageCount + ".png";
				var aratioFile = imageFile + ".aratio";
				if (!System.IO.File.Exists(imageFile) || !System.IO.File.Exists(aratioFile))
                {
					var dir = new DirectoryInfo(Path.GetDirectoryName(imageFile));
					dir.Parent.Create();
					dir.Create();
					using (FileStream imageStream = new FileStream(imageFile, FileMode.Create))
					{
						PngDevice pngDevice = new PngDevice(new Resolution(150));
						pngDevice.Process(doc.Pages[pageCount], imageStream);
						imageStream.Close();
					}

					ScaleImage(imageFile, 1138, 760, out height, out Aratio);
					System.IO.File.WriteAllText(aratioFile, Aratio);
				}
				else
                {
					ReadImageSize(imageFile, 1138, 760, out height, out _);
					Aratio = System.IO.File.ReadAllText(aratioFile);
				}

				if (pageCount == 1)
					fields = CheckFields(doc, pageCount, "image" + pageCount + ".png", fields, Convert.ToDouble(Aratio));

				pages = pages + "," + "image" + pageCount + ".png";
				//IFormatProvider formatProvider = new CultureInfo("en-US");
				Ratios = $"{Ratios},{Aratio.ToString().Replace(',', '.')}";
				Allheights = Allheights + "," + height;
			}

			Ratios = Ratios.Substring(1, Ratios.Length - 1);
			pages = pages.Substring(1, pages.Length - 1);
			Allheights = Allheights.Substring(1, Allheights.Length - 1);
			if (fields != "")
			{
				fields = fields.Substring(3, fields.Length - 3);
			}
			return pages + "%#" + Ratios + "%#" + Allheights + "%#" + fields;
		}

		protected void ReadImageSize(string path, int maxWidth, int maxHeight, out string height, out string Aratio)
		{
			using (var image = System.Drawing.Image.FromFile(path))
            {
				var ratio = (double)maxWidth / image.Width;
				Aratio = ratio.ToString();
				var newWidth = (int)(image.Width * ratio);
				var newHeight = (int)(image.Height * ratio);
				height = newHeight.ToString();
			}
		}

		protected void ScaleImage(string path, int maxWidth, int maxHeight, out string height, out string Aratio)
		{
			var image = System.Drawing.Image.FromFile(path);
			var ratio = (double)maxWidth / image.Width;
			Aratio = ratio.ToString();
			var newWidth = (int)(image.Width * ratio);
			var newHeight = (int)(image.Height * ratio);
			height = newHeight.ToString();
			var newImage = new Bitmap(newWidth, newHeight);
			var g = Graphics.FromImage(newImage);
			g.DrawImage(image, 0, 0, newWidth, newHeight);

			Bitmap bmp = new Bitmap(newImage);
			try
			{
				bmp.Save(path.Replace(".png", "a.png"), ImageFormat.Png);
			}
			catch (Exception e)
			{
				logger.EditorScaleImageError(e);
				throw;
			}
			image.Dispose();
			System.IO.File.Delete(path);
			System.IO.File.Move(path.Replace(".png", "a.png"), path);
		}

		private static string CheckFields(Document doc, int pageCount, string filename, string fields, double ratio, bool licensed = true)
		{
			double marginLeft = doc.Pages[pageCount].PageInfo.Margin.Left;
			double marginTop = doc.Pages[pageCount].PageInfo.Margin.Top;

			int fieldcounter = 0;

			Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form(doc);

			// Get values from all fields
			foreach (Field formField in doc.Form.Fields)
			{
				double lowerLeftY = (doc.Pages[pageCount].Rect.Height) - (formField.Rect.ToRect().Y + formField.Height);

				double lowerLeftX = formField.Rect.ToRect().X;
				var fieldType = formField.GetType().Name; //pdfForm.GetFieldType(formField.FullName);
				var imValue = "";

				if (fieldType.ToString() == "CheckboxField" || fieldType.ToString() == "ComboBoxField" || fieldType.ToString() == "RadioButtonOptionField" || fieldType.ToString() == "TextBoxField")
				{
					var value = formField.Value;

					if (fieldType.ToString() == "TextBoxField")
					{
						fieldType = "Text";
					}
					if (fieldType.ToString() == "CheckboxField")
					{
						CheckboxField field = (CheckboxField)formField;
						if (field.Parent != null)
							imValue = field.Parent.FullName;
						fieldType = "CheckBox";
						if (field.Checked)
						{
							value = "true";
						}
						else
						{
							value = "false";
						}
					}
					if (fieldType.ToString() == "RadioButtonOptionField")
					{
						RadioButtonOptionField field = (RadioButtonOptionField)formField;
						RadioButtonField rbf = (RadioButtonField)field.Parent;

						fieldType = "Radio";
						if (field.Parent != null)
							imValue = field.Parent.FullName;
						if ((rbf.Options[field.OptionName].Index == rbf.Selected))
						{
							value = "true";
						}
						else
						{
							value = "false";
						}
					}
					if (fieldType.ToString() == "ComboBoxField")
					{
						ComboBoxField field = (ComboBoxField)formField;
						string optValues = value;
						fieldType = "ComboBox";
						foreach (Option opt in field.Options)
						{

							optValues = optValues + "^^^" + opt.Value;

						}
						value = optValues;
					}

					bool isRequired = pdfForm.IsRequiredField(formField.FullName);
					//fields += "$#$" + (lowerLeftX * 2.08) * ratio + "$#$" + (lowerLeftY * 2.08) * ratio + "$#$" + (formField.Width * 2.08) * ratio + "$#$" + (formField.Height * 2.08) * ratio + "$#$" + formField.PageIndex + "$#$" + "image" + formField.PageIndex + ".png" + "$#$" + value + "$#$" + formField.DefaultAppearance.FontName + "$#$" + formField.DefaultAppearance.FontSize + "$#$" + " " + "$#$" + " " + "$#$" + " " + "$#$" + ratio + "$#$" + " " + "$#$" + formField.FullName.Replace('/', '-') + "$#$" + fieldType;
					fields += "$#$" + (lowerLeftX * 2.08) * ratio + "$#$" + (lowerLeftY * 2.08) * ratio + "$#$" + (formField.Width * 2.08) * ratio + "$#$" + (formField.Height * 2.08) * ratio + "$#$" + formField.PageIndex + "$#$" + "image" + formField.PageIndex + ".png" + "$#$" + value + "$#$" + formField.DefaultAppearance.FontName + "$#$" + formField.DefaultAppearance.FontSize + "$#$" + " " + "$#$" + " " + "$#$" + isRequired + "$#$" + ratio + "$#$" + imValue + "$#$" + fieldcounter + "$#$" + fieldType;
				}
				int length = fields.Length;
				fieldcounter += 1;
				if (!licensed && fieldcounter == 5)
				{
					break;
				}
			}

			return fields;
		}

		public static Aspose.Pdf.Color GetColor(string color)
		{
			switch (color)
			{
				case "red":
					return Aspose.Pdf.Color.Red;
				case "black":
					return Aspose.Pdf.Color.Black;
				case "green":
					return Aspose.Pdf.Color.Green;
				case "white":
					return Aspose.Pdf.Color.White;
				case "blue":
					return Aspose.Pdf.Color.Blue;
				case "grey":
					return Aspose.Pdf.Color.Gray;
				case "yellow":
					return Aspose.Pdf.Color.Yellow;
				default:
					return Aspose.Pdf.Color.Black;
			}
		}

        private string GetFormResourceName(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceNames()
                .FirstOrDefault(name => string.Equals(name, $"Aspose.PDF.FormFiller.Resources.Forms.{fileName}Template.pdf", StringComparison.OrdinalIgnoreCase));

        }
	}
}
