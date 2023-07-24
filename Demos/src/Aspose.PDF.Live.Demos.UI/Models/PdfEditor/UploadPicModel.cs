using System.Collections.Generic;

namespace Aspose.Pdf.Live.Demos.UI.Models.PdfEditor
{
    public class UploadPicModel
    {
        public string documentId { get; set; }
        public IList<Models.PdfEditor.ShapeModel> shapes { get; set; }
        public string filename { get; set; }
        public string aspectRatio { get; set; }
    }
}
