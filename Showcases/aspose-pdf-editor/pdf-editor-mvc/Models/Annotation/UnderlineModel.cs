using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class UnderlineModel
{
    public int PageNumber { get; set; } = 1;

    public string Title { get; set; } = "title";

    public string Subject { get; set; } = "subject";

    [JsonIgnore]
    public Color? ColorValue
    {
        get
        {
            return (Aspose.Pdf.Color)Enum.Parse(typeof(Aspose.Pdf.Color), Color);
        }
    }

    public string Color { get; set; } = "Aqua";

    public double Opacity { get; set; } = 0.5;

    public string Text { get; set; } = "Test data";
}