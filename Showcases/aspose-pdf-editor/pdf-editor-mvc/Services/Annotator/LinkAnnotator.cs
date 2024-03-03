using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class LinkAnnotator : IAnnotator
{
    private readonly LinkModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public LinkAnnotator(LinkModel model, string workFolder, string inputFile, string outputFile)
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
        
        // Create TextFragmentAbsorber object to find a phone number
        TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber(_model.Text);

        // Accept the absorber for the 1st page only
        document
            .Pages[_model.PageNumber]
            .Accept(textFragmentAbsorber);

        var phoneNumberFragment = textFragmentAbsorber.TextFragments[1];

        // Create Link Annotation and set the action to call a phone number
        var linkAnnotation = new LinkAnnotation(
            document.Pages[_model.PageNumber], 
            phoneNumberFragment.Rectangle)
        {
            Action = new GoToURIAction(_model.Url)
        };

        // Add annotation to page
        document
            .Pages[_model.PageNumber]
            .Annotations
            .Add(linkAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}