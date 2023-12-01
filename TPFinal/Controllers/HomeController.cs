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
        return View();
    }
    public IActionResult Armadopc(){
        
        ViewBag.CPU = BD.ObtenerProducto("CPU");    
        return View("Armadopc");
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Login(){
        return View("InicioSesion");
    }
    [HttpPost] public IActionResult comprobarDatos(string Email, string Contraseña)
    {
        Usuario user = BD.buscarUsuario(Email,Contraseña);
        if (user != null)
        {
            ViewBag.Username = user.Username;
            ViewBag.Email = user.Email;
            ViewBag.Telefono = user.Telefono;
            ViewBag.Direccion = user.Direccion;
            return View("Logged");
        }
        else
        {
            ViewBag.LoginError = "Hubo un error al entrar, verifique los datos y vuelva a intentar";
            return View("Index");
        }
    }
    public IActionResult Registrarse(){
        
        return View("Registrarse");
    }
    /*public IActionResult GuardarPedido(Pedidos p){
        BD.AgregarPedido(p);
        return RedirectToAction("Index", new { idPedido = p.IdPedido });
    }*/
    public IActionResult UsuRegistrar(Usuario usu)
    {
        BD.RegistrarUsuario(usu);
        return View("InicioSesion");
    }
 

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
