function setPosition(obj, x, y, pageNumber) {
    // Check if the object has a 'pageNumber' field and set it if provided
    
    if (obj.hasOwnProperty('X')) {
        obj.X = x !== undefined ? x : obj.X;
    }

    if (obj.hasOwnProperty('Y')) {
        obj.Y = y !== undefined ? y : obj.Y;
    }

    if (obj.hasOwnProperty('XIndent')) {
        obj.XIndent = x !== undefined ? x : obj.XIndent;
    }

    if (obj.hasOwnProperty('YIndent')) {
        obj.YIndent = y !== undefined ? y : obj.YIndent;
    }

    if (obj.hasOwnProperty('Points')) {
        obj.Points = [ new PointModel(x, y) ];
    }
}

function PointModel(x, y) {
    this.X = x;
    this.Y = y;
}

function CaretModel(position, title, flags) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Flags = flags || "Default";
}

function CircleModel(position, title, interiorColor, popup) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.InteriorColor = interiorColor || "Aqua";
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
}

function FreeTextModel(page, text, x, y, width, height) {
    this.PageNumber = 1;
    this.Text = text || "test";
    this.X = x || 10;
    this.Y = y || 10;
    this.Width = width || 50;
    this.Height = height || 50;
}

function HighlightModel(page, title, text) {
    this.PageNumber = 1;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Text = text || "Test data";
}

function InkModel(position, title, points, border, capStyle) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Points = points || [new PointModel(10, 10), new PointModel(20, 20)];
    this.Border = border || 5;
    this.CapStyle = capStyle || "Rounded";
}

function LineModel(position, title, start, end, popup, width, startingStyle, endingStyle) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Start = start || new PointModel(10, 10);
    this.End = end || new PointModel(20, 20);
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
    this.Width = width || 50;
    this.StartingStyle = startingStyle || "Circle";
    this.EndingStyle = endingStyle || "ClosedArrow";
}

function LinkModel(page, text, url) {
    this.PageNumber = 1;
    this.Text = text || "Test data";
    this.Url = url || "http://google.com";
}

function MovieModel(position, mediaFile) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.MediaFile = mediaFile || "test.avi";
}

function PolygonModel(position, title, popup, points) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
    this.Points = points || [new PointModel(10, 10), new PointModel(20, 20), new PointModel(30, 20)];
}

function PolyLineModel(position, title, popup, points) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
    this.Points = points || [new PointModel(10, 10), new PointModel(20, 20), new PointModel(30, 20)];
}

function RedactModel(position, fillColor, borderColor, color, overlayText, textAlignment, repeat) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.FillColor = fillColor || "Aqua";
    this.BorderColor = borderColor || "Black";
    this.Color = color || "Beige";
    this.OverlayText = overlayText || "CENSORED";
    this.TextAlignment = textAlignment || "Center";
    this.Repeat = repeat || true;
}

function ScreenModel(position, mediaFile) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.MediaFile = mediaFile || "test.avi";
}

function SoundModel(position, mediaFile) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.MediaFile = mediaFile || "test.wav";
}

function SquareModel(position, title, popup, interiorColor) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.PopupPageNumber = 1;
    this.PopupLlx = 10;
    this.PopupLly = 10;
    this.PopupUrx = 20;
    this.PopupUry = 20;
    this.InteriorColor = interiorColor || "Aqua";
}

function SquigglyModel(page, title, text) {
    this.PageNumber = 1;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Text = text || "Test data";
}

function StampModel(page, imageFile, background, xIndent, yIndent, height, width, rotate, opacity) {
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

function StrikeOutModel(page, title, text) {
    this.PageNumber = 1;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Text = text || "Test data";
}

function TextModel(position, title, contents, open, icon, border) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Contents = contents || "test";
    this.Open = open || true;
    this.Icon = icon || "Comment";
    this.Border = border || 5;
}

function UnderlineModel(page, title, text) {
    this.PageNumber = 1;
    this.Title = title !== undefined ? title : "title";
    this.Subject = "subject";
    this.Color = "Aqua";
    this.Opacity = 0.5;
    this.Text = text || "Test data";
}

function WatermarkModel(position, text, opacity, foregroundColor, font, fontSize) {
    this.PageNumber = 1;
    this.Llx = 10;
    this.Lly = 10;
    this.Urx = 20;
    this.Ury = 20;
    this.Text = text || ["test1", "test2"];
    this.Opacity = opacity || 0.5;
    this.ForegroundColor = foregroundColor || "Aqua";
    this.Font = font || "Arial";
    this.FontSize = fontSize || 20;
}