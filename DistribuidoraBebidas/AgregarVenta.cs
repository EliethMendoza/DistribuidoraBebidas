using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DistribuidoraBebidas
{
    public partial class AgregarVenta : UserControl
    {
        private SqlConnection connect;
        private ConexionBD bd = new ConexionBD();

        // Valores por defecto para entrega directa
        private string idUsuarioDefault = "U001";
        private string idClienteDefault = "C001";
        private string idMetodoPagoDefault = "MP01";

        public AgregarVenta()
        {
            InitializeComponent();
            connect = bd.ObtenerConexion();

            this.Load += new EventHandler(AgregarVenta_Load);
            this.Enter += new EventHandler(AgregarVenta_Enter);
        }

        private void AgregarVenta_Load(object sender, EventArgs e)
        {
            InicializarEstructuraCarrito();
            ConfigurarBotonAgregarProductos();
            CargarDatosProductos();
            VincularEventosBuscador();
        }

        private void AgregarVenta_Enter(object sender, EventArgs e)
        {
            CargarDatosProductos();
        }

        public bool ComprobarConexion()
        {
            return connect.State == ConnectionState.Closed;
        }

        // ==========================================
        // 1. CONFIGURACIÓN DE TABLAS Y BUSCADOR
        // ==========================================

        private void VincularEventosBuscador()
        {
            // Vinculación por código para garantizar que el buscador responda al escribir
            txtBuscarProducto.TextChanged -= txtBuscarProducto_TextChanged;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;

            btnBuscar.Click -= btnBuscar_Click;
            btnBuscar.Click += btnBuscar_Click;
        }

        public void CargarDatosProductos(string filtro = "")
        {
            DatosVentas vData = new DatosVentas();
            List<DatosVentas> listaDatos = vData.ObtenerProductosVentas(filtro);
            dgvProductos.DataSource = listaDatos;
        }

        private void ConfigurarBotonAgregarProductos()
        {
            if (!dgvProductos.Columns.Contains("btnAgregarCol"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "btnAgregarCol";
                btnCol.HeaderText = "Acción";
                btnCol.Text = "+ Agregar";
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Width = 80;
                dgvProductos.Columns.Add(btnCol);
            }
        }

        private void InicializarEstructuraCarrito()
        {
            dgvCarrito.Columns.Clear();
            dgvCarrito.Rows.Clear();

            dgvCarrito.Columns.Add("IdProducto", "ID");
            dgvCarrito.Columns.Add("NombreProducto", "Producto");
            dgvCarrito.Columns.Add("Cantidad", "Cant.");
            dgvCarrito.Columns.Add("PrecioVenta", "Precio");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");

            // Botón de Sumar en Carrito
            DataGridViewButtonColumn btnSumar = new DataGridViewButtonColumn();
            btnSumar.Name = "btnSumar";
            btnSumar.HeaderText = "+";
            btnSumar.Text = "+";
            btnSumar.UseColumnTextForButtonValue = true;
            btnSumar.Width = 35;
            dgvCarrito.Columns.Add(btnSumar);

            // Botón de Restar en Carrito
            DataGridViewButtonColumn btnRestar = new DataGridViewButtonColumn();
            btnRestar.Name = "btnRestar";
            btnRestar.HeaderText = "-";
            btnRestar.Text = "-";
            btnRestar.UseColumnTextForButtonValue = true;
            btnRestar.Width = 35;
            dgvCarrito.Columns.Add(btnRestar);

            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;
        }

        // ==========================================
        // 2. LÓGICA DEL BUSCADOR
        // ==========================================

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            CargarDatosProductos(txtBuscarProducto.Text.Trim());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatosProductos(txtBuscarProducto.Text.Trim());
        }

        // ==========================================
        // 3. ACCIONES EN TABLA DE PRODUCTOS
        // ==========================================

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductos.Columns[e.ColumnIndex].Name == "btnAgregarCol")
            {
                AgregarProductoAlCarrito(e.RowIndex);
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AgregarProductoAlCarrito(e.RowIndex);
            }
        }

        private void AgregarProductoAlCarrito(int rowIndex)
        {
            DataGridViewRow fila = dgvProductos.Rows[rowIndex];

            string idProducto = fila.Cells["IdProducto"].Value.ToString();
            string nombre = fila.Cells["NombreProducto"].Value.ToString();
            decimal precio = Convert.ToDecimal(fila.Cells["PrecioUnidad"].Value);
            int stockAvailable = Convert.ToInt32(fila.Cells["StockActual"].Value);

            if (stockAvailable <= 0)
            {
                MessageBox.Show("Este producto no tiene stock disponible.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool existe = false;
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.Cells["IdProducto"].Value.ToString() == idProducto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    if (cantidadActual + 1 > stockAvailable)
                    {
                        MessageBox.Show("No hay suficiente stock disponible.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["Cantidad"].Value = cantidadActual + 1;
                    row.Cells["Subtotal"].Value = (cantidadActual + 1) * precio;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dgvCarrito.Rows.Add(idProducto, nombre, 1, precio, precio);
            }

            CalcularTotales();
        }

        // ==========================================
        // 4. ACCIONES EN TABLA DEL CARRITO
        // ==========================================

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombreColumna = dgvCarrito.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "btnSumar")
                {
                    SumarUnidadCarrito(e.RowIndex);
                }
                else if (nombreColumna == "btnRestar")
                {
                    RestarUnidadCarrito(e.RowIndex);
                }
            }
        }

        private void SumarUnidadCarrito(int rowIndex)
        {
            DataGridViewRow fila = dgvCarrito.Rows[rowIndex];
            string idProducto = fila.Cells["IdProducto"].Value.ToString();
            int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
            decimal precio = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value);

            int stockAvailable = 0;
            foreach (DataGridViewRow prodRow in dgvProductos.Rows)
            {
                if (prodRow.Cells["IdProducto"].Value.ToString() == idProducto)
                {
                    stockAvailable = Convert.ToInt32(prodRow.Cells["StockActual"].Value);
                    break;
                }
            }

            if (cantidadActual + 1 > stockAvailable)
            {
                MessageBox.Show("No hay suficiente stock disponible.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fila.Cells["Cantidad"].Value = cantidadActual + 1;
            fila.Cells["Subtotal"].Value = (cantidadActual + 1) * precio;

            CalcularTotales();
        }

        private void RestarUnidadCarrito(int rowIndex)
        {
            DataGridViewRow fila = dgvCarrito.Rows[rowIndex];
            int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
            decimal precio = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value);

            if (cantidadActual > 1)
            {
                fila.Cells["Cantidad"].Value = cantidadActual - 1;
                fila.Cells["Subtotal"].Value = (cantidadActual - 1) * precio;
            }
            else
            {
                dgvCarrito.Rows.RemoveAt(rowIndex);
            }

            CalcularTotales();
        }

        private void dgvCarrito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvCarrito.CurrentRow != null)
            {
                dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentRow.Index);
                CalcularTotales();
            }
        }

        // ==========================================
        // 5. CÁLCULOS Y PROCESO DE VENTA
        // ==========================================

        private void CalcularTotales()
        {
            int totalCant = 0;
            decimal sub = 0;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                totalCant += Convert.ToInt32(row.Cells["Cantidad"].Value);
                sub += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            decimal imp = sub * 0.15m;
            decimal tot = sub + imp;

            totalArticulos.Text = totalCant.ToString();
            subtotal.Text = sub.ToString("N2");
            impuestos.Text = imp.ToString("N2");
            total.Text = tot.ToString("N2");
        }

        public void LimpiarCampos()
        {
            dgvCarrito.Rows.Clear();
            totalArticulos.Text = "0";
            subtotal.Text = "0.00";
            impuestos.Text = "0.00";
            total.Text = "0.00";
            txtBuscarProducto.Clear();
            CargarDatosProductos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private string GenerarIdVenta()
        {
            Random random = new Random();
            return "V" + random.Next(1000, 9999);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue productos antes de procesar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de procesar la venta por C$ " + total.Text + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ComprobarConexion())
                {
                    try
                    {
                        connect.Open();
                        SqlTransaction transaction = connect.BeginTransaction();

                        try
                        {
                            string idVenta = GenerarIdVenta();
                            decimal totalVentaVal = Convert.ToDecimal(total.Text);

                            string insertVenta = @"INSERT INTO Ventas (IdVenta, IdCliente, FechaVenta, TotalVenta, IdMetodoPago, IdUsuario) 
                                                  VALUES (@idVenta, @idCliente, @fecha, @total, @idMetodo, @idUsuario)";

                            using (SqlCommand cmdVenta = new SqlCommand(insertVenta, connect, transaction))
                            {
                                cmdVenta.Parameters.AddWithValue("@idVenta", idVenta);
                                cmdVenta.Parameters.AddWithValue("@idCliente", idClienteDefault);
                                cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now);
                                cmdVenta.Parameters.AddWithValue("@total", totalVentaVal);
                                cmdVenta.Parameters.AddWithValue("@idMetodo", idMetodoPagoDefault);
                                cmdVenta.Parameters.AddWithValue("@idUsuario", idUsuarioDefault);

                                cmdVenta.ExecuteNonQuery();
                            }

                            int contadorDetalle = 1;

                            foreach (DataGridViewRow row in dgvCarrito.Rows)
                            {
                                string idDetalle = "D" + idVenta + "_" + contadorDetalle;
                                string idProducto = row.Cells["IdProducto"].Value.ToString();
                                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                                decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);
                                decimal subtotalVal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                                string insertDetalle = @"INSERT INTO VentasDetalle (IdDetalle, IdVenta, IdProducto, Cantidad, PrecioVenta, Subtotal) 
                                                        VALUES (@idDetalle, @idVenta, @idProducto, @cant, @precio, @subtotal)";

                                using (SqlCommand cmdDetalle = new SqlCommand(insertDetalle, connect, transaction))
                                {
                                    cmdDetalle.Parameters.AddWithValue("@idDetalle", idDetalle);
                                    cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                                    cmdDetalle.Parameters.AddWithValue("@idProducto", idProducto);
                                    cmdDetalle.Parameters.AddWithValue("@cant", cantidad);
                                    cmdDetalle.Parameters.AddWithValue("@precio", precioVenta);
                                    cmdDetalle.Parameters.AddWithValue("@subtotal", subtotalVal);

                                    cmdDetalle.ExecuteNonQuery();
                                }

                                string updateStock = @"UPDATE Productos SET StockActual = StockActual - @cant WHERE IdProducto = @idProducto";

                                using (SqlCommand cmdStock = new SqlCommand(updateStock, connect, transaction))
                                {
                                    cmdStock.Parameters.AddWithValue("@cant", cantidad);
                                    cmdStock.Parameters.AddWithValue("@idProducto", idProducto);

                                    cmdStock.ExecuteNonQuery();
                                }

                                contadorDetalle++;
                            }

                            transaction.Commit();
                            MessageBox.Show("¡Venta completada exitosamente! (ID: " + idVenta + ")", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarCampos();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error al registrar la venta: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexión fallida: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                        CargarDatosProductos();
                    }
                }
            }
        }
    }
}