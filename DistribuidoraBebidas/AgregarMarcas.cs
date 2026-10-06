using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DistribuidoraBebidas
{
    public partial class AgregarMarcas : UserControl
    {
        SqlConnection connect;
        private ConexionBD bd = new ConexionBD();
        private string idMarcaSeleccionada = "";

        public AgregarMarcas()
        {
            InitializeComponent();
            connect = bd.ObtenerConexion();
            CargarDatosTabla();
        }

        public void CargarDatosTabla()
        {
            DatosMarcas mData = new DatosMarcas();
            List<DatosMarcas> listaDatos = mData.TodasLasMarcas();
            dgvMarcas.DataSource = listaDatos;
        }

        private string GenerarIdAleatorio()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return "M" + numero;
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
            nombreMarca.Clear();
            idMarcaSeleccionada = "";

            if (dgvMarcas.SelectedRows.Count > 0)
            {
                dgvMarcas.ClearSelection();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvMarcas.Rows[e.RowIndex];

                idMarcaSeleccionada = row.Cells[0].Value.ToString();
                nombreMarca.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreMarca.Text == "")
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

                        string checkMarca = "SELECT * FROM Marcas WHERE NombreMarca = @nom";

                        using (SqlCommand cmd = new SqlCommand(checkMarca, connect))
                        {
                            cmd.Parameters.AddWithValue("@nom", nombreMarca.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("La marca '" + nombreMarca.Text.Trim() + "' ya existe.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime hoy = DateTime.Today;

                                string insertData = "INSERT INTO Marcas (IdMarca, NombreMarca) VALUES (@id, @nom)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@id", GenerarIdAleatorio());
                                    insertD.Parameters.AddWithValue("@nom", nombreMarca.Text.Trim());

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
            if (nombreMarca.Text == "" || idMarcaSeleccionada == "")
            {
                MessageBox.Show("Por favor, seleccione una marca de la lista.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea actualizar la marca " + idMarcaSeleccionada + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            DateTime hoy = DateTime.Today;

                            string updateData = "UPDATE Marcas SET NombreMarca = @nom WHERE IdMarca = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@nom", nombreMarca.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", idMarcaSeleccionada);

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
            if (nombreMarca.Text == "" || idMarcaSeleccionada == "")
            {
                MessageBox.Show("Por favor, seleccione una marca de la lista.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar la marca " + idMarcaSeleccionada + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM Marcas WHERE IdMarca = @id";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@id", idMarcaSeleccionada);
                                deleteD.ExecuteNonQuery();
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