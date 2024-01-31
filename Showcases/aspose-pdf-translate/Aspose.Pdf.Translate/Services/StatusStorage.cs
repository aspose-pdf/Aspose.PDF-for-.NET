using Aspose.Pdf.Translate.Model;
using Aspose.Pdf.Translate.Services.Interface;

namespace Aspose.Pdf.Translate.Services
{
    public class StatusStorage : IStatusStorage
    {
        public StatusStorage()
        {
        }

        public Task<FileResponse> CheckStatus(string documentId)
        {
            return null;
        }
        public async Task UpdateStatus(FileResponse data)
        {

        }
    }
}
