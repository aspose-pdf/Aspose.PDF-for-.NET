using System.Web.Mvc;

namespace Mvc5.Helpers
{
    public class PdfController : Controller
    {
        protected ActionResult PdfView(string fileDownloadName)
        {
            return PdfView(fileDownloadName: fileDownloadName);
        }

        protected ActionResult PdfView(string fileDownloadName, string viewName)
        {
            return PdfView(fileDownloadName: fileDownloadName, viewName: viewName);
        }

        protected ActionResult PdfView(object model)
        {
            return PdfView(model: model);
        }

        protected ActionResult PdfView(string fileDownloadName, object model)
        {
            return PdfView(fileDownloadName: fileDownloadName, model: model);
        }

        protected ActionResult PdfView(string fileDownloadName = null,
            Aspose.Pdf.HtmlLoadOptions options = null,
            string viewName = null,
            object model = null)
        {
            // Based on View() code in Controller base class from MVC
            if (model != null)
            {
                ViewData.Model = model;
            }
            var pdf = new PdfViewResult()
            {
                FileDownloadName = fileDownloadName,
                ViewName = viewName,
                ViewData = ViewData,
                TempData = TempData,
                ViewEngineCollection = ViewEngineCollection
            };
            return pdf;
        }
    }
}
