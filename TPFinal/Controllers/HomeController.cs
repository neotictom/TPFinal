using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPFinal.Models;
using System.Collections.Generic;

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
         
        ViewBag.Productos = BD.ListarProductos();
        // = ListaProductos;
        return View();
    }
    public IActionResult Armadopc(){
        List<Producto> ListaProductos = BD.ListarProductos();
        //ViewBag.MotherBoard = ListaProductos.Nombre.IndexOf("Motherboard");
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
    public IActionResult UsuRegistrar(Usuario usu)
    {
        BD.RegistrarUsuario(usu);
        return View("InicioSesion");
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
