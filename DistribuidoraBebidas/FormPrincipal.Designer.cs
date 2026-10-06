namespace DistribuidoraBebidas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_cerrar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnMarcas = new Button();
            btnClientes = new Button();
            btnVentaDetalles = new Button();
            panel4 = new Panel();
            btn_cerrarSesion = new Button();
            btnVentas = new Button();
            btnCategorias = new Button();
            pictureBox1 = new PictureBox();
            btnProductos = new Button();
            btnUsuarios = new Button();
            btnInicio = new Button();
            ventasDetalles1 = new VentasDetalles();
            agregarVenta1 = new AgregarVenta();
            agregarMarcas1 = new AgregarMarcas();
            agregarCategoria1 = new AgregarCategoria();
            agregarProductos1 = new AgregarProductos();
            adminAgregarClientes1 = new AdminAgregarClientes();
            adminUsuarios1 = new AdminUsuarios();
            panelAdmin1 = new PanelAdmin();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 45);
            panel1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.FromArgb(192, 0, 0);
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(168, 0, 0);
            btn_cerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 0, 0);
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.ForeColor = Color.White;
            btn_cerrar.Location = new Point(1249, 9);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(39, 29);
            btn_cerrar.TabIndex = 8;
            btn_cerrar.Text = "X";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 25);
            label1.TabIndex = 7;
            label1.Text = "Bebidas Eli | Distribuidora de Bebidas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 115, 209);
            panel2.Controls.Add(btnMarcas);
            panel2.Controls.Add(btnClientes);
            panel2.Controls.Add(btnVentaDetalles);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btn_cerrarSesion);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnCategorias);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(btnInicio);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 665);
            panel2.TabIndex = 1;
            // 
            // btnMarcas
            // 
            btnMarcas.Cursor = Cursors.Hand;
            btnMarcas.FlatAppearance.BorderSize = 0;
            btnMarcas.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnMarcas.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnMarcas.FlatStyle = FlatStyle.Flat;
            btnMarcas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnMarcas.ForeColor = Color.White;
            btnMarcas.Image = Properties.Resources.etiquetas1;
            btnMarcas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMarcas.Location = new Point(0, 405);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Padding = new Padding(15, 0, 5, 0);
            btnMarcas.Size = new Size(218, 49);
            btnMarcas.TabIndex = 16;
            btnMarcas.Text = "         Marcas";
            btnMarcas.TextAlign = ContentAlignment.MiddleLeft;
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources.icono_clientes;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 240);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(15, 0, 5, 0);
            btnClientes.Size = new Size(218, 49);
            btnClientes.TabIndex = 15;
            btnClientes.Text = "         Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVentaDetalles
            // 
            btnVentaDetalles.Cursor = Cursors.Hand;
            btnVentaDetalles.FlatAppearance.BorderSize = 0;
            btnVentaDetalles.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnVentaDetalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnVentaDetalles.FlatStyle = FlatStyle.Flat;
            btnVentaDetalles.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVentaDetalles.ForeColor = Color.White;
            btnVentaDetalles.Image = Properties.Resources.icono_ventaDetalle1;
            btnVentaDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentaDetalles.Location = new Point(0, 515);
            btnVentaDetalles.Name = "btnVentaDetalles";
            btnVentaDetalles.Padding = new Padding(15, 0, 5, 0);
            btnVentaDetalles.Size = new Size(218, 72);
            btnVentaDetalles.TabIndex = 14;
            btnVentaDetalles.Text = "         Detalles de                 Ventas";
            btnVentaDetalles.TextAlign = ContentAlignment.MiddleLeft;
            btnVentaDetalles.UseVisualStyleBackColor = true;
            btnVentaDetalles.Click += btnVentaDetalles_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(172, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(0, 0);
            panel4.TabIndex = 9;
            // 
            // btn_cerrarSesion
            // 
            btn_cerrarSesion.BackColor = Color.FromArgb(0, 115, 209);
            btn_cerrarSesion.Cursor = Cursors.Hand;
            btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            btn_cerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_cerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_cerrarSesion.FlatStyle = FlatStyle.Flat;
            btn_cerrarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_cerrarSesion.ForeColor = Color.White;
            btn_cerrarSesion.Image = Properties.Resources.cierre_de_sesion_de_usuario;
            btn_cerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrarSesion.Location = new Point(14, 604);
            btn_cerrarSesion.Name = "btn_cerrarSesion";
            btn_cerrarSesion.Padding = new Padding(5, 0, 0, 0);
            btn_cerrarSesion.Size = new Size(188, 49);
            btn_cerrarSesion.TabIndex = 13;
            btn_cerrarSesion.Text = "      Cerrar Sesión";
            btn_cerrarSesion.UseVisualStyleBackColor = false;
            btn_cerrarSesion.Click += btn_cerrarSesion_Click;
            // 
            // btnVentas
            // 
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = Properties.Resources.factura_punto_de_venta1;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(3, 460);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(15, 0, 5, 0);
            btnVentas.Size = new Size(215, 49);
            btnVentas.TabIndex = 12;
            btnVentas.Text = "         Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Image = Properties.Resources.etiquetas1;
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(0, 350);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Padding = new Padding(15, 0, 5, 0);
            btnCategorias.Size = new Size(218, 49);
            btnCategorias.TabIndex = 11;
            btnCategorias.Text = "         Categorías";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_bebidas_eli_vf;
            pictureBox1.Location = new Point(13, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.cajas;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 295);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(15, 0, 5, 0);
            btnProductos.Size = new Size(218, 49);
            btnProductos.TabIndex = 4;
            btnProductos.Text = "         Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = Properties.Resources.usuarios;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 189);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(15, 0, 5, 0);
            btnUsuarios.Size = new Size(218, 49);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "         Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = Properties.Resources.icono_inicio;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 134);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(15, 0, 5, 0);
            btnInicio.Size = new Size(218, 49);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "         Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // ventasDetalles1
            // 
            ventasDetalles1.Location = new Point(215, 45);
            ventasDetalles1.Name = "ventasDetalles1";
            ventasDetalles1.Size = new Size(1085, 665);
            ventasDetalles1.TabIndex = 2;
            // 
            // agregarVenta1
            // 
            agregarVenta1.Location = new Point(215, 45);
            agregarVenta1.Name = "agregarVenta1";
            agregarVenta1.Size = new Size(1085, 665);
            agregarVenta1.TabIndex = 9;
            // 
            // agregarMarcas1
            // 
            agregarMarcas1.BackColor = Color.Teal;
            agregarMarcas1.Location = new Point(215, 45);
            agregarMarcas1.Name = "agregarMarcas1";
            agregarMarcas1.Size = new Size(1085, 665);
            agregarMarcas1.TabIndex = 9;
            // 
            // agregarCategoria1
            // 
            agregarCategoria1.BackColor = Color.Teal;
            agregarCategoria1.Location = new Point(212, 44);
            agregarCategoria1.Name = "agregarCategoria1";
            agregarCategoria1.Size = new Size(1085, 665);
            agregarCategoria1.TabIndex = 9;
            // 
            // agregarProductos1
            // 
            agregarProductos1.Location = new Point(215, 44);
            agregarProductos1.Name = "agregarProductos1";
            agregarProductos1.Size = new Size(1085, 665);
            agregarProductos1.TabIndex = 9;
            // 
            // adminAgregarClientes1
            // 
            adminAgregarClientes1.BackColor = Color.Teal;
            adminAgregarClientes1.Location = new Point(215, 44);
            adminAgregarClientes1.Margin = new Padding(2);
            adminAgregarClientes1.Name = "adminAgregarClientes1";
            adminAgregarClientes1.Size = new Size(1085, 665);
            adminAgregarClientes1.TabIndex = 9;
            // 
            // adminUsuarios1
            // 
            adminUsuarios1.BackColor = Color.Teal;
            adminUsuarios1.Location = new Point(215, 45);
            adminUsuarios1.Name = "adminUsuarios1";
            adminUsuarios1.Size = new Size(1085, 665);
            adminUsuarios1.TabIndex = 9;
            // 
            // panelAdmin1
            // 
            panelAdmin1.Location = new Point(214, 44);
            panelAdmin1.Name = "panelAdmin1";
            panelAdmin1.Size = new Size(1085, 665);
            panelAdmin1.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 710);
            Controls.Add(panelAdmin1);
            Controls.Add(adminUsuarios1);
            Controls.Add(adminAgregarClientes1);
            Controls.Add(agregarProductos1);
            Controls.Add(agregarCategoria1);
            Controls.Add(agregarMarcas1);
            Controls.Add(agregarVenta1);
            Controls.Add(ventasDetalles1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btn_cerrar;
        private Button btnInicio;
        private Button btnProductos;
        private Button btnUsuarios;
        private Button btn_cerrarSesion;
        private Button btnVentas;
        private Button btnCategorias;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button btnVentaDetalles;
        private Button btnClientes;
        private AgregarCategoria agregarCategoria1;
        private Button btnMarcas;
        private AgregarMarcas agregarMarcas1;
        private AgregarProductos agregarProductos1;
        private VentasDetalles ventasDetalles1;
        private AgregarVenta agregarVenta1;
        private AdminAgregarClientes adminAgregarClientes1;
        private AdminUsuarios adminUsuarios1;
        private PanelAdmin panelAdmin1;
    }
}