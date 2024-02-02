namespace Aspose.Pdf.Translate.Services.Interface
{
    public interface IStorageService
    {
        Task Upload(Stream inputStream, string storageFile);
        Task<Stream?> Download(string storageFile);
    }
}
