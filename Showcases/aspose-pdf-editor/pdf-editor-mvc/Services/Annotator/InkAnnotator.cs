using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class InkAnnotator : IAnnotator
{
    private readonly InkModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public InkAnnotator(InkModel model, string workFolder, string inputFile, string outputFile)
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
        
        Page page = document.Pages[_model.Position.PageNumber];

        InkAnnotation annotation = new InkAnnotation(
            page, 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates),
            (IList<Point[]>)new List<Point[]> { _model
                .Points
                .Select(p => new Point(p.X, p.Y))
                .ToArray() })
        {
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.ColorValue,
            Opacity = _model.Title.Opacity,
            CapStyle = _model.CapStyleValue,
        };
        
        annotation.Border = new Border(annotation)
        {
            Width = _model.Border
        };
        
        page.Annotations.Add(annotation);

        // Save output file
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}