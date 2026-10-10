using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DistribuidoraBebidas
{
    public class VentaEncabezado
    {
        public string IdVenta { get; set; }
        public string IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public string IdMetodoPago { get; set; }
        public string IdUsuario { get; set; }
    }

    public class VentaDetalleItem
    {
        public string IdDetalle { get; set; }
        public string IdVenta { get; set; }
        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class DatosVentaDetalle
    {
        private ConexionBD bd = new ConexionBD();

        // Consulta para dgvVentas (Tabla Principal)
        public List<VentaEncabezado> ObtenerVentas(string filtro = "")
        {
            List<VentaEncabezado> lista = new List<VentaEncabezado>();

            using (SqlConnection connect = bd.ObtenerConexion())
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string query = @"SELECT IdVenta, IdCliente, FechaVenta, TotalVenta, IdMetodoPago, IdUsuario 
                                         FROM Ventas 
                                         WHERE IdVenta LIKE @filtro OR IdCliente LIKE @filtro OR IdUsuario LIKE @filtro
                                         ORDER BY FechaVenta DESC";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    lista.Add(new VentaEncabezado
                                    {
                                        IdVenta = reader["IdVenta"].ToString(),
                                        IdCliente = reader["IdCliente"].ToString(),
                                        FechaVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                        TotalVenta = Convert.ToDecimal(reader["TotalVenta"]),
                                        IdMetodoPago = reader["IdMetodoPago"].ToString(),
                                        IdUsuario = reader["IdUsuario"].ToString()
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al consultar ventas: " + ex.Message);
                    }
                }
            }
            return lista;
        }

        // Consulta para dgvVentaDetalles (Tabla Secundaria según la venta seleccionada)
        public List<VentaDetalleItem> ObtenerDetallesPorVenta(string idVenta, string filtro = "")
        {
            List<VentaDetalleItem> lista = new List<VentaDetalleItem>();

            if (string.IsNullOrEmpty(idVenta)) return lista;

            using (SqlConnection connect = bd.ObtenerConexion())
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string query = @"SELECT 
                                            vd.IdDetalle, 
                                            vd.IdVenta, 
                                            vd.IdProducto, 
                                            p.NombreProducto, 
                                            vd.Cantidad, 
                                            vd.PrecioVenta, 
                                            vd.Subtotal 
                                         FROM VentasDetalle vd
                                         INNER JOIN Productos p ON vd.IdProducto = p.IdProducto
                                         WHERE vd.IdVenta = @idVenta 
                                         AND (p.NombreProducto LIKE @filtro OR vd.IdDetalle LIKE @filtro)";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@idVenta", idVenta);
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    lista.Add(new VentaDetalleItem
                                    {
                                        IdDetalle = reader["IdDetalle"].ToString(),
                                        IdVenta = reader["IdVenta"].ToString(),
                                        IdProducto = reader["IdProducto"].ToString(),
                                        NombreProducto = reader["NombreProducto"].ToString(),
                                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                        PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                                        Subtotal = Convert.ToDecimal(reader["Subtotal"])
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al consultar detalles: " + ex.Message);
                    }
                }
            }
            return lista;
        }
    }
}