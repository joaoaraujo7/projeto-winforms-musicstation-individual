using System.Data.SqlClient;

namespace MusicStationWinFormsApp.data;

public class ConnectionFactory
{
    
    private string _connectionString = @"Server=DESKTOP-L74NRU3\SQLEXPRESS; 
                                        Database=meu_banco; 
                                        Trusted_Connection=True; 
                                        TrustServerCertificate=True;";

    public SqlConnection AbrirConexao()
    {
        return new SqlConnection(_connectionString);
    }
}