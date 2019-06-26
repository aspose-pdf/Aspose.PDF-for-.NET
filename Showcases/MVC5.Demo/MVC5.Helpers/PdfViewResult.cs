using Aspose.Pdf;
using System;
using System.IO;
using System.Text;
using System.Web.Mvc;

namespace Mvc5.Helpers
{
    public class PdfViewResult : ViewResult
    {
        public string FileDownloadName;
        public HtmlLoadOptions Options;
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            // Set the model and data
            context.Controller.ViewData.Model = Model;
            ViewData = context.Controller.ViewData;
            TempData = context.Controller.TempData;

            // Get the view name
            if (string.IsNullOrEmpty(ViewName))
            {
                ViewName = context.RouteData.GetRequiredString("action");
            }

            // Get the view
            ViewEngineResult viewEngineResult = null;
            if (View == null)
            {
                viewEngineResult = FindView(context);
                View = viewEngineResult.View;
            }

            // Render the view
            var sb = new StringBuilder();
            using (TextWriter tr = new StringWriter(sb))
            {
                var viewContext = new ViewContext(context, View, ViewData, TempData, tr);
                View.Render(viewContext, tr);
            }

            viewEngineResult?.ViewEngine.ReleaseView(context, View);
            var scheme = (context.RequestContext.HttpContext.Request.Url != null) ?
                context.RequestContext.HttpContext.Request.Url.Scheme : "http";
            var baseUri =
                $"{scheme}://{context.RequestContext.HttpContext.Request.Url.Authority}{context.RequestContext.HttpContext.Request.ApplicationPath}/";
            
            // Load HTML file            
            if (Options == null)
                Options = new Aspose.Pdf.HtmlLoadOptions(baseUri);
           

            var pdfDocument = new Document(new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString())), Options);
            using (var streamOut = new MemoryStream())
            {
                pdfDocument.Save(streamOut);
                streamOut.Seek(0, SeekOrigin.Begin);
                var result = new FileContentResult(streamOut.ToArray(), "application/pdf")
                {
                    FileDownloadName = FileDownloadName
                };
                result.ExecuteResult(context);
            }
        }        
    }
}
