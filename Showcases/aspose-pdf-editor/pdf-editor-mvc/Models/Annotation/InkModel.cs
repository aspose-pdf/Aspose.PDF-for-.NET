using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class InkModel
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

    public PointModel[] Points { get; set; } = new PointModel[] { new PointModel { X = 10, Y = 10 }, new PointModel { X = 20, Y = 20 } };

    public int Border { get; set; } = 5;

    [JsonIgnore]
    public CapStyle CapStyleValue
    {
        get
        {
            return (CapStyle)Enum.Parse(typeof(CapStyle), CapStyle);
        }
    }

    public string CapStyle { get; set; } = "Rounded";
}