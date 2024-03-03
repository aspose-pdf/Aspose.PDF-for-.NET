using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class CaretModel
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

    [JsonIgnore]
    public AnnotationFlags FlagsValue
    {
        get
        {
            return (AnnotationFlags)Enum.Parse(typeof(AnnotationFlags), Flags);
        }
    }

    public string Flags { get; set; } = "Default";
}