using Aspose.Pdf.Live.Demos.UI.Models.Common;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Services;
using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	public class ComparisonController : BaseController  
	{
		public override string Product => (string)RouteData.Values["product"];


		[HttpPost]
		public Response Comparison(string outputType)
		{
			Response response = null;
			if (Request.Files.Count > 0)
			{
				string _sourceFolder = Guid.NewGuid().ToString();
				var docs = UploadDocuments(Request, _sourceFolder);

				AsposePdfComparison asposePdfComparison = new AsposePdfComparison();
				response = asposePdfComparison.Compare(_sourceFolder, docs);

			}

			return response;			
				
		}		

		public ActionResult Comparison()
		{
			var model = new ViewModel(this, "Comparison")
			{			
				
				DropOrUploadFileLabel = Resources["DropOrUploadFile"]
			};
			
			if (model.RedirectToMainApp)
				return Redirect("/pdf/" + model.AppName.ToLower());
			return View(model);
			
		}

	}
}
