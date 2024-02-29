using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class FreeTextAnnotator : IAnnotator
{
    private readonly FreeTextModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public FreeTextAnnotator(FreeTextModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Save()
    {
        var document = new Document(Path.Combine(_workFolder, _inputFile));
        
        var pdfContentEditor = new PdfContentEditor(document);
        
        var rect = new System.Drawing.Rectangle
        {
            X = _model.X,
            Y = _model.Y,
            Width = _model.Width,
            Height = _model.Height
        };

        pdfContentEditor.CreateFreeText(
            rect, 
            _model.Text,
            _model.Page.PageNumber); // last param is a page number
        
        pdfContentEditor.Save(Path.Combine(_workFolder, _outputFile));
    }
}