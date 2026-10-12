using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraBebidas
{
    internal class ConexionBD
    {
        private string cadenaConexion =
            "Server=localhost\\SQLEXPRESS;" +
            "Database=DistribuidoraBebidas;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
