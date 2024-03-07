function PointModel(x, y) {
    this.X = x;
    this.Y = y;
}

function CaretModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Flags = "Default";
}

function CircleModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.InteriorColor = "Aqua";
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
}

function FreeTextModel() {
    this.PageNumber = 1;
    this.Text = "test";
    this.X = 10;
    this.Y = 10;
    this.Width = 50;
    this.Height = 50;
}

function HighlightModel() {
    this.PageNumber = 1;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Text = "Test data";
}

function InkModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Points = [new PointModel(10, 10), new PointModel(20, 20)];
    this.Border = border || 5;
    this.CapStyle = "Rounded";
}

function LineModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Start = new PointModel(10, 10);
    this.End = new PointModel(20, 20);
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
    this.Width = width || 50;
    this.StartingStyle = "Circle";
    this.EndingStyle = "ClosedArrow";
}

function LinkModel() {
    this.PageNumber = 1;
    this.Text = "Test data";
    this.Url = "http://google.com";
}

function MovieModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.MediaFile = "test.avi";
}

function PolygonModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
    this.Points = [new PointModel(10, 10), new PointModel(20, 20), new PointModel(30, 20)];
}

function PolyLineModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
    this.Points = [new PointModel(10, 10), new PointModel(20, 20), new PointModel(30, 20)];
}

function RedactModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.FillColor = "Aqua";
    this.BorderColor = "Black";
    this.Color = "Beige";
    this.OverlayText = "CENSORED";
    this.TextAlignment = "Center";
    this.Repeat = true;
}

function ScreenModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.MediaFile = "test.avi";
}

function SoundModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.MediaFile = "test.wav";
}

function SquareModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
    this.InteriorColor = "Aqua";
}

function SquigglyModel() {
    this.PageNumber = 1;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Text = "Test data";
}

function StampModel() {
    this.PageNumber = 1;
    this.ImageFile = imageFile || "test.bmp";
    this.Background = background || true;
    this.XIndent = xIndent || 10;
    this.YIndent = yIndent || 10;
    this.Height = height || 50;
    this.Width = width || 50;
    this.Rotate = rotate || "on90";
    this.Opacity = opacity || 0.5;
}

function StrikeOutModel() {
    this.PageNumber = 1;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Text = "Test data";
}

function TextModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Contents = "test";
    this.Open = true;
    this.Icon = "Comment";
    this.Border = 5;
}

function UnderlineModel() {
    this.PageNumber = 1;
    this.Title = "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Text = "Test data";
}

function WatermarkModel() {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Text = ["test1", "test2"];
    this.Opacity = 0.5;
    this.ForegroundColor = "Aqua";
    this.Font = "Arial";
    this.FontSize = 20;
}