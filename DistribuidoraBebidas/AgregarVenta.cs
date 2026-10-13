using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DistribuidoraBebidas
{
    public partial class AgregarVenta : UserControl
    {
        private SqlConnection connect;
        private ConexionBD bd = new ConexionBD();

        private PrintDocument printDocument1 = new PrintDocument();

        private string idMetodoPagoDefault = "MP01";

        public AgregarVenta()
        {
            InitializeComponent();
            connect = bd.ObtenerConexion();

            this.Load += new EventHandler(AgregarVenta_Load);
            this.Enter += new EventHandler(AgregarVenta_Enter);

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            CargarClientesEnComboBox();
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
            CargarClientesEnComboBox();
        }

        public bool ComprobarConexion()
        {
            return connect.State == ConnectionState.Closed;
        }

        private void VincularEventosBuscador()
        {
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

        private void CargarClientesEnComboBox()
        {
            try
            {
                using (SqlConnection connect = bd.ObtenerConexion())
                {
                    connect.Open();
                    string query = "SELECT IdCliente, NombreCliente FROM Clientes";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            cbClientes.DataSource = dt;
                            cbClientes.DisplayMember = "NombreCliente";
                            cbClientes.ValueMember = "IdCliente";
                            cbClientes.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerOInsertarCliente(string nombreCliente, SqlConnection conn, SqlTransaction trans)
        {
            string queryCheck = "SELECT IdCliente FROM Clientes WHERE NombreCliente = @nombre";
            using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn, trans))
            {
                cmdCheck.Parameters.AddWithValue("@nombre", nombreCliente.Trim());
                object result = cmdCheck.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }
            }

            string nuevoIdCliente = "C" + new Random().Next(1000, 9999);

            string queryInsert = "INSERT INTO Clientes (IdCliente, NombreCliente, Fecha) VALUES (@id, @nombre, @fecha)";
            using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, trans))
            {
                cmdInsert.Parameters.AddWithValue("@id", nuevoIdCliente);
                cmdInsert.Parameters.AddWithValue("@nombre", nombreCliente.Trim());
                cmdInsert.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmdInsert.ExecuteNonQuery();
            }

            return nuevoIdCliente;
        }

        private string ObtenerOCrearClienteGenerico(SqlConnection conn, SqlTransaction trans)
        {
            string idGenerico = "C0000";

            string queryCheck = "SELECT COUNT(1) FROM Clientes WHERE IdCliente = @id";
            using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn, trans))
            {
                cmdCheck.Parameters.AddWithValue("@id", idGenerico);
                int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (existe == 0)
                {
                    string queryInsert = "INSERT INTO Clientes (IdCliente, NombreCliente, Fecha) VALUES (@id, 'Cliente Genérico', @fecha)";
                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, trans))
                    {
                        cmdInsert.Parameters.AddWithValue("@id", idGenerico);
                        cmdInsert.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
            }

            return idGenerico;
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

            DataGridViewButtonColumn btnSumar = new DataGridViewButtonColumn();
            btnSumar.Name = "btnSumar";
            btnSumar.HeaderText = "+";
            btnSumar.Text = "+";
            btnSumar.UseColumnTextForButtonValue = true;
            btnSumar.Width = 35;
            dgvCarrito.Columns.Add(btnSumar);

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

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            CargarDatosProductos(txtBuscarProducto.Text.Trim());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatosProductos(txtBuscarProducto.Text.Trim());
        }

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
            cbClientes.SelectedIndex = -1;
            CargarDatosProductos();
            CargarClientesEnComboBox();
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
                            string idClienteReal = "";

                            if (string.IsNullOrWhiteSpace(cbClientes.Text))
                            {
                                idClienteReal = ObtenerOCrearClienteGenerico(connect, transaction);
                            }
                            else if (cbClientes.SelectedValue != null && cbClientes.Text == cbClientes.GetItemText(cbClientes.SelectedItem))
                            {
                                idClienteReal = cbClientes.SelectedValue.ToString();
                            }
                            else
                            {
                                idClienteReal = ObtenerOInsertarCliente(cbClientes.Text.Trim(), connect, transaction);
                            }

                            string idMetodoReal = ObtenerIdValido("SELECT TOP 1 IdMetodoPago FROM MetodosPago ORDER BY IdMetodoPago ASC", connect, transaction);
                            string idUsuarioReal = SesionUsuario.IdUsuarioLogueado;

                            if (string.IsNullOrEmpty(idUsuarioReal))
                            {
                                MessageBox.Show("No se detectó una sesión de usuario activa. Inicie sesión nuevamente.", "Error de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return;
                            }

                            if (string.IsNullOrEmpty(idClienteReal) || string.IsNullOrEmpty(idMetodoReal))
                            {
                                MessageBox.Show("Asegúrese de tener registrado al menos un Método de Pago en la base de datos.", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return;
                            }

                            string idVenta = GenerarIdVenta();
                            decimal totalVentaVal = Convert.ToDecimal(total.Text);

                            string insertVenta = @"INSERT INTO Ventas (IdVenta, IdCliente, FechaVenta, TotalVenta, IdMetodoPago, IdUsuario) 
                                                   VALUES (@idVenta, @idCliente, @fecha, @total, @idMetodo, @idUsuario)";

                            using (SqlCommand cmdVenta = new SqlCommand(insertVenta, connect, transaction))
                            {
                                cmdVenta.Parameters.AddWithValue("@idVenta", idVenta);
                                cmdVenta.Parameters.AddWithValue("@idCliente", idClienteReal);
                                cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now);
                                cmdVenta.Parameters.AddWithValue("@total", totalVentaVal);
                                cmdVenta.Parameters.AddWithValue("@idMetodo", idMetodoReal);
                                cmdVenta.Parameters.AddWithValue("@idUsuario", idUsuarioReal);

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

                            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Ticket", 315, 600);
                            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(5, 5, 5, 5);

                            PrintPreviewDialog previewDlg = new PrintPreviewDialog();
                            previewDlg.Document = printDocument1;
                            previewDlg.Width = 400;
                            previewDlg.Height = 600;
                            previewDlg.ShowDialog();

                            MessageBox.Show("¡Venta completada exitosamente! (ID: " + idVenta + ")", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarCampos();
                            CargarClientesEnComboBox();
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

        // Método que dibuja el diseño del ticket térmico en el documento de impresión
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fuenteTitulo = new Font("Consolas", 11, FontStyle.Bold);
            Font fuenteNegrita = new Font("Consolas", 9, FontStyle.Bold);
            Font fuenteNormal = new Font("Consolas", 8, FontStyle.Regular);

            float x = 5;
            float y = 5;

            // --- ENCABEZADO ---
            e.Graphics.DrawString("DISTRIBUIDORA BEBIDAS", fuenteTitulo, Brushes.Black, x + 20, y);
            y += 18;
            e.Graphics.DrawString("RUC: J0310000000000", fuenteNormal, Brushes.Black, x + 45, y);
            y += 14;
            e.Graphics.DrawString("Managua, Nicaragua", fuenteNormal, Brushes.Black, x + 40, y);
            y += 18;

            e.Graphics.DrawString("----------------------------------------", fuenteNormal, Brushes.Black, x, y);
            y += 14;

            // --- DATOS ---
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuenteNormal, Brushes.Black, x, y);
            y += 14;
            e.Graphics.DrawString("Cliente: " + (cbClientes.Text == "" ? "Cliente Genérico" : cbClientes.Text), fuenteNormal, Brushes.Black, x, y);
            y += 14;
            e.Graphics.DrawString("Atendido por: " + SesionUsuario.IdUsuarioLogueado, fuenteNormal, Brushes.Black, x, y);
            y += 18;

            e.Graphics.DrawString("----------------------------------------", fuenteNormal, Brushes.Black, x, y);
            y += 14;

            // --- DETALLE ---
            e.Graphics.DrawString("CANT  DESCRIPCIÓN          TOTAL", fuenteNegrita, Brushes.Black, x, y);
            y += 14;
            e.Graphics.DrawString("----------------------------------------", fuenteNormal, Brushes.Black, x, y);
            y += 14;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                string cant = row.Cells["Cantidad"].Value.ToString();
                string producto = row.Cells["NombreProducto"].Value.ToString();
                string subtotalItem = row.Cells["Subtotal"].Value.ToString();

                if (producto.Length > 16)
                    producto = producto.Substring(0, 16);

                string lineaItem = $"{cant.PadLeft(3)}   {producto.PadRight(16)} {subtotalItem.PadLeft(7)}";
                e.Graphics.DrawString(lineaItem, fuenteNormal, Brushes.Black, x, y);
                y += 14;
            }

            e.Graphics.DrawString("----------------------------------------", fuenteNormal, Brushes.Black, x, y);
            y += 14;

            // --- TOTALES ---
            e.Graphics.DrawString("SUBTOTAL:".PadRight(22) + "C$ " + subtotal.Text.PadLeft(10), fuenteNormal, Brushes.Black, x, y);
            y += 14;
            e.Graphics.DrawString("IVA (15%):".PadRight(22) + "C$ " + impuestos.Text.PadLeft(10), fuenteNormal, Brushes.Black, x, y);
            y += 16;
            e.Graphics.DrawString("TOTAL A PAGAR:".PadRight(19) + "C$ " + total.Text.PadLeft(10), fuenteNegrita, Brushes.Black, x, y);
            y += 22;

            // --- PIE ---
            e.Graphics.DrawString("¡Gracias por su compra!", fuenteNegrita, Brushes.Black, x + 35, y);
        }

        private string ObtenerIdValido(string query, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn, trans))
            {
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "";
            }
        }
    }
}