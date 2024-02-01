using Aspose.Pdf.Translate.Model;

namespace Aspose.Pdf.Translate.Services.Interface
{
    public interface ITranslateService
    {
        Task<FileResponse> TranslateFiles(string documentId, string from, string to, List<IFormFile> docs);
    }
}
