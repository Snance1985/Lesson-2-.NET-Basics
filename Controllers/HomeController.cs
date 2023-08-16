using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using L02_assignment.Models;

namespace L02_assignment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Contact()
    {
        ViewBag.Name = "Sean Nance";
        ViewBag.Email = "spnance1985@gmail.com";
        ViewBag.PhoneNumber = "360-910-4719";
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
