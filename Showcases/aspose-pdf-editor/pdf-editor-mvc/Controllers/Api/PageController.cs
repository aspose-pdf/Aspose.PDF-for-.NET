using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PageController : Controller
{
    private readonly IStorageService _storageService;
    private readonly IImageService _imageService;

    public PageController(IStorageService storageService, IImageService imageService)
    {
        _storageService = storageService;
        _imageService = imageService;
    }

    [HttpGet]
    [Route("preview/{folder}/{filename}")]
    public async Task<FileContentResult> GetPageImage(string folder, string filename)
    {
        //converting Pdf file into bytes array
        int extensionPosition = filename.LastIndexOf('-');
        int extensionPosition2 = filename.LastIndexOf('.');
        if (extensionPosition != -1 && extensionPosition2 < extensionPosition)
        {
            filename = filename.Remove(extensionPosition, 1).Insert(extensionPosition, ".");
        }

        var url = Path.Combine(folder, filename);
        await using (Stream imgStream = await _storageService.Download(url))
        {
            using var bs = new BinaryReader(imgStream);
            byte[] content = bs.ReadBytes((int)imgStream.Length);

            return File(content, "image/png");
        }
    }

    [HttpPost]
    [Route("add/{folder}")]
    public async Task<DocStatusModelN> AddPage(string folder)
    {
        var url = Path.Combine(folder, "document.pdf");
        int pageCount = 0;
        await using (Stream docStream = await _storageService.Download(url))
        {
            using (MemoryStream ms = new MemoryStream())
            using (Document doc = new Document(docStream))
            {
                doc.Pages.Add();
                doc.Save(ms);
                pageCount = doc.Pages.Count;
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url);

                var imageFileName = "image" + pageCount + ".png";
                using (MemoryStream imageStream = new MemoryStream())
                {
                    //create PNG device with specified attributes
                    PngDevice pngDevice = new PngDevice(new Resolution(150));
                    //Convert a particular page and save the image to stream
                    pngDevice.Process(doc.Pages[pageCount], imageStream);

                    var (height, aspectRatio) =  await _imageService.ScaleImage(imageStream, folder, imageFileName, 1138);
                    return new DocStatusModelN
                    {
                        D = $"image{pageCount}.png#{height}#{aspectRatio}",
                        Path = folder,
                        Heights = height
                    };
                }
            }
        }
    }

    [HttpPut]
    [Route("move")]
    public async Task<MovePagesModelN> MovePages([FromBody] MovePagesModelN movePagesModel)
    {
        var url = Path.Combine(movePagesModel.DocumentId, "document.pdf");

        await using (Stream docStream = await _storageService.Download(url))
        {
            int pageFrom = Convert.ToInt32(movePagesModel.MoveFrom);
            int pageTo = Convert.ToInt32(movePagesModel.MoveTo);
            List<string> str = movePagesModel.PageList.ToList();

            using var doc = new Document(docStream);
            var page = doc.Pages[pageFrom];

            doc.Pages.Insert(pageTo + 1, page);

            if (pageFrom > pageTo)
            {
                doc.Pages.Delete(pageFrom + 1);
                str.Insert(pageTo, movePagesModel.PageList[pageFrom - 1]);
                str.RemoveAt(pageFrom);
            }
            else
            {
                doc.Pages.Delete(pageFrom);
                str.Insert(pageTo, movePagesModel.PageList[pageFrom - 1]);
                str.RemoveAt(pageFrom - 1);
            }

            using MemoryStream ms = new MemoryStream();
            doc.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            await _storageService.Upload(ms, url);
            movePagesModel.PageList = str.ToArray();

            return movePagesModel;
        }
    }

    [HttpDelete]
    [Route("delete")]
    public async Task<DeletePageModelN> DeletePage([FromBody] DeletePageModelN deletePageModel)
    {
        var url = Path.Combine(deletePageModel.DocumentId, "document.pdf");
        var imgUrl = Path.Combine(deletePageModel.DocumentId, deletePageModel.ImageName);

        await using (Stream docStream = await _storageService.Download(url))
        {
            using Document doc = new Document(docStream);
            doc.Pages.Delete(Convert.ToInt32(deletePageModel.ImageData));
            using MemoryStream ms = new MemoryStream();
            doc.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            await _storageService.Upload(ms, url);
            _storageService.Delete(imgUrl);
            return deletePageModel;
        }
    }
}
