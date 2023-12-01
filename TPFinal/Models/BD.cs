using System.Data.SqlClient;
using Dapper;

public class BD{
    private static string _connectionString = @"Server=DESKTOP-6QK3E9R\SQLEXPRESS01;DataBase=Techbuild;Trusted_Connection=True;";
    public static List<Producto> ObtenerProducto(string cat)
    {
        string sql = "select * from Producto Where Categoria = @Categoria";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
        
        return db.Query<Producto>(sql, new { Categoria = cat }).ToList();
        }
    }

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
    public static void AgregarPedido(Pedidos p){
        string sql = "INSERT INTO Pedidos (Motherboard,CPU,RAM,GPU,Almacenamiento,Cooler,Fuente,Gabinete,IdUsuario,Total)" + 
                 "VALUES (@Motherboard,@CPU,@RAM,@GPU,@Almacenamiento,@Cooler,@Fuente,@Gabinete,@IdUsuario,@Total);";
        using (SqlConnection conexion = new SqlConnection(_connectionString))
        {
            conexion.Execute(sql, new{
                Motherboard = p.MotherBoard,
                CPU = p.CPU,
                RAM = p.RAM,
                GPU = p.GPU,
                Almacenamiento = p.Almacenamiento,
                Cooler = p.Cooler,
                Fuente = p.Fuente,
                Gabinete = p.Gabinete,
                IdUsuario = p.IdUsuario,
                Total = p.Total
            });
        }
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
            resultado=db.QueryFirstOrDefault<int>(sql, new{pUsername=username,pContraseña=contraseña});
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
    public static Usuario buscarUsuario(string Email,string Contraseña)
    {
        Usuario usu;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql ="SELECT * FROM Usuario WHERE Email = @uEmail AND Contraseña= @uContraseña";
            usu = db.QueryFirstOrDefault<Usuario>(sql,new {uEmail = Email, uContraseña = Contraseña});
            }
        return usu;
    }

}