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

