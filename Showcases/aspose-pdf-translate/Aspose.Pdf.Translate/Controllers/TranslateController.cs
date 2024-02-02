using Aspose.Pdf.Annotations;
using Aspose.Pdf.Translate.Model;
using Aspose.Pdf.Translate.Services;
using Aspose.Pdf.Translate.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System.IO.Compression;

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
            var status = await statusStorage.CheckStatus(documentId);
            if (status.Files.Count == 0)
            {
                throw new Exception("error code:" + status.FileProcessingErrorCode.ToString());
            }

            if (status.Files.Count == 1)
            {
                string contentType;
                new FileExtensionContentTypeProvider().TryGetContentType(status.Files[0], out contentType);

                var path = Path.Combine(documentId, status.Files[0]);
                Stream docStream = await storageService.Download(path);
                using var bs = new BinaryReader(docStream);
                byte[] content = bs.ReadBytes((int)docStream.Length);

                return File(content, contentType);
            }

            var zipStream = new MemoryStream();
            var archive = new ZipArchive(zipStream, ZipArchiveMode.Create, true);
            foreach (var file in status.Files)
            {
                var entity = archive.CreateEntry(file);
                using (var entryStream = entity.Open())
                {
                    var path = Path.Combine(documentId, status.Files[0]);
                    Stream docStream = await storageService.Download(path);
                    docStream.CopyTo(entryStream);
                }
            }
            return File(zipStream.ToArray(), "application/zip");
        }
    }
}
