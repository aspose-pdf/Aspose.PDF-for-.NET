using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class ScreenAnnotator : IAnnotator
{
    private readonly ScreenModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public ScreenAnnotator(ScreenModel model, string workFolder, string inputFile, string outputFile)
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
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates),
            mediaFile);
        
        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(screenAnnotation);

        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}