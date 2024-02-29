using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class UnderlineAnnotator : IAnnotator
{
    private readonly UnderlineModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public UnderlineAnnotator(UnderlineModel model, string workFolder, string inputFile, string outputFile)
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
        
        var textFragmentAbsorber = new Aspose.Pdf.Text.TextFragmentAbsorber(_model.Text);
        textFragmentAbsorber.Visit(document.Pages[_model.Page.PageNumber]);

        //Create annotations
        UnderlineAnnotation underlineAnnotation = new UnderlineAnnotation(
            document.Pages[_model.Page.PageNumber],
            textFragmentAbsorber.TextFragments[1].Rectangle)
        {
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.ColorValue,
            Opacity = _model.Title.Opacity
        };
        
        // Add annotation to the page
        document
            .Pages[_model.Page.PageNumber]
            .Annotations
            .Add(underlineAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}