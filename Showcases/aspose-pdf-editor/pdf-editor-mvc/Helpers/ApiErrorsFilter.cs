namespace Aspose.PDF.Editor.Helpers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.AspNetCore.Mvc.Infrastructure;

    public class ApiErrorsFilter : IExceptionFilter
    {
        private readonly ProblemDetailsFactory _problemDetailsFactory;

        public ApiErrorsFilter(ProblemDetailsFactory problemDetailsFactory) => _problemDetailsFactory = problemDetailsFactory;

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var httpContext = context.HttpContext;

            var problemDetails = _problemDetailsFactory.CreateProblemDetails(httpContext, statusCode: 500, title: "API error", detail: exception.ToString());
            context.Result = new ObjectResult(problemDetails)
            {
                StatusCode = problemDetails.Status
            };

            context.ExceptionHandled = true;
        }
    }
}