using Aspose.App.UI.Utils;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Shared.Controllers;
using Microsoft.Extensions.Logging;
using Aspose.PDF.FormFiller.Models;
using System;
using Aspose.App.UI.Utils.Pdf.Localization;
using Aspose.PDF.OptionsShared.AppResources.Pdf;
using Aspose.PDF.OptionsShared.AppResources.Pdf.FormFiller;
using Aspose.PDF.MetricsShared;
using Aspose.PDF.OptionsShared.AppResources.Pdf.OCR;

namespace Aspose.PDF.FormFiller.Controllers
{
    public class FormController : PdfUIControllerBase
    {
        public FormController(ILogger<FormController> logger, IMetrics metrics) : base(logger, metrics)
        {

        }

        public ActionResult Invoice()
        {
            var localizationProvider = new MultipleResourceFilesLocalizationProvider();
            localizationProvider.Register(PdfInvoiceResources.ResourceManager, (key) => true);
            localizationProvider.Register(PdfResources.ResourceManager, (key) => true);
            var model = new FormViewModel(localizationProvider, _additionalRequestData, ProductApplications.FormFiller)
            {
                SaveAsComponent = false,
                FileName = "Invoice",
                FolderName = Guid.NewGuid().ToString()
            };

            model.AppURL = model.AppURL.Substring(0, model.AppURL.LastIndexOf("/"));

            return View("~/Areas/Pages/Forms/Form.cshtml", model);
        }

        public ActionResult CV()
        {
            var localizationProvider = new MultipleResourceFilesLocalizationProvider();
            localizationProvider.Register(PdfOCRResources.ResourceManager, (key) => true);
            localizationProvider.Register(PdfResources.ResourceManager, (key) => true);
            var model = new FormViewModel(localizationProvider, _additionalRequestData, ProductApplications.FormFiller)
            {
                SaveAsComponent = false,
                FileName = "CV",
                FolderName = Guid.NewGuid().ToString()
            };

            model.AppURL = model.AppURL.Substring(0, model.AppURL.LastIndexOf("/"));

            return View("~/Areas/Pages/Forms/Form.cshtml", model);
        }
    }
}
