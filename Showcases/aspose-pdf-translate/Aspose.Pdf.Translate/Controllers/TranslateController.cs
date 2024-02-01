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
        private readonly IStatusStorage statusStorage;

        public TranslateController(
            ITranslateService translateService,
            IStatusStorage statusStorage) 
        {
            this.translateService = translateService;
            this.statusStorage = statusStorage;
        }

        [HttpPost]
        [Route("")]
        public FileResponse Upload(string from, string to)
        {
            var files = HttpContext.Request.Form.Files;
            var documentId = Guid.NewGuid().ToString();
            Task.Run(() => translateService.TranslateFiles(documentId, from, to, files.ToList()));
            return new FileResponse { FolderName = documentId, StatusCode = 204 };
        }

        [HttpGet]
        [Route("/api/status/{documentId}")]
        public async Task<FileResponse> GetStatus(string documentId)
        {
            return await statusStorage.CheckStatus(documentId);
        }

        [HttpGet]
        [Route("/api/download/{documentId}")]
        public void Download(string documentId)
        {

        }
    }
}
