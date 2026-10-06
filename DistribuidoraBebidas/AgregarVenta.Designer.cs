namespace DistribuidoraBebidas
{
    partial class AgregarVenta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dgvProductos = new DataGridView();
            panel2 = new Panel();
            btnLimpiar = new Button();
            total = new Label();
            impuestos = new Label();
            subtotal = new Label();
            totalArticulos = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnPagar = new Button();
            dgvCarrito = new DataGridView();
            label1 = new Label();
            txtBuscarProducto = new TextBox();
            btnBuscar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProductos);
            panel1.Location = new Point(14, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 567);
            panel1.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvProductos.ColumnHeadersHeight = 40;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.Size = new Size(578, 567);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(total);
            panel2.Controls.Add(impuestos);
            panel2.Controls.Add(subtotal);
            panel2.Controls.Add(totalArticulos);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnPagar);
            panel2.Controls.Add(dgvCarrito);
            panel2.Location = new Point(622, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 631);
            panel2.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Control;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(0, 115, 209);
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(0, 115, 209);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(15, 565);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(414, 49);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 14F);
            total.Location = new Point(321, 432);
            total.Name = "total";
            total.Size = new Size(22, 25);
            total.TabIndex = 21;
            total.Text = "0";
            // 
            // impuestos
            // 
            impuestos.AutoSize = true;
            impuestos.Font = new Font("Segoe UI", 14F);
            impuestos.Location = new Point(321, 381);
            impuestos.Name = "impuestos";
            impuestos.Size = new Size(22, 25);
            impuestos.TabIndex = 20;
            impuestos.Text = "0";
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Font = new Font("Segoe UI", 14F);
            subtotal.Location = new Point(321, 327);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(22, 25);
            subtotal.TabIndex = 19;
            subtotal.Text = "0";
            // 
            // totalArticulos
            // 
            totalArticulos.AutoSize = true;
            totalArticulos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalArticulos.Location = new Point(321, 274);
            totalArticulos.Name = "totalArticulos";
            totalArticulos.Size = new Size(23, 25);
            totalArticulos.TabIndex = 18;
            totalArticulos.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(15, 432);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 17;
            label5.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(15, 381);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 16;
            label4.Text = "Impuestos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(15, 327);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 15;
            label3.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 274);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 5;
            label2.Text = "Todos los productos:";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(0, 115, 209);
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnPagar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPagar.ForeColor = Color.White;
            btnPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagar.Location = new Point(15, 493);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(414, 49);
            btnPagar.TabIndex = 14;
            btnPagar.Text = "Calcular";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvCarrito.ColumnHeadersHeight = 40;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCarrito.Location = new Point(0, 0);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.Size = new Size(448, 238);
            dgvCarrito.TabIndex = 1;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            dgvCarrito.KeyDown += dgvCarrito_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 2;
            label1.Text = "Buscar Productos:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Font = new Font("Segoe UI", 16F);
            txtBuscarProducto.Location = new Point(190, 28);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(358, 36);
            txtBuscarProducto.TabIndex = 3;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 115, 209);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = Properties.Resources.lupa;
            btnBuscar.Location = new Point(547, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(45, 36);
            btnBuscar.TabIndex = 4;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // AgregarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarProducto);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarVenta";
            Size = new Size(1085, 665);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtBuscarProducto;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private DataGridView dgvCarrito;
        private Button btnPagar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label totalArticulos;
        private Label total;
        private Label impuestos;
        private Label subtotal;
        private Button btnLimpiar;
    }
}
