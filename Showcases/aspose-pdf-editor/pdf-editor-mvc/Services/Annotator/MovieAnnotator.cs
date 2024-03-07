using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class MovieAnnotator : IAnnotator
{
    private readonly MovieModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public MovieAnnotator(MovieModel model, string workFolder, string inputFile, string outputFile)
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

        var mediaFile = System.IO.Path.Combine(_workFolder, _model.MediaFile);

        // Create Screen Annotation
        var screenAnnotation = new ScreenAnnotation(
            document.Pages[_model.PageNumber],
            new Rectangle(
                _model.Llx,
                _model.Lly,
                _model.Urx,
                _model.Ury,
                _model.NormalizeCoordinates),
            mediaFile);

        document
            .Pages[_model.PageNumber]
            .Annotations
            .Add(screenAnnotation);

        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}