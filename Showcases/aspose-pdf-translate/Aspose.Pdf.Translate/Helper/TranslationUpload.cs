using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;


namespace Aspose.Pdf.Translate.Helper
{
    public class TranslationUpload
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiUrl = "https://api.groupdocs.cloud/v2.0/translation/auto";

        public TranslationUpload(string apiKey)
        {
            _httpClient = new HttpClient();
            _apiKey = apiKey;
        }

        public async Task<HttpResponseMessage> SendTranslationRequest(TranslationRequest request, Stream fileStream, string fileName)
        {
            using (var content = new MultipartFormDataContent())
            {
                // Serialize the TranslationRequest to JSON
                var jsonContent = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
                content.Add(jsonContent, "request");

                // Create a file content from the stream
                var fileContent = new StreamContent(fileStream);
                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = fileName
                };
                content.Add(fileContent);

                // Add the API key to the headers
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

                // Send the POST request
                var response = await _httpClient.PostAsync(_apiUrl, content);
                return response;
            }
        }
    }
}
