using Aspose.Pdf.Translate.Services.Interface;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Client.Auth;
using GroupDocs.Translation.Cloud.Sdk.Model;
using Newtonsoft.Json;
using System.Web;

namespace Aspose.Pdf.Translate.Services
{
    public class GroupdocsService : IGroupdocsService
    {
        private readonly Configuration conf;

        public GroupdocsService() 
        {
            var clientId = Environment.GetEnvironmentVariable("Translate_ClientId");
            var clientSecret = Environment.GetEnvironmentVariable("Translate_ClientSecret");

            conf = new Configuration();
            new OAuthAuthenticator(
                "https://id.groupdocs.cloud/connect/token", 
                clientId, 
                clientSecret, 
                OAuthFlow.APPLICATION, 
                new JsonSerializerSettings(), 
                conf);
        }

        public Stream TranslateDocument(string documentId, FormFile doc, string inputType, string from, string to, string fileName)
        {
            FileApi fileApi = new FileApi(conf);
            TranslationApi api = new TranslationApi(conf);

            MemoryStream ms = new MemoryStream();
            doc.CopyTo(ms);

            var uploadResult = fileApi.FileUploadPost(inputType);
            StatusResponse postStatus = api.AutoPost(
                new FileRequest(
                    sourceLanguage: "en",
                    targetLanguages: new List<string> { "fr" },
                    file: ms.ToArray(),
                    originalFileName: GetSafeInputName(documentId, doc.FileName),
                    url: null,
                    origin: null,
                    savingMode: FileRequest.SavingModeEnum.Files,
                    format: FileRequest.FormatEnum.Pdf));

            return null;
        }

        private Dictionary<string, string[]> SupportedTranslateLanguages
        { get; }
        = new Dictionary<string, string[]>
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

        public string GetSafeInputName(string folderName, string fileName)
        {
            return HttpUtility.UrlEncode(folderName.Substring(0, 4) + Path.GetFileNameWithoutExtension(fileName).Substring(0, Path.GetFileNameWithoutExtension(fileName).Length > 8 ? 8 : Path.GetFileNameWithoutExtension(fileName).Length) + Path.GetExtension(fileName));
        }
    }
}
