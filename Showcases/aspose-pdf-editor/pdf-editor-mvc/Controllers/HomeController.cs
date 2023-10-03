using Aspose.PDF.Editor.Models;
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
