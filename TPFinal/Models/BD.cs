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
    //Temp: Existe pero no se usa, porque existe esta función y porque apunta a un SP que no existe?
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
    public static void GuardarProducto(int IdProducto,Usuario IdUsuario){
        
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
        string sql = "Update Usuario Set Nombre = @Nombre, Apellido = @Apellido, Username = @Username, Email = @Email, Telefono = @Telefono, Direccion = @Direccion, FotoDePerfil = @FotoDePerfil Where IdUsuario = @IdUsuario;";
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



}