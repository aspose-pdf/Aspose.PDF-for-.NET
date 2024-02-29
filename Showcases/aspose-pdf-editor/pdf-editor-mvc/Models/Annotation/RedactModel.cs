using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class RedactModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    [JsonIgnore]
    public Color FillColorValue
    {
        get
        {
            return (Aspose.Pdf.Color)Enum.Parse(typeof(Aspose.Pdf.Color), FillColor);
        }
    }

    public string FillColor { get; set; } = "Aqua";

    [JsonIgnore] 
    public Color BorderColorValue
    {
        get
        {
            return (Aspose.Pdf.Color)Enum.Parse(typeof(Aspose.Pdf.Color), BorderColor);
        }
    }

    public string BorderColor { get; set; } = "Black";

    [JsonIgnore] 
    public Color ColorValue
    {
        get
        {
            return (Aspose.Pdf.Color)Enum.Parse(typeof(Aspose.Pdf.Color), Color);
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