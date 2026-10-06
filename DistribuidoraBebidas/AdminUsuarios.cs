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
    public partial class AdminUsuarios : UserControl
    {
        SqlConnection connect;
        private ConexionBD bd = new ConexionBD();

        public void CargarDatosTabla()
        {
            try
            {
                using (SqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();
                    string query = "SELECT IdUsuario, NombreUsuario, Contraseña, Cargo, Estado, Fecha FROM Usuarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvUsuarios.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public AdminUsuarios()
        {
            InitializeComponent();
            connect = bd.ObtenerConexion();
            CargarDatosTabla();
        }

        private string GenerarIdAleatorio()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return "U" + numero;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreUsuario.Text == "" || contrasenaUsuario.Text == "" || cargoUsuario.SelectedIndex == -1 || estadoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (ComprobarConexion())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM Usuarios WHERE NombreUsuario = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", nombreUsuario.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(nombreUsuario.Text.Trim() + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Usuarios (IdUsuario, NombreUsuario, Contraseña, Cargo, Estado, Fecha) VALUES (@id, @usern, @pass, @cargo, @estado, @fecha)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@id", GenerarIdAleatorio());
                                    insertD.Parameters.AddWithValue("@usern", nombreUsuario.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", contrasenaUsuario.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cargo", cargoUsuario.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@estado", estadoUsuario.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@fecha", today);

                                    insertD.ExecuteNonQuery();
                                    LimpiarCampos();
                                    CargarDatosTabla();

                                    MessageBox.Show("Added Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
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
            nombreUsuario.Clear();
            contrasenaUsuario.Clear();
            cargoUsuario.SelectedIndex = -1;
            estadoUsuario.SelectedIndex = -1;
            idUsuarioSeleccionado = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (nombreUsuario.Text == "" || contrasenaUsuario.Text == "" || cargoUsuario.SelectedIndex == -1 || estadoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update user " + idUsuarioSeleccionado + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE Usuarios SET NombreUsuario = @usern, Contraseña = @pass, Cargo = @cargo, Estado = @estado WHERE IdUsuario = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@usern", nombreUsuario.Text.Trim());
                                updateD.Parameters.AddWithValue("@pass", contrasenaUsuario.Text.Trim());
                                updateD.Parameters.AddWithValue("@cargo", cargoUsuario.SelectedItem);
                                updateD.Parameters.AddWithValue("@estado", estadoUsuario.SelectedItem);
                                updateD.Parameters.AddWithValue("@id", idUsuarioSeleccionado);
                                updateD.ExecuteNonQuery();
                                LimpiarCampos();
                                CargarDatosTabla();
                                MessageBox.Show("Updated Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private string idUsuarioSeleccionado = "";
        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                string username = row.Cells[1].Value.ToString();
                string password = row.Cells[2].Value.ToString();
                string cargo = row.Cells[3].Value.ToString();
                string estado = row.Cells[4].Value.ToString();

                idUsuarioSeleccionado = row.Cells[0].Value.ToString();
                nombreUsuario.Text = username;
                contrasenaUsuario.Text = password;
                cargoUsuario.Text = cargo;
                estadoUsuario.Text = estado;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (nombreUsuario.Text == "" || contrasenaUsuario.Text == "" || cargoUsuario.SelectedIndex == -1 || estadoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove user " + idUsuarioSeleccionado + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "DELETE FROM Usuarios WHERE IdUsuario = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", idUsuarioSeleccionado);
                                updateD.ExecuteNonQuery();
                                LimpiarCampos();
                                CargarDatosTabla();
                                MessageBox.Show("Removed Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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