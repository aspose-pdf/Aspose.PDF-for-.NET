using System.IO;
using System.Threading.Tasks;

namespace Aspose.PDF.Editor.Services.Interface
{
    public interface IImageService
    {
        Task<string> ImageConverter(Stream docStream, string folder, string fileName);
        Task<(string, string)> ScaleImage(Stream imgStream, string folder, string fileName, int maxWidth);
    }
}