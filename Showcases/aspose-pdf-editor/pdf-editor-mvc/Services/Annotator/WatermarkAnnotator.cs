using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class WatermarkAnnotator : IAnnotator
{
    private readonly WatermarkModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public WatermarkAnnotator(WatermarkModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }
    
    public void Save()
    {
        //Load a Document
        Document document = new Document(Path.Combine(_workFolder, _inputFile));

        //Create Annotation
        WatermarkAnnotation annotation = new WatermarkAnnotation(
            document.Pages[_model.PageNumber],
            new Rectangle(
                _model.Llx,
                _model.Lly,
                _model.Urx,
                _model.Ury,
                _model.NormalizeCoordinates))
        {
            Opacity = _model.Opacity
        };

        //Create TextState for Font settings
        TextState ts = new TextState
        {
            ForegroundColor = _model.ForegroundColorValue,
            Font = FontRepository.FindFont(_model.Font),
            FontSize = _model.FontSize
        };
        
        //Add Text in Annotation
        annotation.SetTextAndState(_model.Text, ts);
        
        // Add annotation to the page
        document
            .Pages[_model.PageNumber]
            .Annotations
            .Add(annotation);

        //Save the Document
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}