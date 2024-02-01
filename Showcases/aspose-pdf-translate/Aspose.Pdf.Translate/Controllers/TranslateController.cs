using Aspose.Pdf.Annotations;
using Aspose.Pdf.Translate.Model;
using Aspose.Pdf.Translate.Services;
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
        private readonly IStorageService storageService;

        public TranslateController(
            ITranslateService translateService,
            IStatusStorage statusStorage,
            IStorageService storageService) 
        {
            this.translateService = translateService;
            this.statusStorage = statusStorage;
            this.storageService = storageService;
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
        public async Task<FileContentResult> Download(string documentId)
        {
            var downloadFileName = "translated.pdf";
            string contentType = "application/pdf";
            switch ("pdf")
            {
                case "docx":
                    downloadFileName = "translated.docx";
                    contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case "svg":
                    downloadFileName = "translated.svg";
                    contentType = "image/svg+xml";
                    break;
                case "xps":
                    downloadFileName = "translated.xps";
                    contentType = "application/oxps, application/vnd.ms-xpsdocument";
                    break;
                case "xls":
                    downloadFileName = "translated.xlsx";
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case "html":
                    downloadFileName = "translated.html";
                    contentType = "text/html";
                    break;
            }

            var file = Path.Combine(documentId, downloadFileName);
            await using (Stream docStream = await storageService.Download(file))
            {
                using var bs = new BinaryReader(docStream);
                byte[] content = bs.ReadBytes((int)docStream.Length);

                return File(content, contentType);
            }
        }
    }
}
