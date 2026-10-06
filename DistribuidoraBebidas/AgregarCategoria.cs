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
    public partial class AgregarCategoria : UserControl
    {
        SqlConnection connect;
        private ConexionBD bd = new ConexionBD();
        private string idCategoriaSeleccionada = "";

        public AgregarCategoria()
        {
            InitializeComponent();
            connect = bd.ObtenerConexion();
            CargarDatosTabla();
        }

        public void CargarDatosTabla()
        {
            DatosCategorias catData = new DatosCategorias();
            List<DatosCategorias> listaDatos = catData.TodasLasCategorias();
            dgvCategorias.DataSource = listaDatos;
        }

        private string GenerarIdAleatorio()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return "CAT" + numero;
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
            nombreCategoria.Clear();
            idCategoriaSeleccionada = "";

            if (dgvCategorias.SelectedRows.Count > 0)
            {
                dgvCategorias.ClearSelection();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                string nombre = row.Cells[1].Value.ToString();

                idCategoriaSeleccionada = id;
                nombreCategoria.Text = nombre;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreCategoria.Text == "")
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

                        string checkCat = "SELECT * FROM Categorias WHERE NombreCategoria = @nom";

                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@nom", nombreCategoria.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("La categoría '" + nombreCategoria.Text.Trim() + "' ya existe.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Categorias (IdCategoria, NombreCategoria, Fecha) VALUES (@id, @nom, @fecha)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@id", GenerarIdAleatorio());
                                    insertD.Parameters.AddWithValue("@nom", nombreCategoria.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@fecha", today);

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
            if (nombreCategoria.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea actualizar la categoría " + idCategoriaSeleccionada + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE Categorias SET NombreCategoria = @nom WHERE IdCategoria = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@nom", nombreCategoria.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", idCategoriaSeleccionada);

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
            if (nombreCategoria.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar la categoría " + idCategoriaSeleccionada + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM Categorias WHERE IdCategoria = @id";

                            using (SqlCommand updateD = new SqlCommand(deleteData, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", idCategoriaSeleccionada);
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