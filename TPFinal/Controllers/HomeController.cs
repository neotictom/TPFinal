using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPFinal.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Forms;

namespace TPFinal.Controllers;

public class HomeController : Controller
{

    static Usuario user = null;
    static Pedido order = null;
    static List<Pedido> listorder = new List<Pedido>();
    static string filtro;
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
        ViewBag.ElPedido = order;
        ViewBag.ListaPedidos = listorder;
        ViewBag.Prods = BD.ListarProductos();   
        Console.WriteLine(ViewBag.Prods);
        return View();
    }
    public Producto ModalComp(int id){
        return BD.ObtenerProductoById(id);
    }
    public IActionResult GuardarCarrito (int id){ //Es void y hace un return XD
        Console.WriteLine(id);
        Usuario u = user;
        int idusu = u.IdUsuario;
        BD.GuardarProducto(id,idusu);
        return View("Carrito");
       
    }
  
    public IActionResult Armadopc(Pedido p){
        Console.WriteLine(user);
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
    public IActionResult Presupuesto(int CPU,int Motherboard,int RAM,int GPU,int Almacenamiento,int Cooler,int Gabinete,int Fuente, double pCPU){
        List <Producto> Productos = BD.ListarProductos();
        Console.WriteLine(CPU);
        Console.WriteLine(Motherboard);
        Console.WriteLine(RAM);
        Console.WriteLine(GPU);
        Console.WriteLine(Almacenamiento);
        Console.WriteLine(Cooler);
        Console.WriteLine(Gabinete);
        Console.WriteLine(Fuente);

        double tot = 0;

        tot = (CPU!=0) ? tot+=Productos[CPU-1].Precio :  tot;
        tot = (Motherboard!=0) ? tot+=Productos[Motherboard-1].Precio :  tot;
        tot = (RAM!=0) ? tot+=Productos[RAM-1].Precio :  tot;
        tot = (GPU!=0) ? tot+=Productos[GPU-1].Precio :  tot;
        tot = (Almacenamiento!=0) ? tot+=Productos[Almacenamiento-1].Precio :  tot;
        tot = (Cooler!=0) ? tot+=Productos[Cooler-1].Precio :  tot;
        tot = (Gabinete!=0) ? tot+=Productos[Gabinete-1].Precio :  tot;
        tot = (Fuente!=0) ? tot+=Productos[Fuente-1].Precio :  tot;
        
        //double tot = (MotherboardC[Motherboard - 1].Precio + CPUC[CPU - 1].Precio + GPUC[GPU - 1].Precio + RAMC[RAM].Precio + AlmacenamientoC[Almacenamiento].Precio + CoolerC[Cooler].Precio + GabineteC[Gabinete].Precio + FuenteC[Fuente].Precio);
        //Pedido p = {0,idMotherboard,idCPU,idRAM,idGPU,idAlmacenamiento,idCooler,idFuente,idGabinete,user. ,tot};

        ViewBag.UsuarioLogueado = user;

        BD.AgregarPedido(Motherboard,CPU,GPU,RAM,Almacenamiento,Cooler,Gabinete,Fuente,user,tot);
        order = BD.BuscarPedidoInsertado(Motherboard,CPU,GPU,RAM,Almacenamiento,Cooler,Gabinete,Fuente,user,tot);
        ViewBag.ElPedido = order;
        ViewBag.Prod = BD.ListarProductos();
        listorder.Add(order);
        return View("Presupuesto");
    }
    public IActionResult UsuRegistrar(Usuario usu)
    {
        bool samUs = BD.ExisteCuentaConMismoUsuario(usu.Username);
        bool samMail = BD.ExisteCuentaConMismoMail(usu.Email);
        if(samUs)
        {
            ViewBag.RegError = "Error al Registrarse: Ya exsiste usuario con el mismo username";
            return View("Registrarse");
        }
        else if (samMail)
        {
            ViewBag.RegError = "Error al Registrarse: Ya exsiste usuario con el mismo E-Mail";
            return View("Registrarse");
        }
        else if(!samUs & !samMail)
        {
            BD.RegistrarUsuario(usu);
            return View("InicioSesion");
        }
        return View("Registrarse");
    }
    public IActionResult BuscarProducto(string nom){
        List<Producto> p = BD.BuscarProductoxnombre(nom);
        ViewBag.Prod = p;
        ViewBag.Busc = nom;
        filtro = ViewBag.Busc;
        ViewBag.UsuarioLogueado = user;
        return View("BuscarProducto");
    }
    public IActionResult FiltrarProducto(string n){
        List<Producto> p = BD.ObtenerProducto(n);
        ViewBag.VerFiltro = true;
        ViewBag.Prod = p;
        ViewBag.Busc = filtro;
        ViewBag.UsuarioLogueado = user;
        ViewBag.ProductoFiltrado = n;
        return View("BuscarProducto");
        
    }

    public IActionResult ContraseñaOlvidada()
    {
        return View("ContraseñaOlvidada");
    }
    
    public IActionResult CambiarContraseña(string Username,string Email,string Contraseña,string ContraseñaConfirmada)
    {
        int res = BD.CambiarContraseña(Username,Contraseña);
        switch(res)
        {
            case 0:
                return View("ContraseñaOlvidada");
            break;

            case 1:
                return View("InicioSesion");
            break;
        }
        return View("InicioSesion");
    }
    
 

    public IActionResult Perfil()
    {
        ViewBag.UsuarioLogueado = user;
        return View();
    }

    public IActionResult EditarInfo()
    {
        ViewBag.UsuarioLogueado = user;
        return View("EdicionPerfil");
    }

    public IActionResult Edicion(string Nombre, string Apellido, string EMail, string Telefono, string Direccion)
    {
        Usuario bob = new Usuario();
        bob.IdUsuario = user.IdUsuario;
        bob.Nombre = Nombre;
        bob.Apellido = Apellido;
        bob.Email = EMail;
        bob.Telefono = Telefono;
        bob.Direccion = Direccion;
        bob.Username = user.Username;
        bob.Password = user.Password;
        BD.ActualizarUsuario(bob);
        ViewBag.EditSuccess = "Perfil Editado Correctamente";
        ViewBag.UsuarioLogueado = bob;
        return View("Perfil");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Carrito (){
        List <Carrito> c = BD.ListarCarrito();
        List <Producto> plist = new List<Producto>();
        Producto p = new Producto();
        for(int i = 0; i<c.Count; i++){
            p = BD.ObtenerProductoById(c[i].IdProducto);
            plist.Add(p);
        }
        ViewBag.Prod = plist;
        ViewBag.UsuarioLogueado = user;
        return View();
    }

}
