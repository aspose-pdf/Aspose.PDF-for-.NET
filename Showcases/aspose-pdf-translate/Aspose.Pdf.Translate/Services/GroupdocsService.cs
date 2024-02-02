using Aspose.Pdf.Translate.Helper;
using Aspose.Pdf.Translate.Services.Interface;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;
using System.Web;

namespace Aspose.Pdf.Translate.Services
{
    public class GroupdocsService : IGroupdocsService
    {
        private readonly Configuration conf;
        private readonly ILogger<GroupdocsService> logger;

        public GroupdocsService(ILogger<GroupdocsService> logger) 
        {
            this.logger = logger;
            conf = new Configuration
            {
                OAuthClientId = Environment.GetEnvironmentVariable("Translate_ClientId"),
                OAuthClientSecret = Environment.GetEnvironmentVariable("Translate_ClientSecret")
            };
        }

        public async Task<Stream> TranslateDocument(string documentId, byte[] fileData, string inputType, string from, string to, string fileName)
        {
            try
            {
                var token = await new TokenRetriever(conf.OAuthClientId, conf.OAuthClientSecret).GetTokenAsync();

                //await new FileUpload(token).SendFileRequest("Pdf", new MemoryStream(fileData), "1.pdf");

                var t = new TranslationRequest
                {
                    File = "1.pdf",
                    Format = "pdf",
                    OutputFormat = "pdf",
                    SourceLanguage = "en",
                    TargetLanguages = new List<string>() { "fr" },
                    OriginalFileName = "1.pdf",
                    
                };

                var res = await new TranslationUpload(token).SendTranslationRequest(t);

                return null;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return null;
            }
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
