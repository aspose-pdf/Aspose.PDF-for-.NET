using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class CaretAnnotator : IAnnotator
{
    private readonly CaretModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public CaretAnnotator(
        CaretModel model,
        string workFolder,
        string inputFile,
        string outputFile)
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

        // This annotation is used to indicate the insertion of text
        var caretAnnotation = new CaretAnnotation(
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
            Flags = _model.FlagsValue,
            Color = _model.ColorValue,
            Opacity = _model.Opacity
        };

        document
            .Pages[_model.PageNumber]
            .Annotations
            .Add(caretAnnotation);

        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}