using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class PolygonModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();
    
    public TitleModel Title { get; set; } = new TitleModel();

    public PagePositionModel Popup { get; set; } = new PagePositionModel();
    
    public PointModel[] Points { get; set; } = new PointModel[] { new PointModel { X = 10, Y = 10 }, new PointModel { X = 20, Y = 20 } , new PointModel { X = 30, Y = 20 } };
}