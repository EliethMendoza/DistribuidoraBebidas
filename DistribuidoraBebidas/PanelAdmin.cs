using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DistribuidoraBebidas
{
    public partial class PanelAdmin : UserControl
    {
        private ConexionBD bd = new ConexionBD();
        public PanelAdmin()
        {
            InitializeComponent();
            CargarDatosDashboard();
        }

        public void CargarDatosDashboard()
        {
            try
            {
                using (SqlConnection connect = bd.ObtenerConexion())
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios", connect))
                    {
                        object resUsuarios = cmd.ExecuteScalar();
                        lblUsuarios.Text = (resUsuarios != null) ? resUsuarios.ToString() : "0";
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clientes", connect))
                    {
                        object resClientes = cmd.ExecuteScalar();
                        lblClientes.Text = (resClientes != null) ? resClientes.ToString() : "0";
                    }

                    string queryIngresosHoy = "SELECT ISNULL(SUM(TotalVenta), 0) FROM Ventas WHERE CAST(FechaVenta AS DATE) = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(queryIngresosHoy, connect))
                    {
                        decimal ingresosHoy = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblIngresosHoy.Text = "C$ " + ingresosHoy.ToString("N2");
                    }

                    string queryIngresosTotales = "SELECT ISNULL(SUM(TotalVenta), 0) FROM Ventas";
                    using (SqlCommand cmd = new SqlCommand(queryIngresosTotales, connect))
                    {
                        decimal ingresosTotales = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblIngresosTotales.Text = "C$ " + ingresosTotales.ToString("N2");
                    }

                    string queryVentasHoy = @"SELECT V.IdVenta, C.NombreCliente, V.FechaVenta, V.TotalVenta 
                          FROM Ventas V
                          INNER JOIN Clientes C ON V.IdCliente = C.IdCliente
                          WHERE CAST(V.FechaVenta AS DATE) = CAST(GETDATE() AS DATE)
                          ORDER BY V.FechaVenta DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(queryVentasHoy, connect))
                    {
                        DataTable dtVentasHoy = new DataTable();
                        adapter.Fill(dtVentasHoy);
                        dgvVentas.DataSource = dtVentasHoy;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
