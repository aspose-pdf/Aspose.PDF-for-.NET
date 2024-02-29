using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class CaretModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    public TitleModel Title { get; set; } = new TitleModel();

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