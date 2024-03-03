using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class TextModel
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
            return Aspose.Pdf.Color.Parse(Color);
        }
    }

    public string Color { get; set; } = "Aqua";

    public double Opacity { get; set; } = 0.5;

    public string Contents { get; set; } = "test";

    public bool Open { get; set; } = true;

    [JsonIgnore]
    public TextIcon IconValue
    {
        get
        {
            return (TextIcon)Enum.Parse(typeof(TextIcon), Icon);
        }
    }

    public string Icon { get; set; } = "Comment";

    public int Border { get; set; } = 5;
}