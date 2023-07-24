using Aspose.Pdf.Live.Demos.UI.Models;
using System;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
    public class ParserController : BaseController
    {
        public override string Product => (string)RouteData.Values["product"];


        [HttpPost]
        public Response Parser(string outputType = "")
        {
            Response response = null;
            if (Request.Files.Count > 0)
            {
                string _sourceFolder = Guid.NewGuid().ToString();
                var docs = UploadDocuments(Request, _sourceFolder);

                AsposePdfParser pdfParser = new AsposePdfParser();
                response = pdfParser.Parse(docs, _sourceFolder);

            }

            return response;
        }

        public ActionResult Parser()
        {
            var model = new ViewModel(this, "Parser")
            {

                MaximumUploadFiles = 10,

                DropOrUploadFileLabel = Resources["DropOrUploadFiles"]
            };
            return View(model);
        }

    }
}
