using Aspose.Pdf.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Aspose.Pdf.Live.Demos.UI.Helpers;
using Aspose.Pdf.Live.Demos.UI.Services;
using Aspose.Pdf;

using Newtonsoft.Json.Linq;
using Aspose.Pdf.Live.Demos.UI.Config;
using System.Web.Http;
using Aspose.Pdf.Live.Demos.UI.Models.Common;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposePdfBase class 
	///</Summary>

	public class AsposePdfBase : ModelBase
	{
		/// <summary>
		/// Maximum number of files which can be uploaded for MVC Aspose.Pdf apps
		/// </summary>
		protected static int MaximumUploadFiles = 10;

		/// <summary>
		/// Original file format SaveAs option for multiple files uploading. By default, "-"
		/// </summary>
		protected const string SaveAsOriginalName = ".-";

		/// <summary>
		/// Response when uploaded files exceed the limits
		/// </summary>
		protected Response MaximumFileLimitsResponse = new Response()
		{
			Status = $"Number of files should be equal or less {MaximumUploadFiles}",
			StatusCode = 500
		};
		/// <summary>
		/// Response when uploaded files exceed the limits
		/// </summary>
		protected Response PasswordProtectedResponse = new Response()
		{
			Status = "Some of your documents are password protected",
			StatusCode = 500
		};
		/// <summary>
		/// Response when uploaded files exceed the limits
		/// </summary>
		protected Response BadDocumentResponse = new Response()
		{
			Status = "Some of your documents are corrupted",
			StatusCode = 500
		};

		
		///<Summary>
		/// Options class 
		///</Summary>
		public class Options
		{
			///<Summary>
			/// AppName
			///</Summary>
			public string AppName;
			///<Summary>
			/// FolderName
			///</Summary>
			public string FolderName;
			///<Summary>
			/// FileName
			///</Summary>
			public string FileName;

			private string _outputType;

			/// <summary>
			/// By default, it is the extension of FileName - e.g. ".docx"
			/// </summary>
			public string OutputType
			{
				get => _outputType;
				set
				{
					if (!value.StartsWith("."))
						value = "." + value;
					_outputType = value.ToLower();
				}
			}

			/// <summary>
			/// Check if OuputType is a picture extension
			/// </summary>
			public bool IsPicture
			{
				get
				{
					switch (_outputType)
					{
						case ".bmp":
						case ".emf":
						case ".png":
						case ".jpg":
						case ".jpeg":
						case ".gif":
						case ".tiff":
							return true;
						default:
							return false;
					}
				}
			}

			///<Summary>
			/// ResultFileName
			///</Summary>
			public string ResultFileName = "";

			///<Summary>
			/// MethodName
			///</Summary>
			public string MethodName;
			///<Summary>
			/// ControllerName
			///</Summary>
			public string ControllerName;
			///<Summary>
			/// CreateZip
			///</Summary>
			public bool CreateZip = false;
			///<Summary>
			/// CheckNumberOfPages
			///</Summary>
			public bool CheckNumberOfPages = false;
			///<Summary>
			/// DeleteSourceFolder
			///</Summary>
			public bool DeleteSourceFolder = false;

			/// <summary>
			/// Output zip filename (without '.zip'), if CreateZip property is true
			/// By default, FileName + AppName
			/// </summary>
			public string ZipFileName;

			/// <summary>
			/// AppSettings.WorkingDirectory + FolderName + "/" + FileName
			/// </summary>
			public string WorkingFileName
			{
				get
				{
					if (System.IO.File.Exists(Config.Configuration.WorkingDirectory + FolderName + "/" + FileName))
						return Config.Configuration.WorkingDirectory + FolderName + "/" + FileName;
					return Config.Configuration.OutputDirectory + FolderName + "/" + FileName;
				}
			}
		}
		/// <summary>
		/// init Options
		/// </summary>
		protected Options Opts = new Options();

		/// <summary>
		/// UTF8WithoutBom
		/// </summary>
		protected static readonly Encoding UTF8WithoutBom = new UTF8Encoding(false);

		/// <summary>
		/// Prepare upload files and return FileData
		/// </summary>
		protected async Task<Collection<MultipartFileData>> UploadFiles()
		{
			Opts.FolderName = Guid.NewGuid().ToString();
			var pathProcessor = new PathProcessor(Opts.FolderName);
			var uploadProvider = new MultipartFormDataStreamProviderSafe(pathProcessor.SourceFolder);
			await Request.Content.ReadAsMultipartAsync(uploadProvider);
			return uploadProvider.FileData;
		}

		/// <summary>
		/// AsposePdfBase
		/// </summary>
		public AsposePdfBase()
		{
			
			Opts.ControllerName = GetType().Name;
		}

		/// <summary>
		/// AsposePdfBase
		/// </summary>
		static AsposePdfBase()
		{
			Aspose.Pdf.Live.Demos.UI.Models.License.SetAsposePdfLicense();
			
			//LoadDictionaries();
		}




		/// <summary>
		/// Set default parameters into Opts
		/// </summary>
		/// <param name="docs"></param>
		protected void SetDefaultOptions(DocumentInfo[] docs, string outputType)
		{
			if (docs.Length > 0)
			{
				SetDefaultOptions(Path.GetFileName(docs[0].FileName), outputType);
				Opts.CreateZip = docs.Length > 1 || Opts.IsPicture;
			}
		}

		/// <summary>
		/// Set default parameters into Opts
		/// </summary>
		/// <param name="InputFiles"></param>
		protected void SetDefaultOptions(InputFiles docs, string outputType)
		{
			if (docs.Count > 0)
			{
				SetDefaultOptions(docs[0].FileName, outputType);
				Opts.CreateZip = docs.Count > 1 || Opts.IsPicture;
			}
		}

		/// <summary>
		/// Set default parameters into Opts
		/// </summary>
		/// <param name="filename"></param>
		private void SetDefaultOptions(string filename, string outputType)
		{
			Opts.ResultFileName = filename;
			Opts.FileName = Path.GetFileName(filename);

			//var query = Request.GetQueryNameValuePairs().ToDictionary(kv => kv.Key, kv => kv.Value, StringComparer.OrdinalIgnoreCase);
			//string outputType = null;
			//if (query.ContainsKey("outputType"))
			//	outputType = query["outputType"];
			Opts.OutputType = !string.IsNullOrEmpty(outputType)
			  ? outputType
			  : Path.GetExtension(Opts.FileName);

			Opts.ResultFileName = Opts.OutputType == SaveAsOriginalName
			  ? Opts.FileName
			  : Path.GetFileNameWithoutExtension(Opts.FileName) + Opts.OutputType;
		}

		protected SaveFormatType GetSaveOptions(string outputType)
		{
			var saveFormat = new SaveFormatType();
			saveFormat.SaveOptions = null;
			switch (outputType)
			{
				case "pdf":
					{
						saveFormat.SaveOptions = new PdfSaveOptions();
						saveFormat.SaveType = SaveType.pdf;
						break;
					}
				case "doc":
					{
						saveFormat.SaveOptions = new DocSaveOptions()
						{
							Format = Aspose.Pdf.DocSaveOptions.DocFormat.Doc
						};
						saveFormat.SaveType = SaveType.doc;
						break;
					}
				case "docx":
					{
						saveFormat.SaveOptions = new DocSaveOptions()
						{
							Format = Aspose.Pdf.DocSaveOptions.DocFormat.DocX
						};
						saveFormat.SaveType = SaveType.docx;
						break;
					}
				case "xlsx":
					{
						saveFormat.SaveOptions = new Aspose.Pdf.ExcelSaveOptions()
						{
							Format = Aspose.Pdf.ExcelSaveOptions.ExcelFormat.XLSX
						};
						saveFormat.SaveType = SaveType.xlsx;
						break;
					}
				case "pptx":
					{
						saveFormat.SaveOptions = new Aspose.Pdf.PptxSaveOptions();
						saveFormat.SaveType = SaveType.pptx;
						break;
					}
				case "xml":
					{
						saveFormat.SaveOptions = new Aspose.Pdf.ExcelSaveOptions()
						{
							Format = Aspose.Pdf.ExcelSaveOptions.ExcelFormat.XMLSpreadSheet2003,

						};
						saveFormat.SaveType = SaveType.xml;
						break;
					}
				case "xps":
					{
						saveFormat.SaveOptions = new XpsSaveOptions();
						saveFormat.SaveType = SaveType.xps;
						break;
					}
				case "epub":
					{
						saveFormat.SaveOptions = new EpubSaveOptions()
						{
							ContentRecognitionMode = Aspose.Pdf.EpubSaveOptions.RecognitionMode.Flow
						};
						saveFormat.SaveType = SaveType.epub;
						break;
					}
				case "tex":
					{
						saveFormat.SaveOptions = new LaTeXSaveOptions()
						{
							OutDirectoryPath = Config.Configuration.OutputDirectory
						};
						saveFormat.SaveType = SaveType.tex;
						break;
					}
				case "html":
					{
						saveFormat.SaveOptions = new Aspose.Pdf.HtmlSaveOptions
						{
							DocumentType = Pdf.HtmlDocumentType.Html5,
							RasterImagesSavingMode = Pdf.HtmlSaveOptions.RasterImagesSavingModes.AsPngImagesEmbeddedIntoSvg
						};
						saveFormat.SaveType = SaveType.html;
						break;
					}
				case "svg":
					{
						saveFormat.SaveOptions = new Aspose.Pdf.SvgSaveOptions
						{
							CompressOutputToZipArchive = false
						};
						saveFormat.SaveType = SaveType.svg;
						break;
					}
				case "bmp":
					{
						saveFormat.SaveType = SaveType.bmp;
						break;
					}
				case "png":
					{
						saveFormat.SaveType = SaveType.png;
						break;
					}
				case "tiff":
					{
						saveFormat.SaveType = SaveType.tiff;
						break;
					}
				case "jpg":
					{
						saveFormat.SaveType = SaveType.jpg;
						break;
					}
				case "emf":
					{
						saveFormat.SaveType = SaveType.emf;
						break;
					}
				default:
					saveFormat.SaveType = null;
					break;
			}

			return saveFormat;
		}

		

		/// <summary>
		/// Process
		/// </summary>
		protected Response Process(ActionDelegate action)
		{
			if (string.IsNullOrEmpty(Opts.OutputType) && !string.IsNullOrEmpty(Opts.FileName))
				Opts.OutputType = Path.GetExtension(Opts.FileName);

			if (Opts.OutputType == ".html" || Opts.OutputType == ".svg" || Opts.IsPicture)
				Opts.CreateZip = true;

			if (string.IsNullOrEmpty(Opts.ZipFileName))
				Opts.ZipFileName = Path.GetFileNameWithoutExtension(Opts.FileName) + Opts.AppName;

			var outputType = Opts.OutputType;
			if (outputType == SaveAsOriginalName && !string.IsNullOrEmpty(Opts.FileName))
				outputType = Path.GetExtension(Opts.FileName);

			return Process(Opts.ControllerName, Opts.ResultFileName, Opts.FolderName, outputType, Opts.CreateZip, Opts.CheckNumberOfPages,
				 Opts.MethodName, action, Opts.DeleteSourceFolder, Opts.ZipFileName);
		}

		/// <summary>
		/// Check if the OutputType is a picture and saves the document
		/// </summary>
		/// <param name="doc"></param>
		/// <param name="outPath"></param>
		/// <param name="zipOutFolder"></param>
		/// <param name="saveOptions"></param>
		protected void SaveDocument(DocumentInfo doc, string outPath, string zipOutFolder, SaveFormatType saveOptions)
		{
			string filename;
			if (Opts.CreateZip)
				filename = zipOutFolder + "/" +
						   (Opts.OutputType == SaveAsOriginalName
							 ? Path.GetFileName(doc.FileName)
							 : Path.GetFileNameWithoutExtension(doc.FileName) + Opts.OutputType);
			else
				filename = outPath;
			SaveDocument(doc, filename, saveOptions);
		}

		/// <summary>
		/// Check if the OutputType is a picture and saves the document
		/// </summary>
		/// <param name="doc"></param>
		/// <param name="filename">The output full FileName</param>
		/// <param name="saveOptions"></param>
		protected void SaveDocument(DocumentInfo doc, string filename, SaveFormatType saveOptions)
		{
			string outPath;
			var zipOutFolder = $"{Path.GetDirectoryName(filename)}\\{Path.GetFileNameWithoutExtension(filename)}";
			Directory.CreateDirectory(zipOutFolder);
			if (saveOptions.SaveOptions != null)
			{
				if (saveOptions.SaveType == SaveType.svg)
				{
					string outfileName = Path.GetFileNameWithoutExtension(filename) + "_{0}";

					int pageCount = 0;
					int totalPages = doc.PdfDocument.Pages.Count;
					// Loop through all the pages
					foreach (Aspose.Pdf.Page pdfPage in doc.PdfDocument.Pages)
					{

						if (totalPages > 1)
						{
							outPath = zipOutFolder + "/" + outfileName;
							outPath = string.Format(outPath, pageCount + 1);
						}
						else
						{
							outPath = zipOutFolder + "/" + Path.GetFileNameWithoutExtension(filename);
						}

						Aspose.Pdf.Document newDocument = new Aspose.Pdf.Document();
						newDocument.Pages.Add(pdfPage);
						newDocument.Save(outPath + ".svg", saveOptions.SaveOptions);
						pageCount++;
					}
				}
				else
				{
					doc.PdfDocument.Form.Type = Aspose.Pdf.Forms.FormType.Standard;
					doc.PdfDocument.Save(filename, saveOptions.SaveOptions);
				}
			}
			else
			{
				string zipOutfileName = Path.GetFileNameWithoutExtension(filename);
				string outfileName = Path.GetFileNameWithoutExtension(doc.FileName) + "_{0}";
				int totalPages = doc.PdfDocument.Pages.Count;
				switch (saveOptions.SaveType)
				{
					case SaveType.bmp:
						{
							for (int pageCount = 1; pageCount <= totalPages; pageCount++)
							{
								if (totalPages > 1)
								{
									outPath = zipOutFolder + "/" + outfileName;
									outPath = string.Format(outPath, pageCount);
								}
								else
								{
									outPath = zipOutFolder + "/" + Path.GetFileNameWithoutExtension(doc.FileName);
								}

								var resolution = new Aspose.Pdf.Devices.Resolution(300);
								var imageDevice = new Aspose.Pdf.Devices.BmpDevice(resolution);
								imageDevice.Process(doc.PdfDocument.Pages[pageCount], outPath + ".bmp");
							}
							break;
						}
					case SaveType.jpg:
						{
							for (int pageCount = 1; pageCount <= totalPages; pageCount++)
							{
								if (totalPages > 1)
								{
									outPath = zipOutFolder + "/" + outfileName;
									outPath = string.Format(outPath, pageCount);
								}
								else
								{
									outPath = zipOutFolder + "/" + Path.GetFileNameWithoutExtension(doc.FileName);
								}

								var resolution = new Aspose.Pdf.Devices.Resolution(300);
								var imageDevice = new Aspose.Pdf.Devices.JpegDevice(resolution);
								imageDevice.Process(doc.PdfDocument.Pages[pageCount], outPath + ".jpg");
							}
							break;
						}
					case SaveType.png:
						{
							for (int pageCount = 1; pageCount <= totalPages; pageCount++)
							{
								if (totalPages > 1)
								{
									outPath = zipOutFolder + "/" + outfileName;
									outPath = string.Format(outPath, pageCount);
								}
								else
								{
									outPath = zipOutFolder + "/" + Path.GetFileNameWithoutExtension(doc.FileName);
								}

								var resolution = new Aspose.Pdf.Devices.Resolution(300);
								var imageDevice = new Aspose.Pdf.Devices.PngDevice(resolution);
								imageDevice.Process(doc.PdfDocument.Pages[pageCount], outPath + ".png");
							}
							break;
						}
					case SaveType.tiff:
						{
							outPath = zipOutFolder;
							Directory.Delete(zipOutFolder);
							var resolution = new Aspose.Pdf.Devices.Resolution(300);
							var imageDevice = new Aspose.Pdf.Devices.TiffDevice(resolution);
							imageDevice.Process(doc.PdfDocument, outPath + ".tiff");
							break;
						}
					case SaveType.emf:
						{
							for (int pageCount = 1; pageCount <= totalPages; pageCount++)
							{
								if (totalPages > 1)
								{
									outPath = zipOutFolder + "/" + outfileName;
									outPath = string.Format(outPath, pageCount);
								}
								else
								{
									outPath = zipOutFolder + "/" + Path.GetFileNameWithoutExtension(doc.FileName);
								}

								var resolution = new Aspose.Pdf.Devices.Resolution(300);
								var imageDevice = new Aspose.Pdf.Devices.EmfDevice(resolution);
								imageDevice.Process(doc.PdfDocument.Pages[pageCount], outPath + ".emf");
							}
							break;
						}
				}
			}

			
		}




		public class DocumentInfo
		{
			public Document PdfDocument { get; set; }
			public string FileName { get; set; }
		}


		///<Summary>
		/// IsValidRegex
		///</Summary>
		public static bool IsValidRegex(string pattern)
		{
			if (string.IsNullOrEmpty(pattern))
				return false;
			try
			{
				Regex.Match("", pattern);
			}
			catch (ArgumentException)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Prepare output folder for using when multiple files are uploaded
		/// Creates folder by filename without extension
		/// </summary>
		/// <param name="doc"></param>
		/// <param name="path">Zip folder name</param>
		/// <returns>Tuple(original filename, output folder)</returns>
		protected static (string, string) PrepareFolder(Document doc, string path)
		{
			var filename = Path.GetFileNameWithoutExtension(doc.FileName);
			var folder = path + "/";
			folder += filename;
			while (Directory.Exists(folder))
				folder += "_";
			folder += "/";
			Directory.CreateDirectory(folder);
			return (Path.GetFileName(doc.FileName), folder);
		}


	}

	public class SaveFormatType
	{
		public SaveOptions SaveOptions { get; set; }
		public SaveType? SaveType { get; set; }
	}
	public enum SaveType
	{
		doc,
		docx,
		xlsx,
		pptx,
		xml,
		xps,
		epub,
		tex,
		html,
		svg,
		bmp,
		png,
		tiff,
		jpg,
		emf,
		pdf
	}
	
}
