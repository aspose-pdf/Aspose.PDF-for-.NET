using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class ScreenModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    public string MediaFile { get; set; } = "test.avi";
}