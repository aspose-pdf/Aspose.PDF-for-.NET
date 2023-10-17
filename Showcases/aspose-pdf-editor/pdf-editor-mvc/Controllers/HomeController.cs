using Microsoft.AspNetCore.Mvc;

namespace Aspose.PDF.Editor.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Privacy() => View();
}
