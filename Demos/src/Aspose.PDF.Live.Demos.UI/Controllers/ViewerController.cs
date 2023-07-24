using Aspose.Pdf.Live.Demos.UI.Models;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
    public class ViewerController : BaseController
    {
        public override string Product => (string)RouteData.Values["product"];

        public ActionResult Viewer()
        {
            var model = new ViewModel(this, "Viewer")
            {
                MaximumUploadFiles = 1,
                DropOrUploadFileLabel = Resources["DropOrUploadFile"],
                UploadAndRedirect = true
            };
            if (model.RedirectToMainApp)
            {
                return Redirect("/pdf/" + model.AppName.ToLower());
            }

            return View(model);

        }

    }
}
