using Aspose.Pdf.Translate.Model;
using Aspose.Pdf.Translate.Services.Interface;

namespace Aspose.Pdf.Translate.Services
{
    public class TranslateService : ITranslateService
    {
        private readonly IGroupdocsService groupDocsService;
        private readonly IStorageService storage;
        private readonly ILogger<TranslateService> logger;

        private readonly Dictionary<string, string> lang = new Dictionary<string, string>
            {
                {"en","english"},
                {"fr","french"},
                {"de","german"},
                {"it","italian"},
                {"es","spanish"},
                {"pt","portuguese"},
                {"pl","polish"},
                {"ru","russian"},
                {"ar","arabic"},
                {"zh","chinese"},
                {"az","azerbaijani"},
                {"lv","latvian"},
                {"lt","lithuanian"}
            };

        public TranslateService(
            IGroupdocsService groupDocsService,
            IStorageService storage,
            ILogger<TranslateService> logger)
        {
            this.groupDocsService = groupDocsService;
            this.storage = storage;
            this.logger = logger;
            this.logger = logger;
        }

        public async Task<FileResponse> TranslateFiles(string documentId,string from, string to, List<IFormFile> docs)
        {
            List<string> resultFiles = new List<string>();
            foreach (var doc in docs)
            {
                await using Stream outputStream = 
                    groupDocsService.TranslateDocument(
                            documentId,
                            doc, 
                            Path.GetExtension(doc.FileName).TrimStart('.').ToLower(),
                            from,
                            to,
                            doc.FileName);

                await storage.Upload(outputStream, doc.FileName);
                resultFiles.Add(doc.FileName);
            }

            return new FileResponse
            {
                FileProcessingErrorCode = 0,
                Files = resultFiles,
                FolderName = documentId
            };
        }
    }
}