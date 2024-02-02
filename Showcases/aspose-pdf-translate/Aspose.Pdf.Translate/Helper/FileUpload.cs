using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;


namespace Aspose.Pdf.Translate.Helper
{
    public class FileUpload
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiUrl = "https://api.groupdocs.cloud/v2.0/translation/file/upload";

        public FileUpload(string apiKey)
        {
            _httpClient = new HttpClient();
            _apiKey = apiKey;
        }

        public async Task<HttpResponseMessage> SendFileRequest(string format, Stream fileStream, string fileName)
        {
            using (var content = new MultipartFormDataContent())
            {
                // Serialize the TranslationRequest to JSON
                //var jsonContent = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
                //content.Add(jsonContent, "request");

                // Create a file content from the stream
                var fileContent = new StreamContent(fileStream);
                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = fileName
                };
                fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                content.Add(fileContent);

                // Add the API key to the headers
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

                // Send the POST request
                var response = await _httpClient.PostAsync(_apiUrl+"?"+format, content);
                return response;
            }
        }
    }
}
