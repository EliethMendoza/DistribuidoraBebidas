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
    public partial class AgregarProductos : UserControl
    {
        SqlConnection connect;
        private ConexionBD bd = new ConexionBD();
        private string idProductoSeleccionado = "";

        public AgregarProductos()
        {
            InitializeComponent();
            connect = bd.ObtenerConexion();

            CargarMarcas();
            CargarCategorias();
            CargarDatosTabla();
        }

        public void CargarDatosTabla()
        {
            DatosProductos pData = new DatosProductos();
            List<DatosProductos> listaDatos = pData.TodosLosProductos();
            dgvProductos.DataSource = listaDatos;
        }

        public void CargarMarcas()
        {
            if (ComprobarConexion())
            {
                try
                {
                    connect.Open();
                    string selectMarcas = "SELECT IdMarca, NombreMarca FROM Marcas";

                    using (SqlCommand cmd = new SqlCommand(selectMarcas, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        cbxMarca.DataSource = table;
                        cbxMarca.DisplayMember = "NombreMarca";
                        cbxMarca.ValueMember = "IdMarca";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar marcas: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void CargarCategorias()
        {
            if (ComprobarConexion())
            {
                try
                {
                    connect.Open();
                    string selectCat = "SELECT IdCategoria, NombreCategoria FROM Categorias";

                    using (SqlCommand cmd = new SqlCommand(selectCat, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        cbxCategoria.DataSource = table;
                        cbxCategoria.DisplayMember = "NombreCategoria";
                        cbxCategoria.ValueMember = "IdCategoria";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private string GenerarIdAleatorio()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return "P" + numero;
        }

        public bool ComprobarConexion()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LimpiarCampos()
        {
            nombreProducto.Clear();
            precioProducto.Clear();
            stockProducto.Clear();
            idProductoSeleccionado = "";

            if (cbxMarca.Items.Count > 0) cbxMarca.SelectedIndex = 0;
            if (cbxCategoria.Items.Count > 0) cbxCategoria.SelectedIndex = 0;

            if (dgvProductos.SelectedRows.Count > 0)
            {
                dgvProductos.ClearSelection();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                string idMarca = row.Cells[1].Value.ToString();
                string idCat = row.Cells[2].Value.ToString();
                string nombre = row.Cells[3].Value.ToString();
                string precio = row.Cells[4].Value.ToString();
                string stock = row.Cells[5].Value.ToString();

                idProductoSeleccionado = id;
                cbxMarca.SelectedValue = idMarca;
                cbxCategoria.SelectedValue = idCat;
                nombreProducto.Text = nombre;
                precioProducto.Text = precio;
                stockProducto.Text = stock;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreProducto.Text == "" || precioProducto.Text == "" || stockProducto.Text == "" || cbxMarca.SelectedIndex == -1 || cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (ComprobarConexion())
                {
                    try
                    {
                        connect.Open();

                        string checkProd = "SELECT * FROM Productos WHERE NombreProducto = @nom";

                        using (SqlCommand cmd = new SqlCommand(checkProd, connect))
                        {
                            cmd.Parameters.AddWithValue("@nom", nombreProducto.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("El producto '" + nombreProducto.Text.Trim() + "' ya existe.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Productos (IdProducto, IdMarca, IdCategoria, NombreProducto, PrecioUnidad, StockActual) VALUES (@id, @idMarca, @idCat, @nom, @precio, @stock)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@id", GenerarIdAleatorio());
                                    insertD.Parameters.AddWithValue("@idMarca", cbxMarca.SelectedValue.ToString());
                                    insertD.Parameters.AddWithValue("@idCat", cbxCategoria.SelectedValue.ToString());
                                    insertD.Parameters.AddWithValue("@nom", nombreProducto.Text.Trim());
                                    insertD.Parameters.AddWithValue("@precio", Convert.ToDecimal(precioProducto.Text.Trim()));
                                    insertD.Parameters.AddWithValue("@stock", Convert.ToInt32(stockProducto.Text.Trim()));

                                    insertD.ExecuteNonQuery();
                                    LimpiarCampos();
                                    CargarDatosTabla();

                                    MessageBox.Show("¡Agregado exitosamente!", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexión fallida: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (nombreProducto.Text == "" || precioProducto.Text == "" || stockProducto.Text == "" || cbxMarca.SelectedIndex == -1 || cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea actualizar el producto " + idProductoSeleccionado + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE Productos SET IdMarca = @idMarca, IdCategoria = @idCat, NombreProducto = @nom, PrecioUnidad = @precio, StockActual = @stock WHERE IdProducto = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@idMarca", cbxMarca.SelectedValue.ToString());
                                updateD.Parameters.AddWithValue("@idCat", cbxCategoria.SelectedValue.ToString());
                                updateD.Parameters.AddWithValue("@nom", nombreProducto.Text.Trim());
                                updateD.Parameters.AddWithValue("@precio", Convert.ToDecimal(precioProducto.Text.Trim()));
                                updateD.Parameters.AddWithValue("@stock", Convert.ToInt32(stockProducto.Text.Trim()));
                                updateD.Parameters.AddWithValue("@id", idProductoSeleccionado);

                                updateD.ExecuteNonQuery();
                                LimpiarCampos();
                                CargarDatosTabla();
                                MessageBox.Show("¡Actualizado exitosamente!", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Conexión fallida: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (nombreProducto.Text == "" || precioProducto.Text == "" || stockProducto.Text == "" || cbxMarca.SelectedIndex == -1 || cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el producto " + idProductoSeleccionado + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM Productos WHERE IdProducto = @id";

                            using (SqlCommand updateD = new SqlCommand(deleteData, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", idProductoSeleccionado);
                                updateD.ExecuteNonQuery();
                                LimpiarCampos();
                                CargarDatosTabla();
                                MessageBox.Show("¡Eliminado exitosamente!", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Conexión fallida: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }
    }
}