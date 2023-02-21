using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sabargram.Models;

namespace sabargram.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult College()
    {
        return View();
    }
    public IActionResult Foundation()
    {
        return View();
    }
    public IActionResult BoardOfDirectors()
    {
        return View();
    }

    public IActionResult Courses()
    {
        return View();
    }
    public IActionResult Faculties()
    {
        return View();
    }

    public IActionResult Alumni()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

