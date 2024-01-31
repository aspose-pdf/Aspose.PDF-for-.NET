using System.Collections.ObjectModel;
using Aspose.Foundation.UriResolver.RequestResponses;
using Aspose.Pdf.Translate.Model;
using Aspose.Pdf.Translate.Services.Interface;

namespace Aspose.Pdf.Translate.Services
{
    public class TranslateService
    {
        private const int TranslatePages = 3;
        private const int CharsPerPage = 3000;
        private readonly IGroupdocsService groupDocsService;
        private readonly IStorageService storage;
        private readonly IStatusStorage statusStorage;
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

        public TranslateWorker(
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

        protected async Task<Response> TranslateFiles(
            string documentId, 
            string inputType, 
            string from, 
            string to, 
            bool translateAllPages, 
            List<FormFile> files)
        {
            if (!groupDocsService.GetNonDirectTranslateLanguages().ContainsKey(lang[from.ToLower()]) ||
                   groupDocsService.GetNonDirectTranslateLanguages()[lang[from.ToLower()]]
                    .All(l => l != lang[to.ToLower()]))
            {
                return await ProcessDocumentBlock(documentId, inputType, from, to, translateAllPages, files);
            }
            else
            {
                var intermediate = await ProcessDocumentBlock(documentId, inputType, from, "en", translateAllPages, files, true);

                if (intermediate.StatusCode == 200 && intermediate is FileResponse response)
                {
                    List<FormFile> intremediateFiles = new List<FormFile>();
                    List<Stream> streams = new List<Stream>();
                    if (response.Files != null)
                    {
                        foreach (var fileName in response.Files)
                        {
                            var file = Path.Combine(outputFolder, fileName);
                            var fs = File.OpenRead(file);
                            var ms = new MemoryStream();
                            await fs.CopyToAsync(ms);
                            fs.Close();
                            File.Delete(file);
                            intremediateFiles.Add(new FormFile(ms, 0, ms.Length, fileName, fileName));

                            streams.Add(fs);
                            streams.Add(ms);
                        }
                    }
                    else
                    {
                        var file = Path.Combine(outputFolder, response.FileName);
                        var fs = File.OpenRead(file);

                        var ms = new MemoryStream();
                        await fs.CopyToAsync(ms);
                        fs.Close();
                        File.Delete(file);
                        intremediateFiles.Add(new FormFile(ms, 0, ms.Length, response.FileName, response.FileName));

                        streams.Add(fs);
                        streams.Add(ms);
                    }

                    return await ProcessDocumentBlock(documentId, inputType, "en", to, translateAllPages, intremediateFiles);
                }

                return intermediate;
            }
        }

        public async Task<Response> ProcessDocumentBlock(
            string documentId, 
            string inputType, 
            string from, 
            string to, 
            bool? translateAll, 
            List<FormFile> docs, 
            bool intermediate = false)
        {
            List<string> resultFiles = new List<string>();
            foreach (var doc in docs)
            {
                await using Stream outputStream = groupdocsService.TranslateDocument(
                            workItem, inputType,
                            from + "-" + to,
                            GetSafeInputName(opts.FolderName, workItem.FileName),
                            GetSafeOutputName(opts.FolderName, workItem.FileName, inputType),
                            fileApi,
                            storageApi,
                            api,
                            app_storage);

                var workingStream = outputStream;

                if (File.Exists(resultFilePath))
                {
                    File.Delete(resultFilePath);
                }

                await using (var fileStream = File.Create(resultFilePath))
                {
                    workingStream.Seek(0, SeekOrigin.Begin);
                    await workingStream.CopyToAsync(fileStream);
                    fileStream.Close();
                }

                resultFiles.Add(Path.GetFileName(resultFilePath));
            }

            if (!intermediate)
            {
                return await AfterAction(opts, outputFolder, resultFilePath, resultFiles.ToArray());
            }

            var intermediateResponse = FileResponse.Complete(new List<FileSafeResult>(), opts.FolderName, opts.FileName);
            intermediateResponse.Files = new Collection<string>(resultFiles.ToArray());

            return intermediateResponse;
        }
    }
}