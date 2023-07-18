using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using Aspose.Pdf.Live.Demos.UI.Models;
using Newtonsoft.Json;
using Document = Aspose.Pdf.Document;
using File = System.IO.File;
using SaveFormat = Aspose.Pdf.SaveFormat;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	///<Summary>
	/// AsposePdfViewerController class to view pdf document
	///</Summary>
	public class AsposePdfViewerController : AsposePdfBase
	{
		private const double ThumbnailsWidth = 150; // in pixels

		///<Summary>
		/// DocumentInfo method to get document info
		///</Summary>
		[HttpPost]		
		public HttpResponseMessage DocumentInformation(RequestData request)
		{
			Opts.AppName = "Viewer";
			Opts.FileName = request.fileName;
			Opts.FolderName = request.folderName;
			Opts.MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

			try
			{
				if (Opts.FolderName.Contains(".."))
					throw new Exception("Break-in attempt");

				var doc = new Document(Opts.WorkingFileName);
				//var lc = new LayoutCollector(doc);
				//PrepareInternalLinks(doc, lc);

				var lst = new List<PageView>(doc.Pages.Count);
				for (int i = 1; i <= doc.Pages.Count; i++)
				{
					var pageInfo = doc.Pages[i];
					var size = pageInfo.Rect;
					lst.Add(new PageView()
					{
						width = size.Width,
						height = size.Height,
						angle = 0,
						number = i
					});

					using (var newDoc = new Document())
					{
						newDoc.Pages.Add(pageInfo);
						newDoc.Save(Config.Configuration.OutputDirectory + Opts.FolderName + $"/page{i}.html",
							new Aspose.Pdf.HtmlSaveOptions
							{
								DocumentType = Pdf.HtmlDocumentType.Html5,
								FixedLayout = true,
								PartsEmbeddingMode = Aspose.Pdf.HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml,
								LettersPositioningMethod = Aspose.Pdf.HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss,
								RasterImagesSavingMode = Aspose.Pdf.HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground,
								FontSavingMode = Aspose.Pdf.HtmlSaveOptions.FontSavingModes.SaveInAllFormats,
								SplitIntoPages = false,
								SplitCssIntoPages = false,
							});
					}
				}

				//return Request.CreateResponse(HttpStatusCode.OK, new PageParametersResponse(request.fileName, lst, PrepareNavigationPaneList(doc, lc)));
				return Request.CreateResponse(HttpStatusCode.OK, new PageParametersResponse(request.fileName, lst, null));
			}
			catch (Exception ex)
			{
				return ExceptionResponse(ex);
			}
		}

	

		/// <summary>
		/// Get page of the document with modified hyperlinks
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		[HttpPost]
		
		public HttpResponseMessage Page(RequestData request)
		{
			Opts.AppName = "Viewer";
			Opts.FileName = request.fileName;
			Opts.FolderName = request.folderName;
			Opts.MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

			//var filename = AppSettings.OutputDirectory + Opts.FolderName + "/" + Opts.FileName;
						   //Path.GetFileNameWithoutExtension(Opts.FileName) + "_links.pdf"; // This file was prepared by PrepareInternalLinks method
			try
			{
				if (Opts.FolderName.Contains(".."))
					throw new Exception("Break-in attempt");

				var doc = new Document(Opts.WorkingFileName);
				var page = PreparePageView(doc, request.pageNumber);
				return Request.CreateResponse(HttpStatusCode.OK, page);
			}
			catch (Exception ex)
			{
				return ExceptionResponse(ex);
			}
		}

		/// <summary>
		/// Common method for 'Page' and 'Print'
		/// </summary>
		/// <param name="doc"></param>
		/// <param name="pageNumber">Starts with one</param>
		/// <returns></returns>
		private PageView PreparePageView(Document doc, int pageNumber)
		{
			using (var stream = new FileStream(Config.Configuration.OutputDirectory + Opts.FolderName + $"/page{pageNumber}.html", FileMode.Open))
			using (var memoryStream = new MemoryStream())
			{
				stream.CopyTo(memoryStream);
				var pageInfo = doc.Pages[pageNumber];
				var size = pageInfo.Rect;
				return new PageView()
				{
					width = size.Width,
					height = size.Height,
					angle = 0,
					number = pageNumber,
					data = UTF8WithoutBom.GetString(memoryStream.ToArray()).Replace("letter-spacing:-107374182.4pt;", "")
				};
			}
		}

		
		///<Summary>
		/// Thumbnails method to get Thumbnails
		///</Summary>
		[HttpPost]
		[AcceptVerbs("GET", "POST")]
		public HttpResponseMessage Thumbnails(RequestData request)
		{
			Opts.AppName = "Viewer";
			Opts.FileName = request.fileName;
			Opts.FolderName = request.folderName;
			Opts.MethodName = "Thumbnails";

			try
			{
				if (Opts.FolderName.Contains(".."))
					throw new Exception("Break-in attempt");

				var doc = new Document(Opts.WorkingFileName);

				//var so = new ImageSaveOptions(SaveFormat.Png) { PageCount = 1 };
				var lst = new List<PageView>();
				//for (int i = 0; i < doc.Pages.Count; i++)
				//{
				//	//so.PageIndex = i;
				//	//doc.Save(stream, so);
				//	//var image = (Image)ResizeImage(pageImage, zoom);
				//	var resizedStream = new MemoryStream();
				//	//image.Save(resizedStream, ImageFormat.Png);

				//	var resolution = new Aspose.Pdf.Devices.Resolution(300);
				//	var imageDevice = new Aspose.Pdf.Devices.PngDevice(resolution);
				//	imageDevice.Process(doc.Pages[i], resizedStream);

				//	//var stream = new MemoryStream();
				//	var pageImage = System.Drawing.Image.FromStream(resizedStream);
				//	var zoom = ThumbnailsWidth / pageImage.Width;

				//	var page = new PageView()
				//	{
				//		width = pageImage.Width /zoom,
				//		height = pageImage.Height / zoom,
				//		angle = 0,
				//		number = i + 1,
				//		data = Convert.ToBase64String(resizedStream.ToArray())
				//	};
				//	lst.Add(page);
				//}
				return Request.CreateResponse(HttpStatusCode.OK, lst);
			}
			catch (Exception ex)
			{
				return ExceptionResponse(ex);
			}
		}

		///<Summary>
		/// Download method to download document
		///</Summary>
		[HttpPost]
		[AcceptVerbs("GET", "POST")]
		public HttpResponseMessage Download(string fileName, string folderName, string outputType)
		{
			Opts.AppName = "Viewer";
			Opts.FileName = fileName;
			Opts.FolderName = folderName;
			Opts.MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

			try
			{
				if (Opts.FolderName.Contains(".."))
					throw new Exception("Break-in attempt");

				if (string.IsNullOrEmpty(outputType))
					outputType = Path.GetExtension(Opts.FileName);
				var fn = Path.GetFileNameWithoutExtension(Opts.FileName) + outputType;
				var resultfile = Config.Configuration.OutputDirectory + Opts.FolderName + "/" + fn;
				if (!File.Exists(resultfile))
					if (string.IsNullOrEmpty(outputType) ||
						Path.GetExtension(Opts.FileName).ToLower() == Path.GetExtension(outputType).ToLower())
					{
						Directory.CreateDirectory(Path.GetDirectoryName(resultfile));
						File.Copy(Opts.WorkingFileName, resultfile);
					}
					else
					{
						var doc = new Document(Opts.WorkingFileName);
						switch (outputType.ToLower())
						{
							case ".html":
								var so = new Aspose.Pdf.HtmlSaveOptions()
								{
									DocumentType = Pdf.HtmlDocumentType.Html5,
								};
								doc.Save(resultfile, so);
								break;
							case ".docx":
								var docSO = new Aspose.Pdf.DocSaveOptions()
								{
									Format = Aspose.Pdf.DocSaveOptions.DocFormat.DocX
								};
								doc.Save(resultfile, docSO);
								break;
							default:
								doc.Save(resultfile);
								break;
						}
					}

				var response = new Response()
				{
					FileName = HttpUtility.UrlEncode(fn),
					FolderName = Opts.FolderName,
					StatusCode = 200
				};
				return Request.CreateResponse(HttpStatusCode.OK, response);
			}
			catch (Exception ex)
			{
				return ExceptionResponse(ex);
			}
		}

		///<Summary>
		/// Print method to print
		///</Summary>
		[HttpPost]
		[AcceptVerbs("GET", "POST")]
		public HttpResponseMessage Print(RequestData request)
		{
			Opts.AppName = "Viewer";
			Opts.FileName = request.fileName;
			Opts.FolderName = request.folderName;
			Opts.MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

			try
			{
				if (Opts.FolderName.Contains(".."))
					throw new Exception("Break-in attempt");

				var doc = new Document(Opts.WorkingFileName);
				var lst = new PageView[doc.Pages.Count];
				for (int i = 0; i < doc.Pages.Count; i++)
					lst[i] = PreparePageView(doc, i + 1);
				return Request.CreateResponse(HttpStatusCode.OK, lst);
			}
			catch (Exception ex)
			{
				return ExceptionResponse(ex);
			}
		}
		///<Summary>
		/// DocumentInfoCORS method to 
		///</Summary>
		[HttpOptions]		
		public HttpResponseMessage DocumentInfoCORS()
		{
			return Request.CreateResponse(HttpStatusCode.OK);
		}
		///<Summary>
		/// PageCORS method to 
		///</Summary>
		[HttpOptions]		
		public HttpResponseMessage PageCORS()
		{
			return Request.CreateResponse(HttpStatusCode.OK);
		}
		///<Summary>
		/// ThumbnailsCORS method to 
		///</Summary>
		[HttpOptions]		
		public HttpResponseMessage ThumbnailsCORS()
		{
			return Request.CreateResponse(HttpStatusCode.OK);
		}
		///<Summary>
		/// DownloadCORS method to 
		///</Summary>
		[HttpOptions]		
		public HttpResponseMessage DownloadCORS()
		{
			return Request.CreateResponse(HttpStatusCode.OK);
		}
		///<Summary>
		/// PrintCORS method to 
		///</Summary>
		[HttpOptions]		
		public HttpResponseMessage PrintCORS()
		{
			return Request.CreateResponse(HttpStatusCode.OK);
		}
		///<Summary>
		/// ExceptionResponse method to 
		///</Summary>
		public HttpResponseMessage ExceptionResponse(Exception ex)
		{
			
			return Request.CreateResponse(HttpStatusCode.InternalServerError, new ExceptionEntity(ex));
		}
		///<Summary>
		/// PageView class to get or set page properties
		///</Summary>
		public class PageView
		{
			///<Summary>
			/// get or set width
			///</Summary>
			public double width { get; set; }
			///<Summary>
			/// get or set height
			///</Summary>
			public double height { get; set; }
			///<Summary>
			/// get or set number
			///</Summary>
			public int number { get; set; }
			///<Summary>
			/// get or set angle
			///</Summary>
			public int angle { get; set; }
			///<Summary>
			/// get or set data
			///</Summary>
			public string data { get; set; }
		}
		///<Summary>
		/// RequestData class to get or set RequestData properties
		///</Summary>
		public class RequestData
		{
			///<Summary>
			/// get or set fileName
			///</Summary>
			public string fileName { get; set; }
			///<Summary>
			/// get or set folderName
			///</Summary>
			public string folderName { get; set; }
			///<Summary>
			/// get or set password
			///</Summary>
			public string password { get; set; }
			///<Summary>
			/// get or set password
			///</Summary>
			public string searchQuery { get; set; }
			///<Summary>
			/// get or set pageNumber
			///</Summary>
			public int pageNumber { get; set; }
			///<Summary>
			/// get or set outputType
			///</Summary>
			public string outputType { get; set; }
		}
		///<Summary>
		/// PageParametersResponse class to get or set PageParametersResponse properties
		///</Summary>
		public class PageParametersResponse
		{
			///<Summary>
			/// get or set guid
			///</Summary>
			[JsonProperty]
			public string guid;

			///<Summary>
			/// get or set pages
			///</Summary>
			[JsonProperty]
			public List<PageView> pages;

			///<Summary>
			/// get or set printAllowed
			///</Summary>
			[JsonProperty]
			public bool printAllowed = true;

			///<Summary>
			/// List of items for Navigation Pane
			///</Summary>
			[JsonProperty]
			public List<NavigationPaneItem> navigationPane;

			///<Summary>
			/// PageParametersResponse
			///</Summary>
			public PageParametersResponse(string guid, List<PageView> pages, List<NavigationPaneItem> navigationPane)
			{
				this.guid = guid;
				this.pages = pages;
				this.navigationPane = navigationPane;
			}
		}
		///<Summary>
		/// ExceptionEntity class to get or set ExceptionEntity properties
		///</Summary>
		public class ExceptionEntity
		{
			///<Summary>
			/// get or set message
			///</Summary>
			public string message { get; set; }
			///<Summary>
			/// init ExceptionEntity
			///</Summary>
			public ExceptionEntity(Exception ex)
			{
				message = ex.Message;
			}
		}

		/// <summary>
		/// NavigationPaneItem
		/// </summary>
		public class NavigationPaneItem
		{
			/// <summary>
			/// Name of the heading
			/// </summary>
			public string name { get; set; }

			/// <summary>
			/// Style: Heading1, Heading2, etc.
			/// </summary>
			//public StyleIdentifier style { get; set; }

			/// <summary>
			/// Page, on which the heading is
			/// </summary>
			public int pageNumber { get; set; }

			/// <summary>
			/// Constructor
			/// </summary>
			/// <param name="name"></param>
			/// <param name="style"></param>
			/// <param name="pageNumber"></param>
			public NavigationPaneItem(string name, object style, int pageNumber)
			{
				this.name = name;
				//this.style = style;
				this.pageNumber = pageNumber;
			}

			/// <summary>
			/// ToString
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return $"{name} | {pageNumber}";
				//return $"{name} | {style} | {pageNumber}";
			}
		}
	}
}
