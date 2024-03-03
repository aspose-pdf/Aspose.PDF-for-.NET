using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class WatermarkModel
{
    public int PageNumber { get; set; } = 1;

    ///X of lower left corner
    public double Llx { get; set; } = 10;

    ///Y of lower left corner
    public double Lly { get; set; } = 10;

    ///X of upper right corner
    public double Urx { get; set; } = 20;

    ///Y of upper right corner
    public double Ury { get; set; } = 20;

    ///Normalize coordinates of rectangle
    public bool NormalizeCoordinates { get; set; } = true;

    public string[] Text { get; set; } = new string[] { "test1", "test2" };

    public double Opacity { get; set; } = 0.5;

    [JsonIgnore]
    public Aspose.Pdf.Color ForegroundColorValue
    {
        get
        {
            return Aspose.Pdf.Color.Parse(ForegroundColor);
        }
    }

    public string ForegroundColor { get; set; } = "Aqua";

    public string Font { get; set; } = "Arial";

    public int FontSize { get; set; } = 20;
}