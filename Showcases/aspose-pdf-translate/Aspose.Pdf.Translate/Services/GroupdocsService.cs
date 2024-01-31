using Aspose.Pdf.Translate.Services.Interface;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using System.Web;

namespace Aspose.Pdf.Translate.Services
{
    public class GroupdocsService : IGroupdocsService
    {
        private readonly Configuration conf;

        public GroupdocsService() 
        {
            conf = new Configuration
            {
                ClientId = Environment.GetEnvironmentVariable("Translate_ClientId"),
                ClientSecret = Environment.GetEnvironmentVariable("Translate_ClientSecret")
            };
        }

        public Stream TranslateDocument(
        FormFile doc,
        string inputType,
        string pair,
        string name,
        string translatedName,
        FileApi fileApi,
        StorageApi storageApi,
        TranslationApi api,
        string app_storage)
        {
            FileApi fileApi = new FileApi(conf);
            StorageApi storageApi = new StorageApi(conf);
            TranslationApi api = new TranslationApi(conf);

            var app_storage = Environment.GetEnvironmentVariable("Translate_Storage");

            using Stream stream = doc.OpenReadStream();
            stream.Position = 0;

            var originalFileExists = new ObjectExistsRequest
            {
                storageName = app_storage,
                path = name
            };

            var originalFileExist = storageApi.ObjectExists(originalFileExists);
            if (originalFileExist.Exists == true)
            {
                var originalFileRequest = new DeleteFileRequest
                {
                    path = name,
                    storageName = app_storage
                };
                fileApi.DeleteFile(originalFileRequest);
            }

            var translatedFileExists = new ObjectExistsRequest
            {
                path = translatedName,
                storageName = app_storage
            };
            var translatedFileExist = storageApi.ObjectExists(translatedFileExists);
            if (translatedFileExist.Exists == true)
            {
                var translatedFileRequest = new DeleteFileRequest
                {
                    path = translatedName,
                    storageName = app_storage
                };
                fileApi.DeleteFile(translatedFileRequest);
            }

            var uploadRequest = new UploadFileRequest
            {
                File = stream,
                path = name,
                storageName = app_storage
            };

            FilesUploadResult uploadResult = fileApi.UploadFile(uploadRequest);
            if (uploadResult.Errors.Count != 0)
            {
                throw new Exception("Error while uploading file to ML");
            }

            TranslateDocumentRequest request = api.CreateDocumentRequest(name,
                "",
                pair,
                inputType,
                inputType,
                app_storage,
                translatedName,
                "",
                false,
                new List<int>(),
                details: true);

            TranslationResponse response = null;
            translatedFileExist = storageApi.ObjectExists(translatedFileExists);
            if (translatedFileExist.Exists == true)
            {
                var translatedFileRequest = new DeleteFileRequest
                {
                    path = translatedName,
                    storageName = app_storage
                };
                fileApi.DeleteFile(translatedFileRequest);
            }

            response = api.RunTranslationTask(request);


            if (response?.Status != "ok")
            {
                throw new Exception("Error while translating file:" + response?.Message + " " + response?.Details);
            }

            var downloadRequest = new DownloadFileRequest
            {
                path = translatedName,
                storageName = app_storage
            };
            MemoryStream ms = new MemoryStream();
            try
            {
                using (var stream1 = fileApi.DownloadFile(downloadRequest))
                {
                    stream1.CopyTo(ms);
                    ms.Seek(0, SeekOrigin.Begin);
                }
            }
            finally
            {
                originalFileExist = storageApi.ObjectExists(originalFileExists);
                if (originalFileExist.Exists == true)
                {
                    var originalFileRequest = new DeleteFileRequest
                    {
                        path = name,
                        storageName = app_storage
                    };
                    fileApi.DeleteFile(originalFileRequest);
                }

                translatedFileExists = new ObjectExistsRequest
                {
                    path = translatedName,
                    storageName = app_storage
                };
                translatedFileExist = storageApi.ObjectExists(translatedFileExists);
                if (translatedFileExist.Exists == true)
                {
                    var translatedFileRequest = new DeleteFileRequest
                    {
                        path = translatedName,
                        storageName = app_storage
                    };
                    fileApi.DeleteFile(translatedFileRequest);
                }
            }

            return ms;
        }

        public readonly Dictionary<string, string[]> SupportedTranslateLanguages = new Dictionary<string, string[]>
        {
            { "english", new [] { "french", "german", "italian", "spanish", "portuguese", "polish", "russian", "arabic", "chinese", "lithuanian", "latvian", "azerbaijani" } },
            { "french", new [] { "english", "german", "italian" } },
            { "german", new [] { "english", "french" } },
            { "italian", new [] { "english", "french" } },
            { "spanish", new [] { "english" } },
            { "portuguese", new [] { "english" } },
            { "polish", new [] { "english" } },
            { "russian", new [] { "english" } },
            { "arabic", new [] { "english" } },
            { "chinese", new [] { "english" } }
        };

        public Dictionary<string, string[]> GetNonDirectTranslateLanguages()
        {
            var allLanguages = SupportedTranslateLanguages["english"].Union(new[] { "english" });
            return SupportedTranslateLanguages
                .Select(pair => new { src = pair.Key, dest = allLanguages.Except(pair.Value).Except(new[] { pair.Key }).ToArray() })
                .ToDictionary(pair => pair.src, pair => pair.dest);
        }

        public Dictionary<string, string[]> GetAllTranslateLanguages()
        {
            var allLanguages = SupportedTranslateLanguages["english"].Union(new[] { "english" });
            return SupportedTranslateLanguages
                .Select(pair => new { src = pair.Key, dest = allLanguages.Except(new[] { pair.Key }).ToArray() })
                .ToDictionary(pair => pair.src, pair => pair.dest);
        }

        public string GetSafeInputName(string folderName, string fileName)
        {
            return HttpUtility.UrlEncode(folderName.Substring(0, 4) + Path.GetFileNameWithoutExtension(fileName).Substring(0, Path.GetFileNameWithoutExtension(fileName).Length > 8 ? 8 : Path.GetFileNameWithoutExtension(fileName).Length) + Path.GetExtension(fileName));
        }

        public string GetSafeOutputName(string folderName, string fileName, string inputType)
        {
            return HttpUtility.UrlEncode(folderName.Substring(0, 4) + Path.GetFileNameWithoutExtension(fileName).Substring(0, Path.GetFileNameWithoutExtension(fileName).Length > 8 ? 8 : Path.GetFileNameWithoutExtension(fileName).Length) + $"1.{inputType}");
        }
    }
}
