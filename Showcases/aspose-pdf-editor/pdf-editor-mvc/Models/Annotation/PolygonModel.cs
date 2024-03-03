using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class PolygonModel
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


    public PointModel[] Points { get; set; } = new PointModel[] { new PointModel { X = 10, Y = 10 }, new PointModel { X = 20, Y = 20 } , new PointModel { X = 30, Y = 20 } };
}