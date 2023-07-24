using Aspose.Pdf.Live.Demos.UI.Models;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
    public class MetadataController : BaseController
    {
        public override string Product => (string)RouteData.Values["product"];






        public ActionResult Metadata()
        {
            var model = new ViewModel(this, "Metadata")
            {

                UploadAndRedirect = true,
                ControlsView = "MetadataControls",


                MaximumUploadFiles = 1,
                DropOrUploadFileLabel = Resources["DropOrUploadFile"]

            };


            if (model.RedirectToMainApp)
            {
                return Redirect("/pdf/" + model.AppName.ToLower());
            }

            return View(model);

        }

    }
}
