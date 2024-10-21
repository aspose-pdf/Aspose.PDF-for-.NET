using System;
using System.Collections.Generic;
using System.Linq;
using Aspose.App.Shared.Config;
using Aspose.App.UI.Models;
using Aspose.App.UI.Models.PDF;
using Aspose.App.UI.Models.PDF.Partials;
using Aspose.App.UI.Models.PDF.SEO;
using Aspose.App.UI.Utils;
using Aspose.App.UI.Utils.Pdf.Localization;

namespace Aspose.PDF.FormFiller.Models
{
    public class FormFillerViewModel : PdfAppsViewModel
    {
        public FormFillerViewModel(ILocalizationProvider localizationProvider, AdditionalRequestData additionalRequestData, ProductApplications app) : base(localizationProvider, additionalRequestData, app)
        {
			FormCards = new List<FormCardViewModel>
			{
				new FormCardViewModel { CardId  = "Invoice" },
				new FormCardViewModel { CardId = "CV" }
			};
		}

		public List<FormCardViewModel> FormCards { get; set; }

		protected override void SetTitles()
		{
			base.SetTitles();
		}

		protected override void SetAppFeatures(string app)
		{
			if (!String.IsNullOrEmpty(Extension2))
			{
				AppFeatures = null;
				return;
			}
			AppFeatures = new List<string>();

			var i = 1;
			while (Localize($"{ProductAppName}LiFeature{i}") != null)
				AppFeatures.Add(Localize($"{ProductAppName}LiFeature{i++}"));

			// Stop other developers to add unnecessary features.
			if (AppFeatures.Count == 0)
			{
				i = 1;
				while (Localize($"{app}LiFeature{i}") != null)
				{
					AppFeatures.Add(Localize($"{app}LiFeature{i}"));
					i++;
				}
			}

			if (Localize($"pdf{app}LiFeatureTryOtherConverters") != null)
			{
				var localePartUrl = IsAppSupportLocale(AppName, UrlLocale) && !"en".Equals(UrlLocale, StringComparison.InvariantCultureIgnoreCase) ? $"{UrlLocale}/" : "";
				var additionalFormats = Configuration.SitemapFormFillerFormats.ToArray();
				var additional = "";
				foreach (var item in additionalFormats)
				{
					additional += $"<a rel=\"nofollow\" href=\"/pdf/{localePartUrl}conversion/{item}\" style=\"background-color: #65c621; color: white; margin-right: 10px; display: inline-block;border-radius: 3px; padding: 0 3px;\">{DesktopAppNameByExtension(item, item.ToUpper())}  </a>";
				}
				AppFeatures.Add(Localize($"pdf{app}LiFeatureTryOtherConverters", additional));
			}
		}

		protected override void PrepareSchemaGraph()
		{
			Graph = new SchemaGraph();
			// Graph.ElementsList.Add(new BreadcrumbForPdf());
			Graph.ElementsList.Add(new SoftwareApplication());
			Graph.ElementsList.Add(new HowTo());
			Graph.ElementsList.Add(new Organization());
			Graph.ElementsList.Add(new LocalBusiness());
			Graph.ElementsList.Add(new WebApplication());
			//Graph.ElementsList.Add(new VideoObject());
			Graph.ElementsList.Add(new MobileApplication());
			Graph.InitSchemaByModel(this);
			PrepareBreadCrumb();
		}
	}
}
