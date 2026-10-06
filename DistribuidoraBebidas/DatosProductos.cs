using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace DistribuidoraBebidas
{
    internal class DatosProductos
    {
        public string IdProducto { set; get; }
        public string IdMarca { set; get; }
        public string IdCategoria { set; get; }
        public string NombreProducto { set; get; }
        public decimal PrecioUnidad { set; get; }
        public int StockActual { set; get; }

        public List<DatosProductos> TodosLosProductos()
        {
            List<DatosProductos> listaDatos = new List<DatosProductos>();
            ConexionBD conexion = new ConexionBD();

            using (SqlConnection connect = conexion.ObtenerConexion())
            {
                connect.Open();

                string selectData = "SELECT IdProducto, IdMarca, IdCategoria, NombreProducto, PrecioUnidad, StockActual FROM Productos";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DatosProductos pData = new DatosProductos();
                        pData.IdProducto = reader["IdProducto"].ToString();
                        pData.IdMarca = reader["IdMarca"].ToString();
                        pData.IdCategoria = reader["IdCategoria"].ToString();
                        pData.NombreProducto = reader["NombreProducto"].ToString();
                        pData.PrecioUnidad = Convert.ToDecimal(reader["PrecioUnidad"]);
                        pData.StockActual = Convert.ToInt32(reader["StockActual"]);

                        listaDatos.Add(pData);
                    }
                }
            }
            return listaDatos;
        }
    }
}