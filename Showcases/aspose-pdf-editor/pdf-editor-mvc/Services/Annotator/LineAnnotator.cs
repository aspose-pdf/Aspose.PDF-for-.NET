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
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates),
            new Point(_model.Start.X, _model.Start.Y), 
            new Point(_model.End.X, _model.End.Y))
        {
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.ColorValue,
            Opacity = _model.Title.Opacity,
            Width = _model.Width,
            StartingStyle = _model.StartingStyleValue,
            EndingStyle = _model.EndingStyleValue,
            Popup = new PopupAnnotation(
                document.Pages[_model.Popup.PageNumber], 
                new Rectangle(
                    _model.Popup.Llx, 
                    _model.Popup.Lly, 
                    _model.Popup.Urx,
                    _model.Popup.Ury,
                    _model.Popup.NormalizeCoordinates))
        };

        // Add annotation to the page
        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(lineAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}