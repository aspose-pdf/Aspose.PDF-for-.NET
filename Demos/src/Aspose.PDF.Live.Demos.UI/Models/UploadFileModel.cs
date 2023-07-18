using System;
using System.Collections.Generic;
using System.Linq;


namespace Aspose.Pdf.Live.Demos.UI.Models
{
	public class UploadFileModel  
	{
		public bool AcceptMultipleFiles { get; set; }
		public string FileDropKey { get; set; }
		public string AcceptedExtentions { get; set; }
		public Dictionary<string, string> Resources { get; }
		public string UploadId { get; set; } = $"{Guid.NewGuid()}";

		public UploadFileModel(Dictionary<string, string> resources)
		{
			this.Resources = resources;
		}
	}
}
