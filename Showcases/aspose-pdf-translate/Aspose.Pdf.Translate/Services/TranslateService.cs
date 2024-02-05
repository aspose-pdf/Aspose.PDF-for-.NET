using Aspose.Pdf.Translate.Model;
using Aspose.Pdf.Translate.Services.Interface;

namespace Aspose.Pdf.Translate.Services
{
    public class TranslateService : ITranslateService
    {
        private readonly IGroupdocsService groupDocsService;
        private readonly IStorageService storage;
        private readonly IStatusStorage statusStorage;
        private readonly ILogger<TranslateService> logger;

        public TranslateService(
            IGroupdocsService groupDocsService,
            IStorageService storage,
            IStatusStorage statusStorage,
            ILogger<TranslateService> logger)
        {
            this.groupDocsService = groupDocsService;
            this.storage = storage;
            this.statusStorage = statusStorage;
            this.logger = logger;
        }

        public async Task<FileResponse> TranslateFiles(string documentId, string from, string to, List<IFormFile> docs)
        {
            var job = docs.Select(doc =>
            {
                MemoryStream ms = new MemoryStream();
                doc.CopyTo(ms);
                return new
                {
                    Raw = ms.ToArray(),
                    doc.FileName
                };
            });

            Task.Run(async () => 
            {
                try
                {
                    List<string> resultFiles = new List<string>();
                    foreach (var doc in job)
                    {
                        Stream outputStream = await
                            groupDocsService.TranslateDocument(
                                    documentId,
                                    doc.Raw,
                                    Path.GetExtension(doc.FileName).TrimStart('.').ToLower(),
                                    from,
                                    to,
                                    doc.FileName);

                        await storage.Upload(outputStream, Path.Combine(documentId, doc.FileName));
                        resultFiles.Add("Treanslated_" + doc.FileName);
                    }
                    var result = new FileResponse
                    {
                        FolderName = documentId,
                        Files = resultFiles,
                        StatusCode = 200
                    };

                    statusStorage.UpdateStatus(result);
                }
                catch(Exception ex)
                {
                    logger.LogError(ex.Message, ex);
                    var result = new FileResponse
                    {
                        FolderName = documentId,
                        StatusCode = 500
                    };

                    statusStorage.UpdateStatus(result);
                }
            });

            return new FileResponse { FolderName = documentId, StatusCode = 204 };
        }
    }
}