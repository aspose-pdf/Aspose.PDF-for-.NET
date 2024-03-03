using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class CircleModel
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

    [JsonIgnore]
    public Color InteriorColorValue
    {
        get
        {
            return (Aspose.Pdf.Color)Enum.Parse(typeof(Aspose.Pdf.Color), InteriorColor);
        }
    }

    public string InteriorColor { get; set; } = "Aqua";

    public int PopupPageNumber { get; set; } = 1;

    ///X of lower left corner
    public double PopupLlx { get; set; } = 10;

    ///Y of lower left corner
    public double PopupLly { get; set; } = 10;

    ///X of upper right corner
    public double PopupUrx { get; set; } = 20;

    ///Y of upper right corner
    public double PopupUry { get; set; } = 20;

    ///Normalize coordinates of rectangle
    public bool PopupNormalizeCoordinates { get; set; } = true;
}