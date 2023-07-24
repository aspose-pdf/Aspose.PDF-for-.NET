using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
    ///<Summary>
    /// MimeMultipart class
    ///</Summary>
    public class MimeMultipart : System.Web.Http.Filters.ActionFilterAttribute
    {
        ///<Summary>
        /// MimeMultipart class OnActionExecuting method
        ///</Summary>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(
                    new HttpResponseMessage(
                        HttpStatusCode.UnsupportedMediaType)
                );
            }
        }
        ///<Summary>
        /// MimeMultipart class OnActionExecuting method
        ///</Summary>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {

        }
    }
}
