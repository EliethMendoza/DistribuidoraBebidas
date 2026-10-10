using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DistribuidoraBebidas
{
    public partial class VentasDetalles : UserControl
    {
        private DatosVentaDetalle vData = new DatosVentaDetalle();
        public string idVentaSeleccionada = "";

        public VentasDetalles()
        {
            InitializeComponent();
            this.Enter += new EventHandler(VentasDetalles_Enter);
        }
        private void VentasDetalles_Enter(object sender, EventArgs e)
        {
            CargarTablaVentas();
        }

        public void CargarTablaVentas(string filtro = "")
        {
            List<VentaEncabezado> lista = vData.ObtenerVentas(filtro);
            dgvVentas.DataSource = lista;

            if (dgvVentas.Rows.Count > 0)
            {
                dgvVentas.Rows[0].Selected = true;
                CargarDetallesDeFilaSeleccionada(0);
            }
            else
            {
                idVentaSeleccionada = "";
                dgvVentaDetalles.DataSource = null;
            }
        }

        public void BuscarVenta()
        {
            CargarTablaVentas(txtBuscarVenta.Text.Trim());
        }

        public void CargarTablaDetalles(string filtro = "")
        {
            if (!string.IsNullOrEmpty(idVentaSeleccionada))
            {
                List<VentaDetalleItem> lista = vData.ObtenerDetallesPorVenta(idVentaSeleccionada, filtro);
                dgvVentaDetalles.DataSource = lista;
            }
            else
            {
                dgvVentaDetalles.DataSource = null;
            }
        }

        public void BuscarDetalles()
        {
            CargarTablaDetalles(txtBuscarVentaDetalles.Text.Trim());
        }

        public void CargarDetallesDeFilaSeleccionada(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dgvVentas.Rows.Count)
            {
                DataGridViewRow fila = dgvVentas.Rows[rowIndex];

                if (fila.Cells["IdVenta"].Value != null)
                {
                    idVentaSeleccionada = fila.Cells["IdVenta"].Value.ToString();
                    txtBuscarVentaDetalles.Clear();
                    CargarTablaDetalles();
                }
            }
        }


        private void txtBuscarVenta_TextChanged(object sender, EventArgs e) => BuscarVenta();
        private void btnBuscarVenta_Click(object sender, EventArgs e) => BuscarVenta();

        private void txtBuscarVentaDetalles_TextChanged(object sender, EventArgs e) => BuscarDetalles();
        private void btnBuscarVentaDetalles_Click(object sender, EventArgs e) => BuscarDetalles();

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CargarDetallesDeFilaSeleccionada(e.RowIndex);
            }
        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null && dgvVentas.CurrentRow.Index >= 0)
            {
                CargarDetallesDeFilaSeleccionada(dgvVentas.CurrentRow.Index);
            }
        }

        private void VentasDetalles_Load(object sender, EventArgs e)
        {
            CargarTablaVentas();
        }
    }
}