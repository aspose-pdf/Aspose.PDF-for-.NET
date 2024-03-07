using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class LineAnnotator : IAnnotator
{
    private readonly LineModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public LineAnnotator(LineModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Save()
    {
        // Load the PDF file
        Document document = new Document(Path.Combine(_workFolder, _inputFile));

        // Create Line Annotation
        var lineAnnotation = new LineAnnotation(
            document.Pages[_model.PageNumber],
            new Rectangle(
                _model.Llx,
                _model.Lly,
                _model.Urx,
                _model.Ury,
                _model.NormalizeCoordinates),
            new Point(_model.StartX, _model.StartY),
            new Point(_model.EndX, _model.EndY))
        {
            Title = _model.Title,
            Subject = _model.Subject,
            Color = _model.ColorValue,
            Opacity = _model.Opacity,
            Width = _model.Width,
            StartingStyle = _model.StartingStyleValue,
            EndingStyle = _model.EndingStyleValue,
            Popup = new PopupAnnotation(
                document.Pages[_model.PopupPageNumber],
                new Rectangle(
                    _model.PopupLlx,
                    _model.PopupLly,
                    _model.PopupUrx,
                    _model.PopupUry,
                    _model.PopupNormalizeCoordinates))
        };

        // Add annotation to the page
        document
            .Pages[_model.PageNumber]
            .Annotations
            .Add(lineAnnotation);

        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}