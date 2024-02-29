using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class TextModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();
    
    public TitleModel Title { get; set; } = new TitleModel();

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