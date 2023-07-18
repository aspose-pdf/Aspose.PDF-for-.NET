using Aspose.Pdf.Live.Demos.UI.Models.Common;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Services;
using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	public class XFAController : BaseController  
	{
		public override string Product => (string)RouteData.Values["product"];


		[HttpPost]
		public Response XFA(string inputType)
		{
			Response response = null;
			if (Request.Files.Count > 0)
			{
				string _sourceFolder = Guid.NewGuid().ToString();
				var docs =  UploadDocuments(Request, _sourceFolder);

				AsposePdfConversion pdfConversion = new AsposePdfConversion();
				response = pdfConversion.XfaConvert(docs, _sourceFolder, inputType);

			}

			return response;			
				
		}
		

		public ActionResult XFA()
		{
			var model = new ViewModel(this, "Xfa")
			{
				//SaveAsComponent = true,
				//SaveAsOriginal = false,
				MaximumUploadFiles = 10,
				DropOrUploadFileLabel = Resources["DropOrUploadFiles"]
			};

			return View(model);
		}
		

	}
}
