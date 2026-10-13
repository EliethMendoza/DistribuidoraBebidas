using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DistribuidoraBebidas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar sesion?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro que quieres salir?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormInicio formularioInicio = new FormInicio();
                formularioInicio.Show();
                this.Hide();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = true;
            panelAdmin1.CargarDatosDashboard();
            adminUsuarios1.Visible = false;
            adminAgregarClientes1.Visible = false;
            agregarCategoria1.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = false;
            adminUsuarios1.Visible = true;
            adminAgregarClientes1.Visible = false;
            agregarProductos1.Visible = false;
            agregarCategoria1.Visible = false;
            AdminUsuarios form = adminUsuarios1 as AdminUsuarios;
            if (form != null) { form.CargarDatosTabla(); }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = false;
            adminUsuarios1.Visible = false;
            adminAgregarClientes1.Visible = true;
            agregarProductos1.Visible = false;
            agregarCategoria1.Visible = false;
            AdminAgregarClientes form = adminAgregarClientes1 as AdminAgregarClientes;
            if (form != null) { form.CargarDatosTabla(); }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = false;
            adminUsuarios1.Visible = false;
            adminAgregarClientes1.Visible = false;
            agregarProductos1.Visible = true;
            agregarCategoria1.Visible = false;
            agregarMarcas1.Visible = false;

            AgregarProductos form = agregarProductos1 as AgregarProductos;
            if (form != null)
            {
                form.RecargarCombos();
                form.CargarDatosTabla();
            }
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = false;
            adminUsuarios1.Visible = false;
            adminAgregarClientes1.Visible = false;
            agregarProductos1.Visible = false;
            agregarCategoria1.Visible = true;
            agregarMarcas1.Visible = false;
            AgregarCategoria form = agregarCategoria1 as AgregarCategoria;
            if (form != null) { form.CargarDatosTabla(); }
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = false;
            adminUsuarios1.Visible = false;
            adminAgregarClientes1.Visible = false;
            agregarProductos1.Visible = false;
            agregarCategoria1.Visible = false;
            agregarMarcas1.Visible = true;
            AgregarMarcas form = agregarMarcas1 as AgregarMarcas;
            if (form != null) { form.CargarDatosTabla(); }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = false;
            adminUsuarios1.Visible = false;
            adminAgregarClientes1.Visible = false;
            agregarProductos1.Visible = false;
            agregarCategoria1.Visible = false;
            agregarMarcas1.Visible = false;
            agregarVenta1.Visible = true;
        }

        private void btnVentaDetalles_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = false;
            adminUsuarios1.Visible = false;
            adminAgregarClientes1.Visible = false;
            agregarProductos1.Visible = false;
            agregarCategoria1.Visible = false;
            agregarMarcas1.Visible = false;
            agregarVenta1.Visible = false;
            ventasDetalles1.Visible = true;

            VentasDetalles form = ventasDetalles1 as VentasDetalles;
            if (form != null)
            {
                form.CargarTablaVentas();
            }
        }
    }

}