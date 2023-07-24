using Aspose.Pdf.Live.Demos.UI.Models;
using System;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
    public class ConversionController : BaseController
    {
        public override string Product => (string)RouteData.Values["product"];


        [HttpPost]
        public Response Conversion(string outputType)
        {
            Response response = null;
            if (Request.Files.Count > 0)
            {
                string _sourceFolder = Guid.NewGuid().ToString();
                var docs = UploadDocuments(Request, _sourceFolder);

                AsposePdfConversion pdfConversion = new AsposePdfConversion();
                response = pdfConversion.ConvertFile(docs, outputType, _sourceFolder);

            }

            return response;

        }


        public ActionResult Conversion()
        {
            var model = new ViewModel(this, "Conversion")
            {
                SaveAsComponent = true,
                SaveAsOriginal = false,
                MaximumUploadFiles = 1,
                DropOrUploadFileLabel = Resources["DropOrUploadFile"]
            };

            return View(model);
        }


    }
}
