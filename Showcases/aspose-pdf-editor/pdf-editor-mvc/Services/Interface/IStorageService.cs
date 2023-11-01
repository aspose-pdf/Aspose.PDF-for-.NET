using System.IO;
using System.Threading.Tasks;

namespace Aspose.PDF.Editor.Services.Interface
{
    public interface IStorageService
    {
        string WorkingDirectory { get; }
        Task Upload(Stream inputStream, string storageFile);
        Task<Stream> Download(string storageFile);
        void Delete(string storageFile);
    }
}