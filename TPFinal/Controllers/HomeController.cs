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
        Random rnd = new Random();
        ViewBag.rndnum = rnd.Next(1,44);
        ViewBag.Productos = BD.ListarProductos();
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
        return View("InicioSesion");
    }
    public IActionResult Registrarse(){
        
        return View("Registrarse");
    }

    /*[HttpPost]
    public IActionResult GuardarCuenta{

    }*/

    public IActionResult ContraseñaOlvidada()
    {
        return View("ContraseñaOlvidada");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
