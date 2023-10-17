namespace Aspose.PDF.Editor.Services.Interface;

public interface IDocumentServicecs
{
    Task<string> AppendConverter(Stream docStream, Stream appendStream, string folder,
    string appPages, string appRatios, string appHeights);
}
