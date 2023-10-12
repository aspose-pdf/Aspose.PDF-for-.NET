using Aspose.Pdf;
using Aspose.Pdf.Text;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DocumentController : Controller
{
    private readonly IStorageService _storageService;
    private readonly IImageService _imageService;

    public DocumentController(IStorageService storageService, IImageService imageService)
    {
        _storageService = storageService;
        _imageService = imageService;
    }

    [HttpGet]
    [Route("preview")]
    public async Task<DocStatusModel> Preview(string? folder, string? fileName)
    {
        if (string.IsNullOrWhiteSpace(folder))
        {
            folder = Guid.NewGuid().ToString();
            fileName = "document.pdf";
        }

        var downloadFileName = "document.pdf";

        var url = Path.Combine(folder, fileName);
        await using (Stream docStream = await _storageService.Download(url))
        {
            var model = new DocStatusModel
            {
                D = await _imageService.ImageConverter(docStream, folder, fileName),
                Path = folder,
                OriginalFileName = downloadFileName
            };

            return model;
        }
    }

    [HttpGet]
    [Route("download/{fileType}/{folder}")]
    public async Task<FileContentResult> Download(string fileType, string folder)
    {
        var downloadFileName = "document.pdf";
        string contentType = "application/pdf";
        switch (fileType)
        {
            case "docx":
                downloadFileName = "document.docx";
                contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                break;
            case "svg":
                downloadFileName = "document.svg";
                contentType = "image/svg+xml";
                break;
            case "xps":
                downloadFileName = "document.xps";
                contentType = "application/oxps, application/vnd.ms-xpsdocument";
                break;
            case "xls":
                downloadFileName = "document.xlsx";
                contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                break;
            case "html":
                downloadFileName = "document.html";
                contentType = "text/html";
                break;
        }

        var url = Path.Combine(folder, downloadFileName);
        await using (Stream docStream = await _storageService.Download(url))
        {
            using var bs = new BinaryReader(docStream);
            byte[] content = bs.ReadBytes((int)docStream.Length);

            return File(content, contentType);
        }
    }

    [HttpPost]
    [Route("export")]
    public async Task<DocStatusModelN> Export(string fileType, string folder)
    {
        var url = Path.Combine(folder, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        using var doc = new Document(docStream);
        using MemoryStream ms = new MemoryStream();
        switch (fileType)
        {
            case "txt":
                TextAbsorber textAbsorber = new TextAbsorber();
                doc.Pages.Accept(textAbsorber);
                string extractedText = textAbsorber.Text;
                var url6 = Path.Combine(folder, "document.txt");
                var ms1 = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(extractedText));
                ms1.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms1, url6);
                return new DocStatusModelN
                {
                    Path = folder,
                    OriginalFileName = "document.txt"
                };
            case "docx":
                doc.Save(ms, SaveFormat.DocX);
                var url1 = Path.Combine(folder, "document.docx");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url1);
                return new DocStatusModelN
                {
                    Path = folder,
                    OriginalFileName = "document.docx"
                };
            case "svg":
                doc.Save(ms, SaveFormat.Svg);
                var url2 = Path.Combine(folder, "document.svg");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url2);
                return new DocStatusModelN
                {
                    Path = folder,
                    OriginalFileName = "document.svg"
                };
            case "xps":
                doc.Save(ms, SaveFormat.Xps);
                var url3 = Path.Combine(folder, "document.xps");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url3);
                return new DocStatusModelN
                {
                    Path = folder,
                    OriginalFileName = "document.xps"
                };
            case "xls":
                doc.Save(ms, SaveFormat.Excel);
                var url4 = Path.Combine(folder, "document.xlsx");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url4);
                return new DocStatusModelN
                {
                    Path = folder,
                    OriginalFileName = "document.xlsx"
                };
            case "html":
                doc.Save(ms, new HtmlSaveOptions
                {
                    DocumentType = HtmlDocumentType.Html5,
                    PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml,
                    RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes
                        .AsEmbeddedPartsOfPngPageBackground
                });
                var url5 = Path.Combine(folder, "document.html");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url5);
                return new DocStatusModelN
                {
                    Path = folder,
                    OriginalFileName = "document.html"
                };
            case "pdf":
                doc.Save(ms, SaveFormat.Pdf);
                var url7 = Path.Combine(folder, "document.pdf");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url7);
                return new DocStatusModelN
                {
                    Path = folder,
                    OriginalFileName = "document.pdf"
                };
        }

        throw new NotSupportedException(fileType);
    }
}
