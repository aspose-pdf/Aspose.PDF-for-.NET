using System;
using System.Collections.Generic;
using Aspose.App;
using Aspose.App.UI.Models;
using Aspose.App.UI.Models.PDF;
using Aspose.App.UI.Models.PDF.SEO;
using Aspose.App.UI.Utils;
using Aspose.App.UI.Utils.Pdf.Localization;

namespace Aspose.PDF.FormFiller.Models
{
    public class FormViewModel : PdfAppsViewModel
	{
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public string CallbackURL { get; set; }
        public string FileDownloadLink { get; set; }
        public bool Sample => string.Equals(FolderName, "sample", StringComparison.OrdinalIgnoreCase);

        public FormViewModel(ILocalizationProvider localizationProvider, AdditionalRequestData additionalRequestData, ProductApplications app) : base(localizationProvider, additionalRequestData, app)
        {
			FileDownloadLink = $"{AppSettings.APIBasePath}pdf/{AppName.ToRouteName()}/api/AsposePdfFormFiller/downloadFile";
        }

		protected override void SetAppFeatures(string app)
		{
			if (!string.IsNullOrEmpty(Extension2))
			{
				AppFeatures = null;
				return;
			}
			AppFeatures = new List<string>();

			var i = 1;
			while (Localize($"{ProductAppName}LiFeature{i}") != null)
				AppFeatures.Add(Localize($"{ProductAppName}LiFeature{i++}"));

			if (AppFeatures.Count == 0)
			{
				i = 1;
				while (Localize($"{app}LiFeature{i}") != null)
				{
					AppFeatures.Add(Localize($"{app}LiFeature{i}"));
					i++;
				}
			}
		}

		protected override void PrepareSchemaGraph()
		{
			Graph = new SchemaGraph();
			var breadcrumb = new BreadcrumbForPdf();
			Graph.ElementsList.Add(breadcrumb);
			Graph.ElementsList.Add(new SoftwareApplication());
			Graph.ElementsList.Add(new HowTo());
			Graph.ElementsList.Add(new Organization());
			Graph.ElementsList.Add(new LocalBusiness());
			Graph.ElementsList.Add(new WebApplication());
			//Graph.ElementsList.Add(new VideoObject());
			Graph.ElementsList.Add(new MobileApplication());
			Graph.InitSchemaByModel(this);

			if(AdditionalRequestData.RouteDataValues.ContainsKey("action") &&
				breadcrumb.Items.Count > 2)
            {
				var action = AdditionalRequestData.RouteDataValues["action"].ToString().ToLower();
				if(!string.IsNullOrWhiteSpace(action))
                {
					string verb = Localize($"{AppName}_{action}Action");
					if(!string.IsNullOrWhiteSpace(verb))
                    {
						breadcrumb.Items[2].Item.Name = verb;
					}
					breadcrumb.Items[2].Item.Id += "/" + action;
				}
			}
        }
	}
}
