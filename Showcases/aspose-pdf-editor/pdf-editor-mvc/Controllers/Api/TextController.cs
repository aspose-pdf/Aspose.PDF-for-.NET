using Aspose.Pdf;
using Aspose.Pdf.Text;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TextController : Controller
{
    private const string SearchMarker = "Aspose.PDF Editor Free App Search";

    private readonly IStorageService _storageService;
    private readonly IImageService _imageService;

    public TextController(IStorageService storageService, IImageService imageService)
    {
        _storageService = storageService;
        _imageService = imageService;
    }

    [HttpPost]
    [Route("search")]
    public async Task<DocInfoModel> SearchData([FromBody] SearchDataModel searchDataModel)
    {
        var url = Path.Combine(searchDataModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        using Document document = new Document(docStream);
        TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber(searchDataModel.SearchText);
        textFragmentAbsorber.Visit(document);
        foreach (var textFragment in textFragmentAbsorber.TextFragments)
        {
            textFragment.Page.Annotations.Add(
                new Pdf.Annotations.HighlightAnnotation(textFragment.Page, textFragment.Rectangle)
                {
                    Title = SearchMarker
                }
            );
        }

        using MemoryStream ms = new MemoryStream();
        document.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);
        var model = new DocInfoModel
        {
            Pages = await _imageService.ImageConverter(ms, searchDataModel.DocumentId, "document.pdf"),
            DocumentId = searchDataModel.DocumentId
        };
        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, url);

        return model;
    }

    [HttpDelete]
    [Route("clear")]
    public async Task<DocInfoModel> SearchClear([FromBody] SearchDataModel searchDataModel)
    {
        var url = Path.Combine(searchDataModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        using Document document = new Document(docStream);
        foreach (var page in document.Pages)
        {
            var annotations = page.Annotations
                .Where(a => a.AnnotationType == Pdf.Annotations.AnnotationType.Highlight)
                .Cast<Pdf.Annotations.HighlightAnnotation>();
            foreach (var highlightAnnotation in annotations)
            {
                if (highlightAnnotation.Title.Equals(SearchMarker))
                    page.Annotations.Delete(highlightAnnotation);
            }
        }

        using MemoryStream ms = new MemoryStream();
        document.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);

        var model = new DocInfoModel
        {
            Pages = await _imageService.ImageConverter(ms, searchDataModel.DocumentId, "document.pdf"),
            DocumentId = searchDataModel.DocumentId
        };
        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, url);

        return model;
    }

    [HttpPut]
    [Route("replace")]
    public async Task<DocInfoModel> ReplaceText([FromBody] ReplaceTextModel replaceTextModel)
    {
        var url = Path.Combine(replaceTextModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);
        using Document doc = new Document(docStream);

        TextFragmentAbsorber textFragmentAbsorber =
            new TextFragmentAbsorber(replaceTextModel.TxtFind);

        doc.Pages.Accept(textFragmentAbsorber);

        //get the extracted text fragments
        TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;

        //loop through the fragments
        foreach (TextFragment textFragment in textFragmentCollection)
        {
            //update text and other properties
            textFragment.Text = replaceTextModel.TxtReplace;
        }

        using MemoryStream ms = new MemoryStream();
        doc.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);
        var model = new DocInfoModel
        {
            Pages = await _imageService.ImageConverter(ms, replaceTextModel.DocumentId, "document.pdf"),
            DocumentId = replaceTextModel.DocumentId
        };
        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, url);

        return model;
    }
}
