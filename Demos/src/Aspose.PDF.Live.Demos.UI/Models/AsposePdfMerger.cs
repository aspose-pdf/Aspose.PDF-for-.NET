using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf;
using Aspose.Pdf.Facades;


namespace Aspose.Pdf.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposePdfMerger class to merge pdf file
	///</Summary>
	public class AsposePdfMerger : AsposePdfBase
	{
		
		public Response MergePdfsToOne(string sourceFolder, DocumentInfo[] docs,  string inputType, string outputType)
		{
			var outType = outputType.Trim().ToLower();
			
			if (docs == null)
				return BadDocumentResponse;
			if (docs.Length <= 1 || docs.Length > MaximumUploadFiles)
				return MaximumFileLimitsResponse;

			SetDefaultOptions(docs, outputType);
			Opts.AppName = "Merger";
			Opts.MethodName = "Merge";
			Opts.FolderName = sourceFolder;
			Opts.ResultFileName = $"Merged document.pdf";
			Opts.CreateZip = false;
			Opts.ZipFileName = "Merged document";
			Opts.OutputType = outType;

			var saveOpt = GetSaveOptions(outType);

			return  Process((inFilePath, outPath, zipOutFolder) =>
			{
				var outputDoc = new Document();
				foreach (var docInfo in docs)
				{
					foreach (var page in docInfo.PdfDocument.Pages)
						outputDoc.Pages.Add(page);
				}
				outputDoc.Save(outPath, saveOpt.SaveOptions);
			});
		}

		public Response MergeImagesToFormats( string sourceFolder, Aspose.Pdf.Live.Demos.UI.Models.Common.InputFiles files , string outputType)
		{
			
			if (files == null)
				return BadDocumentResponse;
			if (files.Count < 1 || files.Count > MaximumUploadFiles)
				return MaximumFileLimitsResponse;

			SetDefaultOptions(files, outputType);
			Opts.AppName = "Merger";
			Opts.FolderName = sourceFolder;
			Opts.MethodName = "Merge";
			Opts.ResultFileName = $"Merged document.pdf";
			Opts.CreateZip = false;
			Opts.ZipFileName = "Merged document";

			var saveOpt = GetSaveOptions(outputType.ToLower());

			return  Process((inFilePath, outPath, zipOutFolder) =>
			{
				var resDoc = new Document();
				foreach (var file in files)
				{
					Image image = new Image();
					image.ImageStream = new FileStream(file.FullFileName, FileMode.Open, FileAccess.Read);
					var page = resDoc.Pages.Add();
					page.PageInfo.Margin.Bottom = 0;
					page.PageInfo.Margin.Top = 0;
					page.PageInfo.Margin.Left = 0;
					page.PageInfo.Margin.Right = 0;
					if (!".svg".Equals(System.IO.Path.GetExtension(file.FullFileName).ToLower()))
					{
						var imageSize = System.Drawing.Image.FromStream(image.ImageStream).Size;
						page.PageInfo.Width = imageSize.Width;
						page.PageInfo.Height = imageSize.Height;
					}
					page.Paragraphs.Add(image);
				}
				resDoc.Save(outPath, saveOpt.SaveOptions);
			});
		}

		
	}
}
