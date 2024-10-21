using System.Collections.Generic;

namespace Aspose.PDF.FormFiller.Models.API
{
	public class UploadPicModel
	{
		public string documentId { get; set; }
		public IList<ShapeModel> shapes { get; set; }
		public string filename { get; set; }
		public string aspectRatio { get; set; }
	}
}
