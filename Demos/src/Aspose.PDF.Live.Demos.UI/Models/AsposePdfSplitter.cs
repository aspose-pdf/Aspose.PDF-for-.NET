using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf;
using Aspose.Pdf.Facades;


namespace Aspose.Pdf.Live.Demos.UI.Models
{
	public class AsposePdfSplitter : AsposePdfBase
	{
	    ///<Summary>
	    /// Split method to split pdf document
	    ///</Summary>
	   
	    public Response Splitter(DocumentInfo[] docs, string sourceFolder)
	    {
		    
		    if (docs == null)
			    return BadDocumentResponse;
		    if (docs.Length <= 0 || docs.Length > MaximumUploadFiles)
			    return MaximumFileLimitsResponse;

		    SetDefaultOptions(docs, "");
		    Opts.AppName = "Splitter";
		    Opts.MethodName = "Splitter";
			Opts.FolderName = sourceFolder;
		    Opts.CreateZip = true;
		    Opts.ZipFileName = "Splitted document";

		    return  Process((inFilePath, outPath, zipOutFolder) =>
		    {
			    foreach (var doc in docs)
			    {
				    PdfFileEditor pdfEditor = new PdfFileEditor();
				    pdfEditor.SplitToPages(doc.FileName, $"{zipOutFolder}\\{Path.GetFileNameWithoutExtension(doc.FileName)}_%NUM%.pdf");
			    }
		    });
	    }

	   
		
		public Response SplitIntoSinglePages(string fileName, string folderName)
        {
			License.SetAsposePdfLicense();
            var statusValue = "OK";
            var statusCodeValue = 200;
            var fileProcessingErrorCode = FileProcessingErrorCode.OK;

            try
            {
                return  Process(GetType().Name, fileName, folderName, ".pdf", true, false,
                     "Split",
                  (inFilePath, outPath, zipOutFolder) =>
                  {
                      var document = new Aspose.Pdf.Document(inFilePath);
                      var outputNameTemplate = System.IO.Path.Combine(zipOutFolder, System.IO.Path.GetFileName(inFilePath));
                      outputNameTemplate = outputNameTemplate.Replace(".pdf", "_page_{0:000}.pdf");
                      for (int i = 1; i <= document.Pages.Count; i++)
                      {
                          using (var pageDoc = new Aspose.Pdf.Document())
                          {
                              pageDoc.Pages.Add(document.Pages[i]);
                              pageDoc.Save(string.Format(outputNameTemplate, i));
                          }
                      }                      
                  });
            }
            catch (Exception ex)
            {
                statusCodeValue = 500;
                statusValue = "500 " + ex.Message;
            }

            return new Response
            {
                FileName = fileName,
                FolderName = folderName,
                Status = statusValue,
                StatusCode = statusCodeValue,
                FileProcessingErrorCode = fileProcessingErrorCode
            };
        }
    }
}
