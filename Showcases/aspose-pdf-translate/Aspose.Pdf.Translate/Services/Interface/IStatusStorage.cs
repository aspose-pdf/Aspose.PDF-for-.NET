using Aspose.Pdf.Translate.Model;

namespace Aspose.Pdf.Translate.Services.Interface
{
    public interface IStatusStorage
    {
        Task<FileResponse> CheckStatus(string documentId);
        Task UpdateStatus(FileResponse data);
    }
}
