using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class SquareAnnotator : IAnnotator
{
    private readonly SquareModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public SquareAnnotator(SquareModel model, string workFolder, string inputFile, string outputFile)
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

        // Create Square Annotation
        var squareAnnotation = new SquareAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates))
        {
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.ColorValue,
            Opacity = _model.Title.Opacity,
            InteriorColor = _model.InteriorColorValue,
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
            .Add(squareAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}