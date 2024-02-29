using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class LineModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();
    
    public TitleModel Title { get; set; } = new TitleModel();

    public PointModel Start { get; set; } = new PointModel { X = 10, Y = 10 };

    public PointModel End { get; set; } = new PointModel { X = 20, Y = 20 };

    public PagePositionModel Popup { get; set; } = new PagePositionModel();

    public int Width { get; set; } = 50;

    [JsonIgnore]
    public LineEnding StartingStyleValue
    {
        get
        {
            return (LineEnding)Enum.Parse(typeof(LineEnding), StartingStyle);
        }
    }

    public string StartingStyle { get; set; } = "Circle";

    [JsonIgnore]
    public LineEnding EndingStyleValue
    {
        get
        {
            return (LineEnding)Enum.Parse(typeof(LineEnding), EndingStyle);
        }
    }

    public string EndingStyle { get; set; } = "ClosedArrow";
}