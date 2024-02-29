using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class WatermarkModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    public string[] Text { get; set; } = new string[] { "test1", "test2" };

    public double Opacity { get; set; } = 0.5;

    [JsonIgnore]
    public Aspose.Pdf.Color ForegroundColorValue
    {
        get
        {
            return (Aspose.Pdf.Color)Enum.Parse(typeof(Aspose.Pdf.Color), ForegroundColor);
        }
    }

    public string ForegroundColor { get; set; } = "Aqua";

    public string Font { get; set; } = "Arial";

    public int FontSize { get; set; } = 20;
}