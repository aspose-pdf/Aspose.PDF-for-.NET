using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Models.PdfEditor;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using Aspose.Pdf.Text;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using File = System.IO.File;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	
	public class AsposePdfEditorController : AsposePdfBase
	{
		private const string searchMarker = "Aspose.PDF Editor Free App Search";

		public AsposePdfEditorController()
		{
			Aspose.Pdf.Live.Demos.UI.Models.License.SetAsposePdfLicense();
			var editorFolder = string.Format("{0}\\Editor\\",  Config.Configuration.WorkingDirectory.Replace("/", "\\"));
			if (!System.IO.Directory.Exists(editorFolder))
				System.IO.Directory.CreateDirectory(editorFolder);
		}

		///<Summary>
		/// GetHTML method to get HTML
		///</Summary>
		public string GetHTML(string fileName, string folderName)
		{
			Opts.AppName = "Editor";
			Opts.FileName = fileName;
			Opts.FolderName = folderName;
			Opts.MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

			try
			{
				var doc = new Document(Opts.WorkingFileName);
				var so = new HtmlSaveOptions()
				{
					DocumentType = Pdf.HtmlDocumentType.Html5,
					RasterImagesSavingMode = Pdf.HtmlSaveOptions.RasterImagesSavingModes.AsPngImagesEmbeddedIntoSvg,
					SplitCssIntoPages = false,
					//CustomCssSavingStrategy = new HtmlSaveOptions.CssSavingStrategy(SaveCss),
					//CustomStrategyOfCssUrlCreation = new HtmlSaveOptions.CssUrlMakingStrategy(CreateCssUrl),
					//CustomResourceSavingStrategy = new HtmlSaveOptions.ResourceSavingStrategy(SaveResources)
				};
				using (var stream = new MemoryStream())
				{
					doc.Save(stream, so);
					// FIX the overwlow of span-elements in some documents
					return UTF8WithoutBom.GetString(stream.ToArray()).Replace("letter-spacing:-107374182.4pt;", "");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}

		[HttpPost]
		[Route("api/asposepdfeditor/upload")]
		public IHttpActionResult Upload()
		{
			var httpRequest = HttpContext.Current.Request;
			var fullPath = Path.Combine(Config.Configuration.WorkingDirectory.Replace("/", "\\"), "Editor", httpRequest.Form["documentId"]);

			var postedFile = httpRequest.Files[0];
			if (postedFile == null)
				return InternalServerError(new Exception(""));

			if (httpRequest.Form["Opp"].StartsWith("uploading"))
			{
				var guid = Guid.NewGuid().ToString();
				var tempFolder = string.Format("{0}Editor\\{1}", Config.Configuration.WorkingDirectory.Replace("/", "\\"), guid);
				Directory.CreateDirectory(tempFolder);
				var filePath = Path.Combine(tempFolder, "document.pdf");
				postedFile.SaveAs(filePath);
				var model = new DocStatusModel
				{
					d = ImageConverter(filePath),
					Path = guid,
					OriginalFileName = postedFile.FileName
				};
				return Ok(model);
			}
			else if (httpRequest.Form["Opp"].StartsWith("appending"))
			{
				string appPages = httpRequest.Form["pages"];
				string appRatios = httpRequest.Form["ratios"];
				string appHeights = httpRequest.Form["heights"];
				var filePath = Path.Combine(fullPath, "append.pdf");
				postedFile.SaveAs(filePath);
				var model = new DocStatusModel
				{
					d = AppendConverter(fullPath, appPages, appRatios, appHeights),
					Path = httpRequest.Form["documentId"]
				};
				return Ok(model);
			}
			else if (httpRequest.Form["Opp"].StartsWith("addAttachment"))
			{
				var documentFileName = Path.Combine(fullPath, "document.pdf");

				PdfContentEditor contentEditor = new PdfContentEditor();
				contentEditor.BindPdf(documentFileName);
				contentEditor.AddDocumentAttachment(postedFile.InputStream, postedFile.FileName, "File added by Aspose.PDF Editor");
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
				postedFile.SaveAs(filePath);

				var model = new DocStatusModel
				{
					d = postedFile.FileName,
					Path = httpRequest.Form["documentId"]
				};
				return Ok(model);
			}
		}

		[HttpPost]
		[Route("api/asposepdfeditor/upload-pic")]
		public IHttpActionResult UploadPic(UploadPicModel uploadPicModel)
		{
			var fullPath = Path.Combine(Config.Configuration.WorkingDirectory, "Editor", uploadPicModel.documentId);
			var downloadFileName = "document.pdf";
			var documentFileName = Path.Combine(Config.Configuration.WorkingDirectory, "Editor", uploadPicModel.documentId, downloadFileName);
			Document doc = new Document(documentFileName);

			//Create image stamp
			ImageStamp imageStamp = new ImageStamp(HttpContext.Current.Server.MapPath("/img/Test.png"));

			for (int i = 0; i < uploadPicModel.shapes.Count; i++)
			{
				//create stamp
				Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();

				float shapeX = (uploadPicModel.shapes[i].x * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio);
				float shapeY = (uploadPicModel.shapes[i].y * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio);
				float shapeW = (uploadPicModel.shapes[i].w * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio);
				float shapeH = (uploadPicModel.shapes[i].h * 72 / 150) / (float)Convert.ToDouble(uploadPicModel.shapes[i].ratio);

				double yaxis = (float)(doc.Pages[uploadPicModel.shapes[i].p].Rect.URY - (shapeH + shapeY));

				var isSpecial = true;//regexItem.IsMatch(uploadPicModel.shapes[i].imName);

				if (uploadPicModel.shapes[i].Itype == "highlight" || uploadPicModel.shapes[i].Itype == "image")
				{

					imageStamp = uploadPicModel.shapes[i].Itype == "highlight"
						? new ImageStamp(HttpContext.Current.Server.MapPath("/img/test.png"))
						: new ImageStamp(fullPath + uploadPicModel.shapes[i].imName);

					imageStamp.Background = false;
					imageStamp.XIndent = (float)(shapeX);
					imageStamp.YIndent = (float)(yaxis);
					imageStamp.Height = shapeH;
					imageStamp.Width = shapeW;

					//Add stamp to particular page
					doc.Pages[uploadPicModel.shapes[i].p].AddStamp(imageStamp);
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
					textStamp.TextState.Font = FontRepository.FindFont(uploadPicModel.shapes[i].n);
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
					doc.Pages[uploadPicModel.shapes[i].p].AddStamp(textStamp);

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

			doc.Save( Config.Configuration.OutputDirectory + "/Export.pdf");

			return Ok(new DocStatusModel());
		}

		[HttpGet]
		[Route("api/AsposePDFEditor/image/{folder}/{filename}")]
		public HttpResponseMessage Image(string folder, string filename, string Dummy)
		{
			//converting Pdf file into bytes array              
			var imagePath = string.Format("{0}Editor\\{1}\\{2}", Config.Configuration.WorkingDirectory.Replace("/", "\\"), folder, filename.Replace('-', '.'));
			var dataBytes = File.ReadAllBytes(imagePath);
			var dataStream = new MemoryStream(dataBytes);

			HttpResponseMessage httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);
			httpResponseMessage.Content = new StreamContent(dataStream);
			httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
			return httpResponseMessage;
		}

		[HttpGet]
		[Route("api/asposepdfeditor/download/{fileType}/{folder}")]
		public HttpResponseMessage Download(string fileType, string folder)
		{
			var fullPath = Path.Combine(Config.Configuration.WorkingDirectory, "Editor", folder);
			var downloadFileName = "document.pdf";
			var documentFileName = Path.Combine(Config.Configuration.WorkingDirectory, "Editor", folder, downloadFileName);
			var contentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");
			switch (fileType)
			{
				case "docx":
					downloadFileName = "document.docx";
					contentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.wordprocessingml.document");
					break;
				case "svg":
					downloadFileName = "document.svg";
					contentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/svg+xml");
					break;
				case "xps":
					downloadFileName = "document.xps";
					contentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/oxps, application/vnd.ms-xpsdocument");
					break;
				case "xls":
					downloadFileName = "document.xlsx";
					contentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
					break;
				case "html":
					downloadFileName = "document.html";
					contentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/html");
					break;

			}
			documentFileName = string.Format("{0}\\{1}", fullPath, downloadFileName);
			var dataBytes = File.ReadAllBytes(documentFileName);
			var dataStream = new MemoryStream(dataBytes);

			HttpResponseMessage httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);
			httpResponseMessage.Content = new StreamContent(dataStream);
			httpResponseMessage.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
			httpResponseMessage.Content.Headers.ContentDisposition.FileName = downloadFileName;
			httpResponseMessage.Content.Headers.ContentType = contentType;
			return httpResponseMessage;
		}

		[HttpPost]
		[Route("api/asposepdfeditor/export-file/{fileType}/{folder}/")]
		public IHttpActionResult ExportFile(string fileType, string folder)
		{
			var fullPath = string.Format("{0}Editor\\{1}", Config.Configuration.WorkingDirectory.Replace("/", "\\"), folder);
			var pdfDocumentPath = string.Format("{0}\\document.pdf", fullPath);
			var doc = new Document(pdfDocumentPath);
			try
			{
				switch (fileType)
				{
					case "txt":
						TextAbsorber textAbsorber = new TextAbsorber();
						doc.Pages.Accept(textAbsorber);
						string extractedText = textAbsorber.Text;
						File.WriteAllText(string.Format("{0}\\document.txt", fullPath), extractedText);
						break;
					case "docx":
						doc.Save(string.Format("{0}\\document.docx", fullPath), SaveFormat.DocX);
						break;
					case "svg":
						doc.Save(string.Format("{0}\\document.svg", fullPath), SaveFormat.Svg);
						break;
					case "xps":
						doc.Save(string.Format("{0}\\document.xps", fullPath), SaveFormat.Xps);
						break;
					case "xls":
						doc.Save(string.Format("{0}\\document.xlsx", fullPath), SaveFormat.Excel);
						break;
					case "html":
						doc.Save(string.Format("{0}\\document.html", fullPath), SaveFormat.Html);
						break;
				}
			}
			catch (Exception e)
			{
				return InternalServerError(e);
			}
			return Ok(new DocStatusModel());
		}

		[HttpPost]
		[Route("api/asposepdfeditor/add-page/{folder}")]
		public IHttpActionResult AddPage(string folder)
		{
			var fullPath = string.Format("{0}Editor\\{1}", Config.Configuration.WorkingDirectory.Replace("/", "\\"), folder);
			var pdfDocumentPath = string.Format("{0}\\document.pdf", fullPath);

			try
			{
				Document doc = new Document(pdfDocumentPath);
				doc.Pages.Add();

				doc.Save(pdfDocumentPath);

				string height = "";
				string Aratio = "";
				//int counter = GetHighestPage();


				using (FileStream imageStream = new FileStream(fullPath + "\\image" + doc.Pages.Count + ".png", FileMode.Create))
				{
					//create PNG device with specified attributes
					PngDevice pngDevice = new PngDevice(new Resolution(150));
					//Convert a particular page and save the image to stream
					pngDevice.Process(doc.Pages[doc.Pages.Count], imageStream);
					//Close stream
					imageStream.Close();

					//System.Drawing.Image image = System.Drawing.Image.FromFile(fullPath + "\\image" + doc.Pages.Count + ".png");
					ScaleImage(fullPath + "\\image" + doc.Pages.Count + ".png", 1138, 760, out height, out Aratio);
					//image.Dispose();
				}

				return Ok(new DocStatusModel
				{
					d = "image" + doc.Pages.Count + ".png#" + height,
					Path = folder
				});
			}
			catch (Exception ex)
			{
				return InternalServerError(ex);
			}
		}

		[HttpPost]
		[Route("api/asposepdfeditor/delete-page")]
		public IHttpActionResult DeletePage(DeletePageModel deletePageModel)
		{
			var documentFileName = System.IO.Path.Combine(Config.Configuration.WorkingDirectory, "Editor", deletePageModel.documentId, "document.pdf");
			var imageFileName = System.IO.Path.Combine(Config.Configuration.WorkingDirectory, "Editor", deletePageModel.documentId, deletePageModel.imageName);
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
				return InternalServerError(ex);
			}
		}

		[HttpPost]
		[Route("api/asposepdfeditor/search-data")]
		public IHttpActionResult SearchData(SearchDataModel searchDataModel)
		{
			//'searchText': moveTo, 'pageList': Npages, 'documentId': documentId            
			var fullPath = Path.Combine(Config.Configuration.WorkingDirectory.Replace("/", "\\"), "Editor", searchDataModel.documentId);
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
		[Route("api/asposepdfeditor/search-clear")]
		public IHttpActionResult SearchClear(SearchDataModel searchDataModel)
		{
			//'searchText': moveTo, 'pageList': Npages, 'documentId': documentId            
			var fullPath = Path.Combine(Config.Configuration.WorkingDirectory.Replace("/", "\\"), "Editor", searchDataModel.documentId);
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
		[Route("api/asposepdfeditor/replace-text")]
		public IHttpActionResult ReplaceText(ReplaceTextModel replaceTextModel)
		{
			var documentFileName = System.IO.Path.Combine(Config.Configuration.WorkingDirectory, "Editor", replaceTextModel.documentId, "document.pdf");
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
				return InternalServerError(ex);
			}
		}

		[HttpPost]
		[Route("api/asposepdfeditor/move-pages")]
		public IHttpActionResult MovePages(MovePagesModel movePagesModel)
		{
			var documentFileName = System.IO.Path.Combine(Config.Configuration.WorkingDirectory, "Editor", movePagesModel.documentId, "document.pdf");
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
				return InternalServerError(ex);
			}
		}

		[HttpGet]
		[Route("api/asposepdfeditor/createNewFile")]
		public IHttpActionResult CreateNewFile()
		{
			var guid = Guid.NewGuid().ToString();
			var tempFolder = string.Format("{0}Editor\\{1}", Config.Configuration.WorkingDirectory.Replace("/", "\\"), guid);
			System.IO.Directory.CreateDirectory(tempFolder);
			var fullPath = System.IO.Path.Combine(tempFolder, "document.pdf");
			Document doc = new Document();
#if DEBUG
			var debugDocument = new Document(HttpContext.Current.Server.MapPath("../../Editor/FormTest1.pdf"));
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
		[Route("api/asposepdfeditor/GetFileAttachments/{folder}")]
		public IHttpActionResult GetFileAttachments(string folder)
		{
			var fullPath = Path.Combine(Config.Configuration.WorkingDirectory.Replace("/", "\\"), "Editor", folder);
			var pdfDocumentPath = string.Format("{0}\\document.pdf", fullPath);

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

		[HttpGet]
		[Route("api/asposepdfeditor/GetFileAttachment/{folder}/{attachmentFileName}")]
		public HttpResponseMessage GetFileAttachment(string folder, string attachmentFileName)
		{
			var fullPath = Path.Combine(Config.Configuration.WorkingDirectory.Replace("/", "\\"), "Editor", folder);
			var pdfDocumentPath = string.Format("{0}\\document.pdf", fullPath);
			attachmentFileName = ReplaceLastUnderscore(attachmentFileName);

			Document pdfDocument = new Document(pdfDocumentPath);
			EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
			var index = 0;
			for (int i = 1; i <= pdfDocument.EmbeddedFiles.Count; i++)
			{
				if (pdfDocument.EmbeddedFiles[i].Name == attachmentFileName)
					index = i;
			}

			var attachment = embeddedFiles[index];

			HttpResponseMessage httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);
			httpResponseMessage.Content = new StreamContent(attachment.Contents);
			httpResponseMessage.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
			httpResponseMessage.Content.Headers.ContentDisposition.FileName = attachment.Name;
			httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
			return httpResponseMessage;
		}

		private static string ReplaceLastUnderscore(string attachment)
		{
			var array = attachment.ToCharArray();
			var pos = attachment.LastIndexOf('_');
			if (array[pos] > -1)
				array[pos] = '.';
			var attachmentFileName = new string(array);
			return attachmentFileName;
		}

		[HttpPost]
		[Route("api/asposepdfeditor/remove-attachment")]
		public IHttpActionResult RemoveFileAttachment(RemoveAttachmentModel removeAttachmentModel)
		{
			var httpRequest = HttpContext.Current.Request;
			var fullPath = Path.Combine(Config.Configuration.WorkingDirectory.Replace("/", "\\"), "Editor", removeAttachmentModel.documentId);
			var pdfDocumentPath = string.Format("{0}\\document.pdf", fullPath);

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
					Path = HttpContext.Current.Request.Form["documentId"]
				};
				return Ok(model);
			}
			catch (Exception ex)
			{
				return InternalServerError(ex);
			}
		}



		public static int GetHighestPage()
		{
			string[] files = Directory.GetFiles(HttpContext.Current.Server.MapPath("Input/"));
			int[] highPage = new int[files.Length];
			for (int i = 0; i < files.Length; i++)
				highPage[i] = Convert.ToInt32(Path.GetFileName(files[i]).Replace("image", "").Replace(".png", ""));


			return highPage.Max();
		}

		public static void Startup()
		{

			//DirectoryInfo downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Input/"));

			//foreach (FileInfo file in downloadedMessageInfo.GetFiles())
			//{
			//    System.IO.File.Delete();
			//}

			//downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Attachments/"));

			//foreach (FileInfo file in downloadedMessageInfo.GetFiles())
			//{
			//    System.IO.File.Delete();
			//}

			//downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Images/"));

			//foreach (FileInfo file in downloadedMessageInfo.GetFiles())
			//{
			//    System.IO.File.Delete();
			//}

			//downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Images/Signature/"));

			//foreach (FileInfo file in downloadedMessageInfo.GetFiles())
			//{
			//    System.IO.File.Delete();
			//}

			//downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("search/"));

			//foreach (FileInfo file in downloadedMessageInfo.GetFiles())
			//{
			//    System.IO.File.Delete();
			//}
			//foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
			//{
			//    dir.Delete(true);
			//}

		}

		private static string AppendConverter(string fullPath, string appPages, string appRatios, string appHeights)
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

		private static string ImageConverter(string fullName)
		{
			Document doc = new Document(fullName);
			string Aratio = "";
			string pages = "";
			string Ratios = "";
			string height = "";
			string Allheights = "";
			string fields = "";
			int TotalPages = doc.Pages.Count;
			var fullPath = System.IO.Path.GetDirectoryName(fullName);
			for (int pageCount = 1; pageCount <= TotalPages; pageCount++)
			{
				using (FileStream imageStream = new FileStream(fullPath + "\\image" + pageCount + ".png", FileMode.Create))
				{
					PngDevice pngDevice = new PngDevice(new Resolution(150));
					pngDevice.Process(doc.Pages[pageCount], imageStream);
					imageStream.Close();

					//System.Drawing.Image image = System.Drawing.Image.FromFile(fullPath + "\\image" + pageCount + ".png");
					ScaleImage(fullPath + "\\image" + pageCount + ".png", 1138, 760, out height, out Aratio);

					//image.Dispose();

					if (pageCount == 1)
						fields = CheckFields(doc, pageCount, "image" + pageCount + ".png", fields, Convert.ToDouble(Aratio));

					pages = pages + "," + "image" + pageCount + ".png";
					Ratios = Ratios + "," + Aratio;
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

		protected static void ScaleImage(string path, int maxWidth, int maxHeight, out string height, out string Aratio)
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
				System.Diagnostics.Trace.WriteLine(e.Message);
				throw;
			}
			image.Dispose();
			File.Delete(path);
			File.Move(path.Replace(".png", "a.png"), path);
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
	}
}
