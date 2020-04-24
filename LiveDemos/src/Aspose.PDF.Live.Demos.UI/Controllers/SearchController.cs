using Aspose.Pdf.Live.Demos.UI.Models.Common;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	public class SearchController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];


		[HttpPost]
		public Response Search( string query)
		{
			Response response = null;
			if (Request.Files.Count > 0)
			{
				string _sourceFolder = Guid.NewGuid().ToString();
				var docs = UploadDocuments(Request, _sourceFolder);

				AsposePdfSearch asposePdfSearch = new AsposePdfSearch();
				response = asposePdfSearch.Search(docs, _sourceFolder , query);

			}

			return response;
		}
		public ActionResult Search()
		{
			var model = new ViewModel(this, "Search")
			{
				ControlsView = "SearchControls",
				
				MaximumUploadFiles = 1,
				DropOrUploadFileLabel = Resources["DropOrUploadFile"]
			};
			if (model.RedirectToMainApp)
				return Redirect("/pdf/" + model.AppName.ToLower());
			return View(model);
		}

	}
}
