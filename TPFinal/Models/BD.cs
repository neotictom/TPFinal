using System.Data;
using System.Data.SqlClient;
using Dapper;
using TPFinal.Models;
public class BD{
    private static string _connectionString = @"Server=localhost;DataBase=Techbuild;Trusted_Connection=True;";
    public static List<Producto> ObtenerProducto(string cat)
    {
        string sql = "select * from Producto Where Categoria = @Categoria";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            return db.Query<Producto>(sql, new { Categoria = cat }).ToList();
        }
    }
   
    public static Producto ObtenerProductoById(int idp){
        Producto prod = new Producto();
        string sql = "SELECT * FROM Producto WHERE IdProducto = @IdProducto";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            prod = db.QueryFirstOrDefault<Producto>(sql,new {IdProducto = idp});
        }
       return prod;
    }
    public static Pedido ObtenerPedidoById(int idp){
        Pedido order = new Pedido();
        string sql = "SELECT * FROM Pedido WHERE IdPedido = @IdPedido";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            order = db.QueryFirstOrDefault<Pedido>(sql,new {IdPedido = idp});
        }
       return order;
    }
    
    public static List<Producto> BuscarProductoxnombre(string nom){
        string sql= "Select * from Producto Where Nombre Like '%' + @Nombre + '%'";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Producto>(sql,new{Nombre = nom}).ToList();
        }
       
    }
    //Temp: Existe pero no se usa, ¿Por qué existe esta función y por que apunta a un SP que no existe?
    public Usuario ObtenerUsuario(Usuario u) 
    {

        Usuario user= new Usuario();
        user = null;
        using (SqlConnection db=new SqlConnection(_connectionString)){
            string sql = "EXEC GetUsuario @Usuario";
            user=db.QueryFirstOrDefault<Usuario>(sql, new{user=u});
        }
        return user;
    }

   public static bool ExisteCuentaConMismoUsuario(string user)
    {
        List<Usuario> usWSameName = new List<Usuario>();
        int i = 0;
        string sql = "Select * From Usuario Where Username = @Username";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            usWSameName = db.Query<Usuario>(sql, new { Username = user }).ToList();
        }
        if(usWSameName.Count == 0)
        {
            Console.WriteLine("NO SE ENCONTRARON USUARIOS CON EL MISMO NOMBRE");
            return false;
        }
        else
        {
            Console.WriteLine("SE ENCONTRARON USUARIOS CON EL MISMO NOMBRE");
            return true;
        } 

        /*if(usWSameName != null)
        {
            while(i <= usWSameName.Length - 1)
            {

            }
        } */
    }
    

    public static bool ExisteCuentaConMismoMail(string email)
    {
        List<Usuario> usWSameMail = new List<Usuario>();
        string sql = "Select * From Usuario Where Email = @Email";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            usWSameMail = db.Query<Usuario>(sql, new { Email = email }).ToList();
        }
        if(usWSameMail.Count == 0)
        {
            Console.WriteLine("NO SE ENCONTRARON USUARIOS CON EL MISMO MAIL");
            return false;
        }
        else
        {
            Console.WriteLine("SE ENCONTRARON USUARIOS CON EL MISMO MAIL");
            return true;
        }
    }

    public static void AgregarPedido(int idMotherboard,int idCPU,int idGPU,int idRAM,int idAlmacenamiento,int idCooler,int idGabinete,int idFuente,Usuario user,double tot){
        string sql = "INSERT INTO Pedido (Motherboard,CPU,RAM,GPU,Almacenamiento,Cooler,Fuente,Gabinete,IdUsuario,Total)" + 
                 "VALUES (@Motherboard,@CPU,@RAM,@GPU,@Almacenamiento,@Cooler,@Fuente,@Gabinete,@IdUsuario,@Total);";
        using (SqlConnection conexion = new SqlConnection(_connectionString))
        {
            conexion.Execute(sql, new{
                Motherboard = idMotherboard,
                CPU = idCPU,
                RAM = idRAM,
                GPU = idGPU,
                Almacenamiento = idAlmacenamiento,
                Cooler = idCooler,
                Fuente = idFuente,
                Gabinete = idGabinete,
                IdUsuario = user.IdUsuario,
                Total = tot
            });
        }
    }
    
    public static Pedido BuscarPedidoInsertado(int idMotherboard,int idCPU,int idGPU,int idRAM,int idAlmacenamiento,int idCooler,int idGabinete,int idFuente,Usuario user,double tot)
    {
        Pedido ped = new Pedido();
        string sql = "Select * From Pedido Where Motherboard = @Motherboard And CPU = @CPU And RAM = @RAM And GPU = @GPU And Almacenamiento = @Almacenamiento And Cooler = @Cooler And Fuente = @Fuente And Gabinete = @Gabinete And IdUsuario = @IdUsuario And Total = @Total";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            ped = db.QueryFirstOrDefault<Pedido>(sql, new{
                Motherboard = idMotherboard,
                CPU = idCPU,
                RAM = idRAM,
                GPU = idGPU,
                Almacenamiento = idAlmacenamiento,
                Cooler = idCooler,
                Fuente = idFuente,
                Gabinete = idGabinete,
                IdUsuario = user.IdUsuario,
                Total = tot
            });
        }
        return ped;
    }
    
    public static void RegistrarUsuario(Usuario u) 
    {
        string sql = "INSERT INTO Usuario (Nombre, Apellido, Username, Password, Email, Telefono, Direccion, FotoDePerfil)" + 
                 "VALUES (@Nombre, @Apellido, @Username, @Password, @Email, @Telefono, @Direccion, @FotoDePerfil);";
        using (SqlConnection conexion = new SqlConnection(_connectionString))
        {
        conexion.Execute(sql, new
        {
            Nombre = u.Nombre,
            Apellido = u.Apellido,
            Username = u.Username,
            Password = u.Password,
            Email = u.Email,
            Telefono = u.Telefono,
            Direccion = u.Direccion,
            FotoDePerfil = u.FotoDePerfil
        });
        }
    }
     public static int CambiarContraseña(string username, string contraseña){

        int resultado=0;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql="EXEC CambiarContraseña @Username, @Contraseña";
            resultado=db.QueryFirstOrDefault<int>(sql, new{Username=username,Contraseña=contraseña});
        }
        return resultado;
    }
    public static List<Producto> ListarProductos(){
        using(SqlConnection conexion = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Producto";
            return conexion.Query<Producto>(sql).ToList();
        }
    }
    public static List<Carrito> ListarCarrito(){
        using(SqlConnection conexion = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Carrito";
            return conexion.Query<Carrito>(sql).ToList();
        }
    }
    public static List<Usuario> MostrarPedidoDeUsuario(){
        using(SqlConnection conexion = new SqlConnection(_connectionString)){
            string sql = $"SELECT p.Motherboard, p.CPU. p.RAM, u.Id_Usuario FROM Pedido p";
            return conexion.Query<Usuario>(sql).ToList();
        }
    }
    public static Usuario buscarUsuario(string usuario,string contraseña)
    {
        Usuario usu;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql ="SELECT * FROM Usuario WHERE Username = @uUsername AND Password= @uContraseña";
            usu = db.QueryFirstOrDefault<Usuario>(sql,new {uUsername = usuario, uContraseña = contraseña});
            }
        return usu;             
    }
    public static void GuardarProducto(int IdProducto,int IdUsuario){
        
        string sql = "INSERT INTO CARRITO (IdProducto, IdUsuario) VALUES (@IdProducto, @IdUsuario)";
        using(SqlConnection conexion = new SqlConnection(_connectionString)){
            conexion.Execute(sql, new{
                IdProducto = IdProducto,
                IdUsuario = IdUsuario,
            });

        }
        
    } 

    public static void ActualizarUsuario(Usuario u) 
    {
        /*string sql = "INSERT INTO Usuario (Nombre, Apellido, Username, Password, Email, Telefono, Direccion, FotoDePerfil)" + 
                 "VALUES (@Nombre, @Apellido, @Username, @Password, @Email, @Telefono, @Direccion, @FotoDePerfil);";*/
        string sql = "Update Usuario Set Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono, Direccion = @Direccion, FotoDePerfil = @FotoDePerfil Where IdUsuario = @IdUsuario;";
        using (SqlConnection conexion = new SqlConnection(_connectionString))
        {
        conexion.Execute(sql, new
        {
            Nombre = u.Nombre,
            Apellido = u.Apellido,
            Email = u.Email,
            Telefono = u.Telefono,
            Direccion = u.Direccion,
            FotoDePerfil = u.FotoDePerfil,
            IdUsuario = u.IdUsuario
        });
        }
    }



}