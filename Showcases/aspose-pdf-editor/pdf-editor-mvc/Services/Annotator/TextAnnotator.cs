using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class TextAnnotator : IAnnotator
{
    private readonly TextModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public TextAnnotator(TextModel model, string workFolder, string inputFile, string outputFile)
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

        // Create annotation
        TextAnnotation textAnnotation = new TextAnnotation(
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
            Contents = _model.Contents,
            Open = _model.Open,
            Icon = _model.IconValue
        };

        Border border = new Border(textAnnotation);
        border.Width = _model.Border;
        textAnnotation.Border = border;

        // Add annotation in the annotations collection of the page
        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(textAnnotation);
        
        // Save output file
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}