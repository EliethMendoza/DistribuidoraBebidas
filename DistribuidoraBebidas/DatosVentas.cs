using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DistribuidoraBebidas
{
    public class DatosVentas
    {
        // Estas propiedades deben coincidir exactamente con los nombres que usas al pintar o leer celdas en el carrito
        public string IdProducto { get; set; }
        public string NombreMarca { get; set; }
        public string NombreCategoria { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int StockActual { get; set; }

        private ConexionBD bd = new ConexionBD();

        public List<DatosVentas> ObtenerProductosVentas(string filtro = "")
        {
            List<DatosVentas> lista = new List<DatosVentas>();

            using (SqlConnection connect = bd.ObtenerConexion())
            {
                try
                {
                    connect.Open();
                    // Incluimos m.NombreMarca y c.NombreCategoria en el WHERE para que filtre por todo
                    string query = @"SELECT 
                                        p.IdProducto, 
                                        m.NombreMarca, 
                                        c.NombreCategoria, 
                                        p.NombreProducto, 
                                        p.PrecioUnidad, 
                                        p.StockActual 
                                     FROM Productos p
                                     INNER JOIN Marcas m ON p.IdMarca = m.IdMarca
                                     INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
                                     WHERE p.NombreProducto LIKE @filtro 
                                        OR p.IdProducto LIKE @filtro 
                                        OR m.NombreMarca LIKE @filtro 
                                        OR c.NombreCategoria LIKE @filtro";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro.Trim() + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DatosVentas item = new DatosVentas
                                {
                                    IdProducto = reader["IdProducto"].ToString(),
                                    NombreMarca = reader["NombreMarca"].ToString(),
                                    NombreCategoria = reader["NombreCategoria"].ToString(),
                                    NombreProducto = reader["NombreProducto"].ToString(),
                                    PrecioUnidad = Convert.ToDecimal(reader["PrecioUnidad"]),
                                    StockActual = Convert.ToInt32(reader["StockActual"])
                                };
                                lista.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar productos de venta: " + ex.Message);
                }
            }

            return lista;
        }
    }
}