using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.PDF.Editor.Services.Interface;

namespace Aspose.PDF.Editor.Services;

public class DocumentServicecs : IDocumentServicecs
{
    private readonly IStorageService _storageService;
    private readonly IImageService _imageService;

    public DocumentServicecs(IStorageService storageService, IImageService imageService) 
    {
        _storageService = storageService;
        _imageService = imageService;
    }

    public async Task<string> AppendConverter(Stream docStream, Stream appendStream, string folder,
    string appPages, string appRatios, string appHeights)
    {
        using Document doc = new Document(docStream);
        int initialPageCount = doc.Pages.Count;

        //open second document
        using Document pdfDocument2 = new Document(appendStream);

        //add pages of second document to the first
        doc.Pages.Add(pdfDocument2.Pages);
        using MemoryStream ms = new MemoryStream();
        //save concatenated output file
        doc.Save(ms);

        var url = Path.Combine(folder, "document.pdf");

        await _storageService.Upload(ms, url);

        for (int pageIndex = initialPageCount + 1; pageIndex <= doc.Pages.Count; pageIndex++)
        {
            var imageFileName = "image" + pageIndex + ".png";
            using (MemoryStream imageStream = new MemoryStream())
            {
                PngDevice pngDevice = new PngDevice(new Resolution(150));
                pngDevice.Process(doc.Pages[pageIndex], imageStream);

                var r = await _imageService.ScaleImage(imageStream, folder, imageFileName, 1138);
                appPages = appPages + "," + "image" + pageIndex + ".png";
                appRatios = appRatios + "," + r.Item2;
                appHeights = appHeights + "," + r.Item1;
            }
        }

        return appPages + "%#" + appRatios + "%#" + appHeights;
    }
}
