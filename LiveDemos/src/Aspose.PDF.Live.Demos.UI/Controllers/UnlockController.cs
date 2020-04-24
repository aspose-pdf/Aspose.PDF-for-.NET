using Aspose.Pdf.Live.Demos.UI.Models.Common;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	public class UnlockController : BaseController  
	{
		public override string Product => (string)RouteData.Values["product"];


		[HttpPost]
		public Response Unlock(string outputType, string passw)
		{
			Response response = null;
			if (Request.Files.Count > 0)
			{
				string _folderName = Guid.NewGuid().ToString();
				var docs =  UploadFiles(Request, _folderName);

				AsposePdfUnlock asposePdfUnlock = new AsposePdfUnlock();
				response = asposePdfUnlock.Unlock(docs, passw, _folderName);

			}

			return response;				
		}
		public ActionResult Unlock()
		{
			var model = new ViewModel(this, "Unlock")
			{
				ControlsView = "UnlockControls",
				SaveAsComponent = true,
				MaximumUploadFiles = 10,
				DropOrUploadFileLabel = Resources["DropOrUploadFiles"],
				ShowViewerButton = false
			};
			if (model.RedirectToMainApp)
				return Redirect("/pdf/" + model.AppName.ToLower());
			return View(model);			
		}	

	}
}
