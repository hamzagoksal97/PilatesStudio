using Microsoft.AspNetCore.Mvc;

namespace PilatesStudio.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}