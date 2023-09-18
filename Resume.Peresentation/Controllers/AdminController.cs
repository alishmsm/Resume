using Microsoft.AspNetCore.Mvc;

namespace Resume.Peresentation.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}