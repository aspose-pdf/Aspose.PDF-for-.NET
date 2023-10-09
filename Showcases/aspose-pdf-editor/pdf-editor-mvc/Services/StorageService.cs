using Aspose.Pdf;
using Aspose.PDF.Editor.Services.Interface;
using System.Runtime.InteropServices;

namespace Aspose.PDF.Editor.Services;

public class StorageService : IStorageService
{
    private const string WorkingDirectoryWin = "c:\\temp\\";
    private const string WorkingDirectoryLinux = "./temp/";

    private string _rootDir;

    public StorageService(IHostEnvironment env) 
    {
        _rootDir = env.ContentRootPath;
    }

    public string WorkingDirectory =>
        RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ?
            WorkingDirectoryWin :
            WorkingDirectoryLinux;

    public async Task Upload(Stream inputStream, string storageFile)
    {
        if (inputStream == null) throw new ArgumentNullException(nameof(inputStream));
        if (storageFile == null) throw new ArgumentNullException(nameof(storageFile));

        var path = Path.IsPathRooted(storageFile) ? storageFile : Path.Combine(WorkingDirectory, storageFile);

        var dir = Path.GetDirectoryName(path);
        if (!Directory.Exists(dir))
        {
            if (dir != null)
                Directory.CreateDirectory(dir);
        }

        await using (var fs = File.OpenWrite(path))
        {
            await inputStream
                .CopyToAsync(fs)
                .ContinueWith(_ => inputStream.Close());
        }
    }

    public async Task<Stream> Download(string storageFile)
    {
        if (storageFile == null) throw new ArgumentNullException(nameof(storageFile));
        
        var path = Path.IsPathRooted(storageFile)
            ? storageFile
            : Path.Combine(WorkingDirectory, storageFile);

        var dir = Path.GetDirectoryName(path);
        if (!Directory.Exists(dir))
        {
            if (dir != null) Directory.CreateDirectory(dir);
        }

        if (!File.Exists(path))
        {
            using (var newDoc = new Document())
            {
                newDoc.Pages.Add();
                newDoc.Save(path);
            }
        }

        var outputStream = new MemoryStream();

        await using (Stream docStream = File.OpenRead(path))
        {
            await docStream.CopyToAsync(outputStream);
        }

        outputStream.Seek(0, SeekOrigin.Begin);

        return outputStream;
    }

    public void Delete(string storageFile)
    {
        if (storageFile == null) throw new ArgumentNullException(nameof(storageFile));
        
        var path = Path.Combine(_rootDir, storageFile);
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}