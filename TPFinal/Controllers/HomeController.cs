using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPFinal.Models;

namespace TPFinal.Controllers;

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
    public IActionResult Armadopc(){
        return View("Armadopc");
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Perfil(){
        return View("Perfil");
    }
    public IActionResult Login(){
        return View("Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
