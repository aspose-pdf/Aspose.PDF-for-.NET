using Aspose.Pdf.Live.Demos.UI.Models.Common;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

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
				return Redirect("/pdf/" + model.AppName.ToLower());
			return View(model);		
			
		}	

	}
}
