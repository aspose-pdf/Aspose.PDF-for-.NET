using Aspose.Pdf.Translate.Model;
using Aspose.Pdf.Translate.Services.Interface;
using System.Text;
using System.Text.Json;

namespace Aspose.Pdf.Translate.Services
{
    public class StatusStorage : IStatusStorage
    {
        private readonly IStorageService storageService;

        public StatusStorage(IStorageService storageService)
        {
            this.storageService = storageService;
        }

        public async Task<FileResponse> CheckStatus(string documentId)
        {
            var stream = await storageService.Download(Path.Combine(documentId,"status.json"));

            if(stream == null) 
            {
                return new FileResponse 
                { 
                    FolderName = documentId, 
                    StatusCode = 204 
                };
            }

            return JsonSerializer.Deserialize<FileResponse>(stream);
        }
        public async Task UpdateStatus(FileResponse data)
        {
            var statusStr = JsonSerializer.Serialize(data);
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(statusStr));
            await storageService.Upload(ms, Path.Combine(data.FolderName, "status.json"));
        }
    }
}
