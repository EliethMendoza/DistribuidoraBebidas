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
    public partial class AdminAgregarClientes : UserControl
    {
        SqlConnection connect;
        private ConexionBD bd = new ConexionBD();
        private string idClienteSeleccionado = "";

        public AdminAgregarClientes()
        {
            InitializeComponent();
            connect = bd.ObtenerConexion();
            CargarDatosTabla();
        }

        public void CargarDatosTabla()
        {
            DatosClientes cData = new DatosClientes();
            List<DatosClientes> listaDatos = cData.TodosLosClientes();
            dgvClientes.DataSource = listaDatos;
        }

        private string GenerarIdAleatorio()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return "C" + numero;
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
            nombreCliente.Clear();
            cedulaCliente.Clear();
            direccionCliente.Clear();
            telefonoCliente.Clear();
            idClienteSeleccionado = "";

            if (dgvClientes.SelectedRows.Count > 0)
            {
                dgvClientes.ClearSelection();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                string nombre = row.Cells[1].Value.ToString();
                string cedula = row.Cells[2].Value.ToString();
                string telefono = row.Cells[3].Value.ToString();
                string direccion = row.Cells[4].Value.ToString();

                idClienteSeleccionado = id;
                nombreCliente.Text = nombre;
                cedulaCliente.Text = cedula;
                telefonoCliente.Text = telefono;
                direccionCliente.Text = direccion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreCliente.Text == "" || telefonoCliente.Text == "" || direccionCliente.Text == "" || cedulaCliente.Text == "")
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

                        string checkCliente = "SELECT * FROM Clientes WHERE NombreCliente = @nom";

                        using (SqlCommand cmd = new SqlCommand(checkCliente, connect))
                        {
                            cmd.Parameters.AddWithValue("@nom", nombreCliente.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("El cliente '" + nombreCliente.Text.Trim() + "' ya existe.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Clientes (IdCliente, NombreCliente, IdCedula, Telefono, Direccion, Fecha) VALUES (@id, @nom, @ced, @tel, @dir, @fecha)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@id", GenerarIdAleatorio());
                                    insertD.Parameters.AddWithValue("@nom", nombreCliente.Text.Trim());
                                    insertD.Parameters.AddWithValue("@ced", cedulaCliente.Text.Trim());
                                    insertD.Parameters.AddWithValue("@tel", telefonoCliente.Text.Trim());
                                    insertD.Parameters.AddWithValue("@dir", direccionCliente.Text.Trim());

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
            if (nombreCliente.Text == "" || telefonoCliente.Text == "" || direccionCliente.Text == "" || cedulaCliente.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea actualizar el cliente " + idClienteSeleccionado + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE Clientes SET NombreCliente = @nom, IdCedula = @ced, Telefono = @tel, Direccion = @dir WHERE IdCliente = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@nom", nombreCliente.Text.Trim());
                                updateD.Parameters.AddWithValue("@ced", cedulaCliente.Text.Trim());
                                updateD.Parameters.AddWithValue("@tel", telefonoCliente.Text.Trim());
                                updateD.Parameters.AddWithValue("@dir", direccionCliente.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", idClienteSeleccionado);

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
            if (nombreCliente.Text == "" || telefonoCliente.Text == "" || direccionCliente.Text == "" || cedulaCliente.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el cliente " + idClienteSeleccionado + "?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ComprobarConexion())
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM Clientes WHERE IdCliente = @id";

                            using (SqlCommand updateD = new SqlCommand(deleteData, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", idClienteSeleccionado);
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