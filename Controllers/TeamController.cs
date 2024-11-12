using Microsoft.AspNetCore.Mvc;

namespace PilatesStudio.Controllers;

public class TeamController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}