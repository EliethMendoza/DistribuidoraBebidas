using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace DistribuidoraBebidas
{
    internal class DatosCategorias
    {
        public string IdCategoria { set; get; }
        public string NombreCategoria { set; get; }
        public string Fecha { set; get; }

        public List<DatosCategorias> TodasLasCategorias()
        {
            List<DatosCategorias> listaDatos = new List<DatosCategorias>();
            ConexionBD conexion = new ConexionBD();

            using (SqlConnection connect = conexion.ObtenerConexion())
            {
                connect.Open();

                string selectData = "SELECT IdCategoria, NombreCategoria, Fecha FROM Categorias";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DatosCategorias catData = new DatosCategorias();
                        catData.IdCategoria = reader["IdCategoria"].ToString();
                        catData.NombreCategoria = reader["NombreCategoria"].ToString();
                        catData.Fecha = reader["Fecha"].ToString();

                        listaDatos.Add(catData);
                    }
                }
            }
            return listaDatos;
        }
    }
}