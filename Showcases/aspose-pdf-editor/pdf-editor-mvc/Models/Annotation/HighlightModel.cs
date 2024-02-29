using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class HighlightModel
{
    public PageModel Page { get; set; } = new PageModel();
    
    public TitleModel Title { get; set; } = new TitleModel();

    public string Text { get; set; } = "Test data";
}