using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;
using Aspose.PDF.Editor.Models.Annotation;
using aspose.pdf.annotation;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnnotationController : Controller
{
    private readonly IStorageService _storageService;
    private readonly IImageService _imageService;

    public AnnotationController(IStorageService storageService, IImageService imageService)
    {
        _storageService = storageService;
        _imageService = imageService;
    }

    [HttpPost]
    [Route("add/{documentId}")]
    public async Task<DocInfoModel> Add(string documentId, AnnotationModel model)
    {
        var httpRequest = HttpContext.Request;

        var file = Path.Combine(_storageService.WorkingDirectory, documentId, "document.pdf");

        if (model.Caret != null)
        {
            new CaretAnnotator(model.Caret, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Circle != null)
        {
            new CircleAnnotator(model.Circle, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.FreeText != null)
        {
            new FreeTextAnnotator(model.FreeText, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Highlight != null)
        {
            new HighlightAnnotator(model.Highlight, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Ink != null)
        {
            new InkAnnotator(model.Ink, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Line != null)
        {
            new LineAnnotator(model.Line, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Link != null)
        {
            new LinkAnnotator(model.Link, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Movie != null)
        {
            new MovieAnnotator(model.Movie, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Polygon != null)
        {
            new PolygonAnnotator(model.Polygon, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.PolyLine != null)
        {
            new PolyLineAnnotator(model.PolyLine, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Redact != null)
        {
            new RedactAnnotator(model.Redact, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Screen != null)
        {
            new ScreenAnnotator(model.Screen, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Sound != null)
        {
            new SoundAnnotator(model.Sound, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Square != null)
        {
            new SquareAnnotator(model.Square, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Squiggly != null)
        {
            new SquigglyAnnotator(model.Squiggly, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Stamp != null)
        {
            new StampAnnotator(model.Stamp, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.StrikeOut != null)
        {
            new StrikeOutAnnotator(model.StrikeOut, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Text != null)
        {
            new TextAnnotator(model.Text, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Underline != null)
        {
            new UnderlineAnnotator(model.Underline, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }
        if (model.Watermark != null)
        {
            new WatermarkAnnotator(model.Watermark, Path.Combine(_storageService.WorkingDirectory, documentId), "document.pdf", "document.pdf").Save();
        }

        Stream ms = await _storageService.Download(file);

        return new DocInfoModel
        {
            Pages = await _imageService.ImageConverter(ms, documentId, "document.pdf"),
            DocumentId = documentId
        };
    }
}
