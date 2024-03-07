using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class RedactAnnotator : IAnnotator
{
    private readonly RedactModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public RedactAnnotator(RedactModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Save()
    {
        // Open document
        Document document = new Document(Path.Combine(_workFolder, _inputFile));

        // Create RedactionAnnotation instance for specific page region
        RedactionAnnotation annotation = new RedactionAnnotation(
            document.Pages[_model.PageNumber],
            new Rectangle(
                _model.Llx,
                _model.Lly,
                _model.Urx,
                _model.Ury,
                _model.NormalizeCoordinates))
        {
            FillColor = _model.FillColorValue,
            BorderColor = _model.BorderColorValue,
            Color = _model.ColorValue,
            // Text to be printed on redact annotation
            OverlayText = _model.OverlayText,
            TextAlignment = _model.TextAlignmentValue,
            // Repat Overlay text over redact Annotation
            Repeat = _model.Repeat
        };

        // Add annotation to annotations collection of first page
        document
            .Pages[_model.PageNumber]
            .Annotations
            .Add(annotation);

        // Flattens annotation and redacts page contents (i.e. removes text and image
        // Under redacted annotation)
        annotation.Redact();

        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}