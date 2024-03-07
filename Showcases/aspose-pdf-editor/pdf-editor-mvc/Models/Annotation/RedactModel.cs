using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class RedactModel
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

    [JsonIgnore]
    public Color FillColorValue
    {
        get
        {
            return Aspose.Pdf.Color.Parse(FillColor);
        }
    }

    public string FillColor { get; set; } = "Aqua";

    [JsonIgnore]
    public Color BorderColorValue
    {
        get
        {
            return Aspose.Pdf.Color.Parse(BorderColor);
        }
    }

    public string BorderColor { get; set; } = "Black";

    [JsonIgnore]
    public Color ColorValue
    {
        get
        {
            return Aspose.Pdf.Color.Parse(Color);
        }
    }

    public string Color { get; set; } = "Beige";

    public string OverlayText { get; set; } = "CENSORED";

    [JsonIgnore]
    public HorizontalAlignment TextAlignmentValue
    {
        get
        {
            return (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), TextAlignment);
        }
    }

    public string TextAlignment { get; set; } = "Center";

    public bool Repeat { get; set; } = true;
}