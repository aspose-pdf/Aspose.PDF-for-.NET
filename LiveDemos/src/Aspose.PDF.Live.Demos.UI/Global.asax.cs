using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Aspose.Pdf.Live.Demos.UI.Config;


namespace Aspose.Pdf.Live.Demos.UI
{
	public class Global : HttpApplication
	{
		
		protected void Application_Error(object sender, EventArgs e)
		{			
			
		}

		void Application_Start(object sender, EventArgs e)
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);			
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			RegisterCustomRoutes(RouteTable.Routes);
		}
		void Session_Start(object sender, EventArgs e)
		{
			//Check URL to set language resource file
			string _language = "EN";
			
			SetResourceFile(_language);
		}

		private void SetResourceFile(string strLanguage)
		{
			if (Session["AsposeAppResources"] == null)
				Session["AsposeAppResources"] = new GlobalAppHelper(HttpContext.Current, Application, Configuration.ResourceFileSessionName, strLanguage);
		}
		
			void RegisterCustomRoutes(RouteCollection routes)
		{
			routes.RouteExistingFiles = true;
			routes.Ignore("{resource}.axd/{*pathInfo}");
					

			routes.MapRoute(
				name: "Default",
				url: "Default",
				defaults: new { controller = "Home", action = "Default" }
			);
			
			routes.MapRoute(
				"AsposePDFConversionRoute",
				"{product}/Conversion",
				 new { controller = "Conversion", action = "Conversion" }
			);
			routes.MapRoute(
				"AsposePDFSearchRoute",
				"{product}/search",
				 new { controller = "Search", action = "Search" }
			);
			
			routes.MapRoute(
				"AsposePDFMergerRoute",
				"{product}/merger",
				 new { controller = "Merger", action = "Merger" }
			);
			routes.MapRoute(
				"AsposePDFRemoveAnnotationRoute",
				"annotation/remove",
				 new { controller = "Annotation", action = "Remove" }
			);
			routes.MapRoute(
				"AsposePDFComparisonRoute",
				"{product}/comparison",
				 new { controller = "Comparison", action = "Comparison" }
			);
			routes.MapRoute(
				"AsposePDFUnlockRoute",
				"{product}/unlock",
				 new { controller = "Unlock", action = "Unlock" }
			);
			routes.MapPageRoute(
				"AsposePdfWatermarkRoute",
				"pdf/watermark",
				"~/Watermark/AddWatermarkPdf.aspx"
			);
			routes.MapRoute(
				"AsposePDFViewerRoute",
				"{product}/viewer",
				 new { controller = "Viewer", action = "Viewer" }
			);
			routes.MapRoute(
				"AsposePDFSplitterRoute",
				"{product}/splitter",
				 new { controller = "Splitter", action = "Splitter" }
			);
			routes.MapRoute(
				"AsposePDFXFARoute",
				"{product}/xfa",
				 new { controller = "XFA", action = "XFA" }
			);
			routes.MapPageRoute(
			   "AsposePdfEditorRoute",
			   "pdf/editor",
			   "~/Editor/Editor.aspx"
		   );
			routes.MapRoute(
				"AsposePDFParserRoute",
				"{product}/parser",
				 new { controller = "Parser", action = "Parser" }
			);
			routes.MapRoute(
				"AsposePDFAnnotationRoute",
				"{product}/annotation",
				 new { controller = "Annotation", action = "Annotation" }
			);
			routes.MapRoute(
				"AsposePDFRedactionRoute",
				"{product}/redaction",
				 new { controller = "Redaction", action = "Redaction" }
			);
			routes.MapPageRoute(
			  "AsposePDFDefaultViewerRoute",
			  "pdf/view",
			  "~/ViewerApp/Default.aspx"
			);

			routes.MapRoute(
				"AsposePDFSignatureRoute",
				"{Product}/signature",
				 new { controller = "Signature", action = "Signature" }
			);
			routes.MapRoute(
				"DownloadFileRoute",
				"common/download",
				new { controller = "Common", action = "DownloadFile" }				
				
			);
			routes.MapRoute(
				"UploadFileRoute",
				"common/uploadfile",
				new { controller = "Common", action = "UploadFile" }

			);
		}

		private void MapProductToolPageRoute(RouteCollection routes, string routeName, string routeUrl, string physicalFile, string productRegex)
		{
			routes.MapPageRoute(routeName, routeUrl, physicalFile, false, null, new RouteValueDictionary { { "Product", productRegex } });
		}
	}
}
