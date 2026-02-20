using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission5Assignment.Models;

namespace Mission5Assignment.Controllers;

public class HomeController : Controller
{
    // Landing page for the hobby/story content.
    public IActionResult Index()
    {
        return View();
    }

    // Tutoring quote page with the lesson cost calculator UI.
    public IActionResult Calculator()
    {
        return View();
    }

    // Prevents caching so users do not get stale error details.
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
