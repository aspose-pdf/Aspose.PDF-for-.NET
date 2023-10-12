using Aspose.PDF.Editor.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.PDF.Editor.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new EditorViewModel();
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
