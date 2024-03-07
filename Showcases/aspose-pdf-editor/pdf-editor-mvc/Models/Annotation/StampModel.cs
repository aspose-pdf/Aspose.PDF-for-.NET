using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class StampModel
{
    public int PageNumber { get; set; } = 1;

    public string ImageFile { get; set; } = "test.bmp";

    public bool Background { get; set; } = true;

    public int XIndent { get; set; } = 10;

    public int YIndent { get; set; } = 10;

    public int Height { get; set; } = 50;

    public int Width { get; set; } = 50;

    [JsonIgnore]
    public Rotation RotateValue
    {
        get
        {
            return (Rotation)Enum.Parse(typeof(Rotation), Rotate);
        }
    }

    public string Rotate { get; set; } = "on90";

    public double Opacity { get; set; } = 0.5;
}