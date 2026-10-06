using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace DistribuidoraBebidas
{
    internal class DatosMarcas
    {
        public string IdMarca { set; get; }
        public string NombreMarca { set; get; }

        public List<DatosMarcas> TodasLasMarcas()
        {
            List<DatosMarcas> listaDatos = new List<DatosMarcas>();
            ConexionBD conexion = new ConexionBD();

            using (SqlConnection connect = conexion.ObtenerConexion())
            {
                connect.Open();

                string selectData = "SELECT IdMarca, NombreMarca FROM Marcas";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DatosMarcas mData = new DatosMarcas();
                        mData.IdMarca = reader["IdMarca"].ToString();
                        mData.NombreMarca = reader["NombreMarca"].ToString();

                        listaDatos.Add(mData);
                    }
                }
            }
            return listaDatos;
        }
    }
}