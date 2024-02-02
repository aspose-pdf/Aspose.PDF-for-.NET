namespace Aspose.Pdf.Translate.Services.Interface
{
    public interface IGroupdocsService
    {
        Task<Stream> TranslateDocument(string documentId, byte[] fileData, string inputType, string from, string to, string fileName);
    }
}
