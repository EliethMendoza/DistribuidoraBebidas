using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DistribuidoraBebidas
{
    public partial class FormRegistro : Form
    {
        private ConexionBD bd = new ConexionBD();

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicio_label_Click(object sender, EventArgs e)
        {
            FormInicio formularioInicio = new FormInicio();
            formularioInicio.Show();
            this.Hide();
        }

        private string GenerarIdAleatorio()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return "U" + numero;
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (registro_nombreUsuario.Text == "" || registro_contrasena.Text == "" || registro_cContrasena.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = bd.ObtenerConexion())
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM Usuarios WHERE NombreUsuario = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", registro_nombreUsuario.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("El usuario '" + registro_nombreUsuario.Text.Trim() + "' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (registro_contrasena.Text.Length < 8)
                            {
                                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (registro_contrasena.Text.Trim() != registro_cContrasena.Text.Trim())
                            {
                                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string inserData = "INSERT INTO Usuarios (IdUsuario, NombreUsuario, Contraseña, Cargo) " +
                                                   "VALUES (@id, @usern, @pass, @cargo)";

                                using (SqlCommand inserD = new SqlCommand(inserData, connect))
                                {
                                    inserD.Parameters.AddWithValue("@id", GenerarIdAleatorio());
                                    inserD.Parameters.AddWithValue("@usern", registro_nombreUsuario.Text.Trim());
                                    inserD.Parameters.AddWithValue("@pass", registro_contrasena.Text.Trim());
                                    inserD.Parameters.AddWithValue("@cargo", "Cajero");

                                    inserD.ExecuteNonQuery();

                                    MessageBox.Show("Usuario registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    FormInicio formularioInicio = new FormInicio();
                                    formularioInicio.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registro_mostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            registro_contrasena.PasswordChar = registro_mostrarContrasena.Checked ? '\0' : '*';
            registro_cContrasena.PasswordChar = registro_mostrarContrasena.Checked ? '\0' : '*';
        }
    }
}