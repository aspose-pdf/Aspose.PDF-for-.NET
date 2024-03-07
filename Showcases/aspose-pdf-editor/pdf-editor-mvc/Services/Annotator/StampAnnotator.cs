using Aspose.Pdf;
using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation;

public class StampAnnotator : IAnnotator
{
    private readonly StampModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public StampAnnotator(StampModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Save()
    {
        File.Copy("./test.bmp", Path.Combine(_workFolder, "test.bmp"));

        // Open document
        Document pdfDocument = new Document(Path.Combine(_workFolder, _inputFile));

        // Create image stamp
        ImageStamp imageStamp = new ImageStamp(Path.Combine(_workFolder, _model.ImageFile))
        {
            Background = _model.Background,
            XIndent = _model.XIndent,
            YIndent = _model.YIndent,
            Height = _model.Height,
            Width = _model.Width,
            Rotate = _model.RotateValue,
            Opacity = _model.Opacity
        };

        // Add stamp to particular page
        pdfDocument
            .Pages[_model.PageNumber]
            .AddStamp(imageStamp);

        // Save output document
        pdfDocument.Save(Path.Combine(_workFolder, _outputFile));
    }
}