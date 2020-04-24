using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;


namespace Aspose.Pdf.Live.Demos.UI.Models
{

	///<Summary>
	/// AsposePdfSearch class to perform search operations on words document
	///</Summary>
	public class AsposePdfSearch : AsposePdfBase
	{
		// Yellow Color
		private static readonly Color HiglightedColor = Color.FromArgb(246, 247, 146);


		/// <summary>
		/// Search documents
		/// </summary>

		public Response Search(DocumentInfo[] docs, string sourceFolder, string query)
    {

			

			if (docs == null)
        return BadDocumentResponse;
      if (docs.Length == 0 || docs.Length > MaximumUploadFiles)
        return MaximumFileLimitsResponse;

      SetDefaultOptions(docs, "");
      Opts.AppName = "Search";
	  Opts.MethodName = "Search";
			Opts.FolderName = sourceFolder;
      Opts.OutputType = ".pdf";
      Opts.ResultFileName = "Search Results";
      Opts.CreateZip = false;

      var statusValue = "OK";
      var statusCodeValue = 200;
      var fileProcessingErrorCode = FileProcessingErrorCode.OK;

			if (IsValidRegex(query))
				try
				{
					return  Process((inFilePath, outPath, zipOutFolder) =>
					{
						foreach (var pdfDocument in docs)
						{
							var document = pdfDocument.PdfDocument;

							var tfa = new Aspose.Pdf.Text.TextFragmentAbsorber(query,
								new TextSearchOptions(IsValidRegex(query)));
							tfa.Visit(document);
							var found = tfa.TextFragments.Count > 0;
							foreach (var textFragment in tfa.TextFragments)
							{
								textFragment.Page.Annotations.Add(
									new HighlightAnnotation(textFragment.Page, textFragment.Rectangle)
									{
										Title = "Aspose.PDF Search Free App"
									}
								);
							}

							document.Save(outPath);
						}
					});

					//fileProcessingErrorCode = FileProcessingErrorCode.NoSearchResults;
				}
				catch (Exception ex)
				{
					
					statusCodeValue = 500;
					statusValue = "500 " + ex.Message;
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
