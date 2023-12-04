using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPFinal.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Forms;

namespace TPFinal.Controllers;

public class HomeController : Controller
{

    static Usuario user = null;
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        Random rand = new Random();
        int r;
        List <Producto> Prod = BD.ListarProductos();
        List <Producto> prand = new List<Producto>();
        for(int i = 1; i<=5; i++){
            r = rand.Next(1,40);
            prand.Add(Prod[r]);
        }
        ViewBag.Productos = prand; 
        ViewBag.UsuarioLogueado = user;
        return View();
    }
    public Producto ModalComp(int id){
        return BD.ObtenerProductoById(id);
    }
    public IActionResult Armadopc(Pedido p){
        ViewBag.Usuario = user;
        ViewBag.UsuarioLogueado = user;
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
    public IActionResult Presupuesto(string CPU,string Motherboard,string RAM,string GPU,string Almacenamiento,string Cooler,string Gabinete,string Fuente){
        List <Producto> CPUC = BD.ObtenerProducto("CPU");
        List <Producto> MotherboardC = BD.ObtenerProducto("Motherboard");
        List <Producto> GPUC = BD.ObtenerProducto("GPU");
        List <Producto> RAMC = BD.ObtenerProducto("RAM");
        List <Producto> AlmacenamientoC = BD.ObtenerProducto("Almacenamiento");
        List <Producto> CoolerC = BD.ObtenerProducto("Cooler");
        List <Producto> GabineteC = BD.ObtenerProducto("Gabinete");
        List <Producto> FuenteC = BD.ObtenerProducto("Fuente"); 
        int idCPU = -1;
        int idMotherboard = -1;
        int idGPU = -1;
        int idRAM = -1;
        int idAlmacenamiento = -1;
        int idCooler = -1;
        int idGabinete = -1;
        int idFuente = -1;

        for(int i = 0; i<=(CPUC.Count - 1) || idCPU != -1;i++)
        {
            if(CPU == CPUC[i].Nombre)
            {
                idCPU = CPUC[i].IdProducto;
            }
        }

        for(int i = 0; i<=(MotherboardC.Count - 1) || idMotherboard != -1;i++)
        {
            if(Motherboard == MotherboardC[i].Nombre)
            {
                idMotherboard = MotherboardC[i].IdProducto;
            }
        }

        for(int i = 0; i<=(GPUC.Count - 1) || idGPU != -1;i++)
        {
            if(GPU == GPUC[i].Nombre)
            {
                idGPU = GPUC[i].IdProducto;
            }
        }

        for(int i = 0; i<=(RAMC.Count - 1) || idRAM != -1;i++)
        {
            if(RAM == RAMC[i].Nombre)
            {
                idRAM = RAMC[i].IdProducto;
            }
        }

        for(int i = 0; i<=(AlmacenamientoC.Count - 1) || idAlmacenamiento != -1;i++)
        {
            if(Almacenamiento == AlmacenamientoC[i].Nombre)
            {
                idAlmacenamiento = AlmacenamientoC[i].IdProducto;
            }
        }

        for(int i = 0; i<=(CoolerC.Count - 1) || idCooler != -1;i++)
        {
            if(Cooler == CoolerC[i].Nombre)
            {
                idCooler = CoolerC[i].IdProducto;
            }
        }

        for(int i = 0; i<=(GabineteC.Count - 1) || idGabinete != -1;i++)
        {
            if(Gabinete == GabineteC[i].Nombre)
            {
                idGabinete = GabineteC[i].IdProducto;
            }
        }

        for(int i = 0; i<=(FuenteC.Count - 1) || idFuente != -1;i++)
        {
            if(Fuente == FuenteC[i].Nombre)
            {
                idFuente = FuenteC[i].IdProducto;
            }
        }

        double tot = (MotherboardC[idMotherboard].Precio + CPUC[idCPU].Precio + GPUC[idGPU].Precio + RAMC[idRAM].Precio + AlmacenamientoC[idAlmacenamiento].Precio + CoolerC[idCooler].Precio + GabineteC[idGabinete].Precio + FuenteC[idFuente].Precio);
        //Pedido p = {0,idMotherboard,idCPU,idRAM,idGPU,idAlmacenamiento,idCooler,idFuente,idGabinete,user.IdUsuario,tot};

        ViewBag.UsuarioLogueado = user;

        //BD.AgregarPedido(p);
        return View("Presupuesto");
    }
    public IActionResult UsuRegistrar(Usuario usu)
    {
        BD.RegistrarUsuario(usu);
        return View("InicioSesion");
    }
    public IActionResult BuscarProducto(string nom){
        ViewBag.Prod = BD.BuscarProductoxnombre(nom);
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
