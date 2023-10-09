using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AttachmentController : Controller
{
    private readonly IStorageService _storageService;

    public AttachmentController(IStorageService storageService)
    {
        _storageService = storageService;
    }

    [HttpPost]
    public async Task<DocStatusModel> Upload()
    {
        var httpRequest = HttpContext.Request;
        var documentId = httpRequest.Form.Keys.Contains("documentId") &&
                         httpRequest.Form["documentId"][0] != null ? 
            httpRequest.Form["documentId"][0] : 
            Guid.NewGuid().ToString();
        var fullPath = Path.Combine(
            _storageService.WorkingDirectory,
            documentId);

        var postedFile = httpRequest.Form.Files.FirstOrDefault();

        if (postedFile == null)
            throw new ArgumentException("no files");

        var documentFileName = Path.Combine(fullPath, "document.pdf");
        using MemoryStream ms = new MemoryStream();
        using (PdfContentEditor contentEditor = new PdfContentEditor())
        {
            contentEditor.BindPdf(documentFileName);
            await using (var fs = postedFile.OpenReadStream())
            {
                contentEditor.AddDocumentAttachment(
                    fs,
                    postedFile.FileName,
                    "File added by Aspose.PDF Editor");
                contentEditor.Save(ms);
            }    
        }

        var url = Path.Combine(httpRequest.Form["documentId"], "document.pdf");
        await _storageService.Upload(ms, url);

        return new DocStatusModel
        {
            D = postedFile.FileName,
            Path = httpRequest.Form["documentId"]
        };
    }

    [HttpPost]
    [Route("all/{folder}")]
    public async Task<FileAttachmentsModel> GetFileAttachments(string folder)
    {
        var url = Path.Combine(folder, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        string outAttach = "";

        // Open document
        using (Document pdfDocument = new Document(docStream))
        {
            // Get embedded files collection
            EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
            // Loop through the collection to get all the attachments
            foreach (FileSpecification fileSpecification in embeddedFiles)
            {
                outAttach = outAttach + "," + fileSpecification.Name + "," + fileSpecification.Description;
            }

            if (outAttach.Length > 1)
            {
                outAttach = outAttach.Substring(1);
            }
        }

        var model = new FileAttachmentsModel
        {
            D = outAttach
        };

        return model;
    }

    [HttpPost]
    [Route("remove")]
    public async Task<FileAttachmentsModel> RemoveFileAttachment([FromBody] RemoveAttachmentModel removeAttachmentModel)
    {
        var url = Path.Combine(removeAttachmentModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        // Open document
        using (Document pdfDocument = new Document(docStream))
        {
            EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
            embeddedFiles.Delete(removeAttachmentModel.AttachmentFileName);
            using MemoryStream ms = new MemoryStream();
            pdfDocument.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            await _storageService.Upload(ms, url);
        }

        var model = new FileAttachmentsModel
        {
            D = "Success",
            Path = HttpContext.Request.Form["documentId"]
        };

        return model;
    }
}
