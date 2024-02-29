function PageModel(pageNumber) {
    this.pageNumber = pageNumber !== undefined ? pageNumber : 1;
}

// PagePositionModel constructor function that inherits from PageModel
function PagePositionModel(pageNumber, llx, lly, urx, ury, normalizeCoordinates) {
    // Call the PageModel constructor to initialize the base properties
    PageModel.call(this, pageNumber);

    // Initialize PagePositionModel properties with default values or provided values
    this.llx = llx !== undefined ? llx : 10;
    this.lly = lly !== undefined ? lly : 10;
    this.urx = urx !== undefined ? urx : 20;
    this.ury = ury !== undefined ? ury : 20;
    this.normalizeCoordinates = normalizeCoordinates !== undefined ? normalizeCoordinates : true;
}

function PointModel(x, y) {
    this.X = x;
    this.Y = y;
}

function TitleModel(title, subject, color, opacity) {
    this.Title = title !== undefined ? title : "title";
    this.Subject = subject !== undefined ? subject : "subject";
    this.Color = color !== undefined ? color : "Aqua";
    this.Opacity = opacity !== undefined ? opacity : 0.5;
}

function CaretModel(position, title, flags) {
    this.Position = position || new PagePositionModel();
    this.Title = title || new TitleModel();
    this.Flags = flags || "Default";
}

function CircleModel(position, title, interiorColor, popup) {
    this.Position = position || new PagePositionModel();
    this.Title = title || new TitleModel();
    this.InteriorColor = interiorColor || "Aqua";
    this.Popup = popup || new PagePositionModel();
}

function FreeTextModel(page, text, x, y, width, height) {
    this.Page = page || new PageModel();
    this.Text = text || "test";
    this.X = x || 10;
    this.Y = y || 10;
    this.Width = width || 50;
    this.Height = height || 50;
}

function HighlightModel(page, title, text) {
    this.Page = page || new PageModel();
    this.Title = title || new TitleModel();
    this.Text = text || "Test data";
}

function InkModel(position, title, points, border, capStyle) {
    this.Position = position || new PagePositionModel();
    this.Title = title || new TitleModel();
    this.Points = points || [new PointModel(10, 10), new PointModel(20, 20)];
    this.Border = border || 5;
    this.CapStyle = capStyle || "Rounded";
}

function LineModel(position, title, start, end, popup, width, startingStyle, endingStyle) {
    this.Position = position || new PagePositionModel();
    this.Title = title || new TitleModel();
    this.Start = start || new PointModel(10, 10);
    this.End = end || new PointModel(20, 20);
    this.Popup = popup || new PagePositionModel();
    this.Width = width || 50;
    this.StartingStyle = startingStyle || "Circle";
    this.EndingStyle = endingStyle || "ClosedArrow";
}

function LinkModel(page, text, url) {
    this.Page = page || new PageModel();
    this.Text = text || "Test data";
    this.Url = url || "http://google.com";
}

function MovieModel(position, mediaFile) {
    this.Position = position || new PagePositionModel();
    this.MediaFile = mediaFile || "test.avi";
}

function PolygonModel(position, title, popup, points) {
    this.Position = position || new PagePositionModel();
    this.Title = title || new TitleModel();
    this.Popup = popup || new PagePositionModel();
    this.Points = points || [new PointModel(10, 10), new PointModel(20, 20), new PointModel(30, 20)];
}

function PolyLineModel(position, title, popup, points) {
    this.Position = position || new PagePositionModel();
    this.Title = title || new TitleModel();
    this.Popup = popup || new PagePositionModel();
    this.Points = points || [new PointModel(10, 10), new PointModel(20, 20), new PointModel(30, 20)];
}

function RedactModel(position, fillColor, borderColor, color, overlayText, textAlignment, repeat) {
    this.Position = position || new PagePositionModel();
    this.FillColor = fillColor || "Aqua";
    this.BorderColor = borderColor || "Black";
    this.Color = color || "Beige";
    this.OverlayText = overlayText || "CENSORED";
    this.TextAlignment = textAlignment || "Center";
    this.Repeat = repeat || true;
}

function ScreenModel(position, mediaFile) {
    this.Position = position || new PagePositionModel();
    this.MediaFile = mediaFile || "test.avi";
}

function SoundModel(position, mediaFile) {
    this.Position = position || new PagePositionModel();
    this.MediaFile = mediaFile || "test.wav";
}

function SquareModel(position, title, popup, interiorColor) {
    this.Position = position || new PagePositionModel();
    this.Title = title || new TitleModel();
    this.Popup = popup || new PagePositionModel();
    this.InteriorColor = interiorColor || "Aqua";
}

function SquigglyModel(page, title, text) {
    this.Page = page || new PageModel();
    this.Title = title || new TitleModel();
    this.Text = text || "Test data";
}

function StampModel(page, imageFile, background, xIndent, yIndent, height, width, rotate, opacity) {
    this.Page = page || new PageModel();
    this.ImageFile = imageFile || "test.bmp";
    this.Background = background || true;
    this.XIndent = xIndent || 10;
    this.YIndent = yIndent || 10;
    this.Height = height || 50;
    this.Width = width || 50;
    this.Rotate = rotate || "on90";
    this.Opacity = opacity || 0.5;
}

function StrikeOutModel(page, title, text) {
    this.Page = page || new PageModel();
    this.Title = title || new TitleModel();
    this.Text = text || "Test data";
}

function TextModel(position, title, contents, open, icon, border) {
    this.Position = position || new PagePositionModel();
    this.Title = title || new TitleModel();
    this.Contents = contents || "test";
    this.Open = open || true;
    this.Icon = icon || "Comment";
    this.Border = border || 5;
}

function UnderlineModel(page, title, text) {
    this.Page = page || new PageModel();
    this.Title = title || new TitleModel();
    this.Text = text || "Test data";
}

function WatermarkModel(position, text, opacity, foregroundColor, font, fontSize) {
    this.Position = position || new PagePositionModel();
    this.Text = text || ["test1", "test2"];
    this.Opacity = opacity || 0.5;
    this.ForegroundColor = foregroundColor || "Aqua";
    this.Font = font || "Arial";
    this.FontSize = fontSize || 20;
}

