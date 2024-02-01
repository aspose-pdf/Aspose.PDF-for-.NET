using Aspose.Pdf.Translate.Model;
using Aspose.Pdf.Translate.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.Pdf.Translate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private readonly ITranslateService translateService;

        public TranslateController(ITranslateService translateService) 
        {
            this.translateService = translateService;
        }

        [HttpPost]
        [Route("")]
        public FileResponse Upload(string from, string to)
        {
            var files = HttpContext.Request.Form.Files;
            var documentId = Guid.NewGuid().ToString();
            Task.Run(() => translateService.TranslateFiles(documentId, from, to, files.ToList()));
            return new FileResponse { FolderName = documentId };
        }

        [HttpGet]
        [Route("get-status")]
        public void GetStatus(string documentId)
        {

        }

        [HttpGet]
        [Route("download")]
        public void Download(string documentId)
        {

        }
    }
}
