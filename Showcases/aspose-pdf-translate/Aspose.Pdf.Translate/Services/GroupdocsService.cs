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
                OAuthFlow = GroupDocs.Translation.Cloud.Sdk.Client.Auth.OAuthFlow.APPLICATION,
                OAuthClientId = Environment.GetEnvironmentVariable("Translate_ClientId"),
                OAuthClientSecret = Environment.GetEnvironmentVariable("Translate_ClientSecret")
            };
        }

        public async Task<Stream> TranslateDocument(string documentId, byte[] fileData, string inputType, string from, string to, string fileName)
        {
            var instance = new TranslationApi(conf);
            var fileApi = new FileApi(conf);

            var url = await fileApi.FileUploadPostAsync(
                FileTypeToFormat(inputType).ToString().ToLowerInvariant(),
                new MemoryStream(fileData));

            FileRequest autoPostRequest = new FileRequest()
            {
                SourceLanguage = from,
                TargetLanguages = new List<string> { to },
                Format = FileRequest.FormatEnum.Pdf,
                OutputFormat = FileTypeToFormat(inputType).ToString().ToLowerInvariant(),
                OriginalFileName = fileName,
                Url = url
            };
            var response = instance.AutoPost(autoPostRequest);

            for (int i = 0; i < 100; i++)
            {
                var status = instance.DocumentRequestIdGet(response.Id);
                if (status.Urls.Count > 0)
                {
                    var client = new HttpClient();
                    return await client.GetStreamAsync(status.Urls.First().Key);
                }
                await Task.Delay(1000);
            }

            throw new Exception("Timout for translate id=" + response.Id);
        }

        public string GetSafeInputName(string folderName, string fileName)
        {
            return HttpUtility.UrlEncode(folderName.Substring(0, 4) + Path.GetFileNameWithoutExtension(fileName).Substring(0, Path.GetFileNameWithoutExtension(fileName).Length > 8 ? 8 : Path.GetFileNameWithoutExtension(fileName).Length) + Path.GetExtension(fileName));
        }

        private FileRequest.FormatEnum FileTypeToFormat(string fileType)
        {
            switch(fileType?.ToLowerInvariant())
            {
                case "html":
                    return FileRequest.FormatEnum.Html;
                case "ppt":
                    return FileRequest.FormatEnum.Ppt;
                case "pptx":
                    return FileRequest.FormatEnum.Pptx;
                case "pptm":
                    return FileRequest.FormatEnum.Pptm;
                case "txt":
                    return FileRequest.FormatEnum.Txt;
                case "csv":
                    return FileRequest.FormatEnum.Csv;
                case "doc":
                    return FileRequest.FormatEnum.Doc;
                case "docm":
                    return FileRequest.FormatEnum.Docm;
                case "docx":
                    return FileRequest.FormatEnum.Docx;
                case "md":
                    return FileRequest.FormatEnum.Md;
                case "odp":
                    return FileRequest.FormatEnum.Odp;
                case "ods":
                    return FileRequest.FormatEnum.Ods;
                case "odt":
                    return FileRequest.FormatEnum.Odt;
                case "pdf":
                    return FileRequest.FormatEnum.Pdf;
                case "resx":
                    return FileRequest.FormatEnum.Resx;
                case "rtf":
                    return FileRequest.FormatEnum.Rtf;
                case "srt":
                    return FileRequest.FormatEnum.Srt;
                case "tsv":
                    return FileRequest.FormatEnum.Tsv;
                case "xls":
                    return FileRequest.FormatEnum.Xls;
                case "xlsm":
                    return FileRequest.FormatEnum.Xlsm;
                case "xlsx":
                    return FileRequest.FormatEnum.Xlsx;
                default:
                    throw new NotImplementedException(fileType);
            }
        }
    }
}
