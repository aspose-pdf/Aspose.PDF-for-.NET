namespace Aspose.Pdf.Translate.Services.Interface
{
    public interface IGroupdocsService
    {
        Stream TranslateDocument(string documentId, IFormFile doc, string inputType, string from, string to, string fileName);
    }
}
