using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class FreeTextModel
{
    public PageModel Page { get; set; } = new PageModel();

    public string Text { get; set; } = "test";

    public int X { get; set; } = 10;

    public int Y { get; set; } = 10;

    public int Width { get; set; } = 50;

    public int Height { get; set; } = 50;
}