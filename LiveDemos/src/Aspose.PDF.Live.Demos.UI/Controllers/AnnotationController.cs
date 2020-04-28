using Aspose.Pdf.Live.Demos.UI.Models.Common;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	public class AnnotationController : BaseController  
	{
		public override string Product => (string)RouteData.Values["product"];


		[HttpPost]
		public Response Remove()
		{
			Response response = null;
			if (Request.Files.Count > 0)
			{
				string _sourceFolder = Guid.NewGuid().ToString();
				var docs =  UploadDocuments(Request, _sourceFolder);

				AsposePdfAnnotation asposePdfAnnotation = new AsposePdfAnnotation();
				response = asposePdfAnnotation.Remove(docs, _sourceFolder);

			}

			return response;				
		}
		public ActionResult Annotation()
		{
			var model = new ViewModel(this, "Annotation")
			{
				
				MaximumUploadFiles = 10,
				DropOrUploadFileLabel = Resources["DropOrUploadFiles"]
			};
			if (model.RedirectToMainApp)
				return Redirect("/pdf/" + model.AppName.ToLower());
			return View(model);			
		}	

	}
}
