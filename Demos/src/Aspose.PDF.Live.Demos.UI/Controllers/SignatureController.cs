using Aspose.Pdf.Live.Demos.UI.Models.Common;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Services;
using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	public class SignatureController : BaseController  
	{
		public override string Product => (string)RouteData.Values["product"];

			

		public ActionResult Signature()
		{
			var model = new ViewModel(this, "Signature")
			{
				ControlsView = "SignatureControls",
				SaveAsComponent = true,
				MaximumUploadFiles = 1,
				DropOrUploadFileLabel = Resources["DropOrUploadFile"]
			};
			if (model.RedirectToMainApp)
				return Redirect("/pdf/" + model.AppName.ToLower());
			return View(model);

		}
		

	}
}
