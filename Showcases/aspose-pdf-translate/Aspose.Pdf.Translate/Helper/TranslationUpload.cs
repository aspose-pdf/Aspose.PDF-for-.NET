using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;


namespace Aspose.Pdf.Translate.Helper
{
    public class TranslationUpload
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiUrl = "https://api.groupdocs.cloud/v2.0/translation/pdf";

        public TranslationUpload(string apiKey)
        {
            _httpClient = new HttpClient();
            _apiKey = apiKey;
        }

        public async Task<HttpResponseMessage> SendTranslationRequest(TranslationRequest request)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            var response = await _httpClient.PostAsJsonAsync(_apiUrl, request);
            return response;
        }
    }
}
