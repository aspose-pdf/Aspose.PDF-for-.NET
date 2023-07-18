using Aspose.Pdf.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Apps, On Premise &amp; Cloud Solution for PDF File Formats";
			ViewBag.MetaDescription = "Create PDF file manipulation applications using On Premise or Cloud APIs, or simply use cross-platform apps to view, compare, inspect or convert PDF files.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
