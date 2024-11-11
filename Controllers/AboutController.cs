using Microsoft.AspNetCore.Mvc;

namespace PilatesStudio.Controllers;

public class AboutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}