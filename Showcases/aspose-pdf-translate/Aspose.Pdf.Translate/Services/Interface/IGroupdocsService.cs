using GroupDocs.Translation.Cloud.Sdk.Api;

namespace Aspose.Pdf.Translate.Services.Interface
{
    public interface IGroupdocsService
    {
        Dictionary<string, string[]> SupportedTranslateLanguages { get; }

        Stream TranslateDocument(FormFile doc, string inputType, string pair, string name, string translatedName, FileApi fileApi, StorageApi storageApi, TranslationApi api, string app_storage);

        Dictionary<string, string[]> GetNonDirectTranslateLanguages();

        Dictionary<string, string[]> GetAllTranslateLanguages();
    }
}
