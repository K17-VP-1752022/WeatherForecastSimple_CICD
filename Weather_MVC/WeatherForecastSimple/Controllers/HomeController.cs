using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeatherForecastSimple.Models;

namespace WeatherForecastSimple.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _loggerr;

    public HomeController(ILogger<HomeController> loggerr)
    {
        _loggerr = loggerr;
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
