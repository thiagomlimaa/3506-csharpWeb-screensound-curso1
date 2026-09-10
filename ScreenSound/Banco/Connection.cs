using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ScreenSound.Banco;

internal class Connection
{
    private string connectionstring = @"Server=localhost\SQLEXPRESS;Database=ScreenSound;Trusted_Connection=True;TrustServerCertificate=True";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionstring);
    }
}