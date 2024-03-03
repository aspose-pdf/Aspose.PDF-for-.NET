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
            Contents = _model.Contents,
            Open = _model.Open,
            Icon = _model.IconValue
        };

        Border border = new Border(textAnnotation);
        border.Width = _model.Border;
        textAnnotation.Border = border;

        // Add annotation in the annotations collection of the page
        document
            .Pages[_model.PageNumber]
            .Annotations
            .Add(textAnnotation);
        
        // Save output file
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}