using System.Data.SqlClient;
using Dapper;

public class BD{
    private static string _connectionString = @"Server=localhost;DataBase=Techbuild;Trusted_Connection=True;";
    public static List<Producto> ObtenerProducto()
    {
    
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
        string sql = "select * from Producto";
        return db.Query<Producto>(sql).ToList();
        }
    }

    public Usuario ObtenerUsuario(Usuario u) 
    {

        Usuario user= new Usuario();
        using (SqlConnection db=new SqlConnection(_connectionString)){
            string sql = "EXEC GetUsuario @Usuario";
            user=db.QueryFirstOrDefault<Usuario>(sql, new{user=u});
        }
        return user;
    }

    public static void RegistrarUsuario(Usuario u) 
    {
        string sql = "INSERT INTO Usuario (Nombre, Apellido, Username, Email, Telefono, Direccion, FotoDePerfil)" + 
                 "VALUES (@Nombre, @Apellido, @Username, @Email, @Telefono, @Direccion, @FotoDePerfil);";
        using (SqlConnection conexion = new SqlConnection(_connectionString))
        {
        conexion.Execute(sql, new
        {
            Nombre = u.Nombre,
            Apellido = u.Apellido,
            Username = u.Username,
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

}