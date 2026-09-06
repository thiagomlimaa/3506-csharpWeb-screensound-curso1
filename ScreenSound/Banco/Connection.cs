// Connection from the DataBases


using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class Connection
{
    private string connectionString = @"Server=localhost\SQLEXPRESS;Database=ScreenSound;Trusted_Connection=True;TrustServerCertificate=True;";


    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }
    
}