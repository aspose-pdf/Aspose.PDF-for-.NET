using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;
using Aspose.Pdf.Annotations;

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
    [Route("add")]
    public async Task<DocInfoModel> Upload()
    {
        var httpRequest = HttpContext.Request;
        var documentId = httpRequest.Form.Keys.Contains("documentId") &&
                         httpRequest.Form["documentId"][0] != null ?
            httpRequest.Form["documentId"][0] :
            Guid.NewGuid().ToString();

        var file = Path.Combine(_storageService.WorkingDirectory, documentId, "document.pdf");

        var formFile = httpRequest.Form.Files.FirstOrDefault();

        if (formFile == null)
            throw new ArgumentException("no files");

        using MemoryStream ms = new MemoryStream();
        using (PdfContentEditor contentEditor = new PdfContentEditor())
        {
            contentEditor.BindPdf(file);
            await using (var fs = formFile.OpenReadStream())
            {
                contentEditor.AddDocumentAttachment(
                    fs,
                    formFile.FileName,
                    "File added by Aspose.PDF Editor");
                contentEditor.Save(ms);
            }
        }

        await _storageService.Upload(ms, file);

        return new DocInfoModel
        {
            Pages = formFile.FileName,
            DocumentId = httpRequest.Form["documentId"]
        };
    }

    [HttpGet]
    [Route("all/{folder}")]
    public async Task<AttachmentModel> GetFileAttachments(string folder)
    {
        var file = Path.Combine(folder, "document.pdf");
        await using Stream docStream = await _storageService.Download(file);

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

        var model = new AttachmentModel
        {
            Files = outAttach
        };

        return model;
    }

    [HttpDelete]
    [Route("remove")]
    public async Task<AttachmentModel> RemoveFileAttachment([FromBody] RemoveAttachmentModel removeAttachmentModel)
    {
        var file = Path.Combine(removeAttachmentModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(file);

        // Open document
        using (Document pdfDocument = new Document(docStream))
        {
            EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
            embeddedFiles.Delete(removeAttachmentModel.FileName);
            using MemoryStream ms = new MemoryStream();
            pdfDocument.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            await _storageService.Upload(ms, file);
        }

        return await GetFileAttachments(removeAttachmentModel.DocumentId);
    }
}
