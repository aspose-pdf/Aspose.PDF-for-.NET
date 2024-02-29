namespace aspose.pdf.annotation.Model.Descriptions;

[Serializable]
public class PagePositionModel : PageModel
{
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
}