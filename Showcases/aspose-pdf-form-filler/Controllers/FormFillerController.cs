using Aspose.App.UI.Utils;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Shared.Controllers;
using Microsoft.Extensions.Logging;
using Aspose.PDF.FormFiller.Models;
using Aspose.PDF.MetricsShared;

namespace Aspose.PDF.FormFiller.Controllers
{
    public class FormFillerController : PdfUIControllerBase
    {
        public FormFillerController(ILogger<FormFillerController> logger, IMetrics metrics) : base(logger, metrics)
        {

        }

        public ActionResult FormFiller()
        {
            var model = new FormFillerViewModel(LocalizationProvider, _additionalRequestData, ProductApplications.FormFiller)
            {
                SaveAsComponent = false,
                ControlsView = "~/Areas/Pages/FormFiller/FormFillerControls.cshtml",
            };

            return View("~/Areas/Pages/FormFiller.cshtml", model);
        }
    }
}
