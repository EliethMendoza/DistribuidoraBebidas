using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DistribuidoraBebidas
{
    public partial class FormInicio : Form
    {
        private ConexionBD bd = new ConexionBD();

        public FormInicio()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registro_label_Click(object sender, EventArgs e)
        {
            FormRegistro formularioRegistro = new FormRegistro();
            formularioRegistro.Show();
            this.Hide();
        }

        private void inicio_mostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            inicio_contrasena.PasswordChar = inicio_mostrarContrasena.Checked ? '\0' : '*';
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inicio_nombreUsuario.Text) || string.IsNullOrWhiteSpace(inicio_contrasena.Text))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connect = bd.ObtenerConexion())
                {
                    // Consulta adaptada a las columnas de la tabla Usuarios
                    string selectData = "SELECT * FROM Usuarios WHERE NombreUsuario = @usern AND Contraseña = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", inicio_nombreUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", inicio_contrasena.Text.Trim());

                        connect.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FormPrincipal formP = new FormPrincipal();
                                formP.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión con la base de datos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}