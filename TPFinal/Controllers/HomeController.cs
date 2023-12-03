﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPFinal.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Forms;

namespace TPFinal.Controllers;

public class HomeController : Controller
{

    static Usuario user;
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    { 
        ViewBag.Productos = BD.ListarProductos();
        ViewBag.UsuarioLogueado = user;
        return View();
    }
    public Producto DetalleComponente(int id){
        return BD.ObtenerProductoById(id);
    }
    public IActionResult Armadopc(Pedido p){
        ViewBag.Usuario = user;
        ViewBag.IdPedido = p.IdPedido;
        ViewBag.CPU = BD.ObtenerProducto("CPU");
        ViewBag.Motherboard = BD.ObtenerProducto("Motherboard");
        ViewBag.GPU = BD.ObtenerProducto("GPU");
        ViewBag.RAM = BD.ObtenerProducto("RAM");
        ViewBag.Almacenamiento = BD.ObtenerProducto("Almacenamiento");
        ViewBag.Cooler = BD.ObtenerProducto("Cooler");
        ViewBag.Gabinete = BD.ObtenerProducto("Gabinete");
        ViewBag.Fuente = BD.ObtenerProducto("Fuente"); 
        return View("Armadopc");
    }

    public IActionResult Privacy()
    {
        ViewBag.UsuarioLogueado = user;
        return View();
    }

    public IActionResult Login(string usuario, string contraseña)
    {
        user = BD.buscarUsuario(usuario,contraseña);
        if (user != null)
        {
            ViewBag.LoginError = "";
            ViewBag.Productos = BD.ListarProductos();
            return RedirectToAction("Index", new{IdUsuario = user.IdUsuario});
        }
        else
        {
            ViewBag.LoginError = "Hubo un error al entrar, verifique los datos y vuelva a intentar";
            ViewBag.UsuarioLogueado = null;
            return View("InicioSesion");
        }
    }

    public IActionResult InicioSesion()
    {
        user = null;
        ViewBag.LoginError = "";
        return View("InicioSesion");
    }

    public IActionResult Registrarse(){
        
        return View("Registrarse");
    }
    [HttpPost]public IActionResult Presupuesto(Pedido p){
        BD.AgregarPedido(p);
        return RedirectToAction("Presupuesto");
    }
    public IActionResult UsuRegistrar(Usuario usu)
    {
        BD.RegistrarUsuario(usu);
        return View("InicioSesion");
    }
    public IActionResult BuscarProducto(string nom){
        ViewBag.Prodbuscado = BD.BuscarProductoxnombre(nom);
        return View("BuscarProducto");
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
