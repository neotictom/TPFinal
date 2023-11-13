using System.Data.SqlClient;
using Dapper;
using Series.Models;
namespace Series.Models;
public class BD{
    private static string _connectionString = @"Server=localhost;DataBase=TechBuildDB;Trusted_Connection=True;";
public static List<Producto> ObtenerProducto(){
    
    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "select * from Producto";
        return db.Query<Producto>(sql).ToList();
    }
}



}