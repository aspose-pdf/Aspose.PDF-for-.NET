using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class LinkModel
{
    public int PageNumber { get; set; } = 1;

    public string Text { get; set; } = "Test data";

    public string Url { get; set; } = "http://google.com";
}