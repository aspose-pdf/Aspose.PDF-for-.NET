using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
    public class AsposePdfRedaction : AsposePdfBase
	{
		/// <summary>
		/// Redact documents
		/// </summary>
		
		public Response Redact(DocumentInfo[] docs, string sourceFolder, string searchQuery, string replaceText,
		  bool caseSensitive, bool text, bool comments, bool metadata)
		{
			
			if (docs == null)
				return BadDocumentResponse;
			if (docs.Length == 0 || docs.Length > MaximumUploadFiles)
				return MaximumFileLimitsResponse;

			SetDefaultOptions(docs, "");
			Opts.AppName = "Redaction";
			Opts.MethodName = "Redact";
			Opts.ZipFileName = "Redacted documents";
			Opts.FolderName = sourceFolder;
			Opts.OutputType = ".pdf";

			if (replaceText == null)
				replaceText = "";

			var statusValue = "OK";
			var statusCodeValue = 200;
			var fileProcessingErrorCode = FileProcessingErrorCode.OK;
			var lck = new object();
			var catchedException = false;

			if (IsValidRegex(searchQuery))
			{
				var regex = new Regex(searchQuery, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
				var matchesFound = new int[docs.Length];
				var tasks = Enumerable.Range(0, docs.Length).Select(i => Task.Factory.StartNew(() =>
				{
					try
					{
						var document = docs[i].PdfDocument;
						if (text)
						{
							var tfa = new Aspose.Pdf.Text.TextFragmentAbsorber(searchQuery, new TextSearchOptions(true));
							tfa.Visit(document);
							foreach (var textFragment in tfa.TextFragments)
							{
								textFragment.Text = replaceText;
								matchesFound[i] += 1;
							}
						}

						if (comments)
						{
							foreach (var page in document.Pages)
							{
								foreach (var item in page.Annotations)
								{
									if (item is TextMarkupAnnotation)
									{
										item.Contents = Regex.Replace(item.Contents, searchQuery, replaceText);
										matchesFound[i] += 1;
									}
								}
							}
						}

						if (metadata)
						{
							Pdf.DocumentInfo docInfo = new Pdf.DocumentInfo(document);
							docInfo.Title = System.Text.RegularExpressions.Regex.Replace(docInfo.Title, searchQuery, replaceText);
							docInfo.Keywords = System.Text.RegularExpressions.Regex.Replace(docInfo.Keywords, searchQuery, replaceText);
							matchesFound[i] += 2;
						}




						//if (text || comments)
						//{
						//	var findings = new RedactionCallback(text, comments);
						//	var options = new FindReplaceOptions()
						//	{
						//		ReplacingCallback = findings,
						//		Direction = FindReplaceDirection.Forward,
						//		MatchCase = caseSensitive
						//	};
						//	docs[i].Range.Replace(regex, replaceText, options);
						//	matchesFound[i] += findings.MatchesFound;
						//}

						//if (metadata)
						//	matchesFound[i] += ProcessMetadata(docs[i].PdfDocument, regex, replaceText);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
						lock (lck)
							catchedException = true;
						
					}
				})).ToArray();
				Task.WaitAll(tasks);

				if (!catchedException)
				{
					if (matchesFound.Sum() > 0)
						return  Process((inFilePath, outPath, zipOutFolder) =>
						{
							foreach (var doc in docs)
								SaveDocument(doc, outPath, zipOutFolder, new SaveFormatType() { SaveOptions = new PdfSaveOptions(), SaveType = SaveType.pdf });
						});

					fileProcessingErrorCode = FileProcessingErrorCode.NoSearchResults;
				}
				else
				{
					statusCodeValue = 500;
					statusValue = "500 Exception during processing";
				}
			}
			else
				fileProcessingErrorCode = FileProcessingErrorCode.WrongRegExp;

			return new Response
			{
				Status = statusValue,
				StatusCode = statusCodeValue,
				FileProcessingErrorCode = fileProcessingErrorCode
			};
		}

		
	}
}
