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
            document.Pages[_model.PageNumber], 
            new Rectangle(
                _model.Llx, 
                _model.Lly, 
                _model.Urx,
                _model.Ury,
                _model.NormalizeCoordinates))
        {
            Title = _model.Title,
            Subject = _model.Subject,
            Color = _model.ColorValue,
            Opacity = _model.Opacity,
            InteriorColor = _model.InteriorColorValue,
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
            .Add(squareAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}