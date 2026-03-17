using System.Data.SqlClient;

namespace MusicStationWinFormsApp.database;

public class ConnectionFactory
{
    
    private string _connectionString = @"Server=OSA0716346W11-1\SQLEXPRESS; 
                                        Database=MusicStation; 
                                        Trusted_Connection=True; 
                                        TrustServerCertificate=True;";

    public SqlConnection AbrirConexao()
    {
        return new SqlConnection(_connectionString);
    }
}