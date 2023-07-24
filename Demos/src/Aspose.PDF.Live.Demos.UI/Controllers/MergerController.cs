using Aspose.Pdf.Live.Demos.UI.Models;
using System;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
    public class MergerController : BaseController
    {
        public override string Product => (string)RouteData.Values["product"];


        [HttpPost]
        public Response Merger(string inputType, string outputType)
        {
            Response response = null;
            AsposePdfMerger asposePdfMerger = new AsposePdfMerger();
            string _sourceFolder = Guid.NewGuid().ToString();
            if (Request.Files.Count > 0)
            {
                if (string.IsNullOrEmpty(inputType))
                {
                    return BadDocumentResponse;
                }

                if (inputType.ToLower().Equals("pdf") || inputType.ToLower().Equals("cgm"))
                {
                    var docs = UploadDocuments(Request, _sourceFolder);
                    return asposePdfMerger.MergePdfsToOne(_sourceFolder, docs, inputType, outputType);
                }
                else if (inputType.ToLower().Equals("jpg")
                         || inputType.ToLower().Equals("png")
                         || inputType.ToLower().Equals("bmp")
                         || inputType.ToLower().Equals("tiff"))
                {
                    return asposePdfMerger.MergeImagesToFormats(_sourceFolder, UploadFiles(Request, _sourceFolder), outputType);
                }
                else
                {
                    return BadDocumentResponse;
                }

            }

            return response;

        }



        public ActionResult Merger()
        {
            var model = new ViewModel(this, "Merger")
            {
                SaveAsComponent = true,
                SaveAsOriginal = false,
                MaximumUploadFiles = 10,
                UseSorting = true,
                DropOrUploadFileLabel = Resources["DropOrUploadFiles"]
            };

            return View(model);
        }


    }
}
