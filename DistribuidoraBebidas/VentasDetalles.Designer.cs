namespace DistribuidoraBebidas
{
    partial class VentasDetalles
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
            dgvVentas = new DataGridView();
            btnBuscarVenta = new Button();
            txtBuscarVenta = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnBuscarVentaDetalles = new Button();
            txtBuscarVentaDetalles = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dgvVentaDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentaDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvVentas.ColumnHeadersHeight = 40;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.Location = new Point(3, 3);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(1004, 225);
            dgvVentas.TabIndex = 1;
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.BackColor = Color.FromArgb(0, 115, 209);
            btnBuscarVenta.Cursor = Cursors.Hand;
            btnBuscarVenta.FlatAppearance.BorderSize = 0;
            btnBuscarVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnBuscarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnBuscarVenta.FlatStyle = FlatStyle.Flat;
            btnBuscarVenta.Image = Properties.Resources.lupa;
            btnBuscarVenta.Location = new Point(556, 35);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(45, 36);
            btnBuscarVenta.TabIndex = 7;
            btnBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // txtBuscarVenta
            // 
            txtBuscarVenta.Font = new Font("Segoe UI", 16F);
            txtBuscarVenta.Location = new Point(199, 35);
            txtBuscarVenta.Name = "txtBuscarVenta";
            txtBuscarVenta.Size = new Size(358, 36);
            txtBuscarVenta.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(39, 42);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 5;
            label1.Text = "Buscar Ventas:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvVentas);
            panel1.Location = new Point(36, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 231);
            panel1.TabIndex = 8;
            // 
            // btnBuscarVentaDetalles
            // 
            btnBuscarVentaDetalles.BackColor = Color.FromArgb(0, 115, 209);
            btnBuscarVentaDetalles.Cursor = Cursors.Hand;
            btnBuscarVentaDetalles.FlatAppearance.BorderSize = 0;
            btnBuscarVentaDetalles.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnBuscarVentaDetalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnBuscarVentaDetalles.FlatStyle = FlatStyle.Flat;
            btnBuscarVentaDetalles.Image = Properties.Resources.lupa;
            btnBuscarVentaDetalles.Location = new Point(647, 363);
            btnBuscarVentaDetalles.Name = "btnBuscarVentaDetalles";
            btnBuscarVentaDetalles.Size = new Size(45, 36);
            btnBuscarVentaDetalles.TabIndex = 11;
            btnBuscarVentaDetalles.UseVisualStyleBackColor = false;
            // 
            // txtBuscarVentaDetalles
            // 
            txtBuscarVentaDetalles.Font = new Font("Segoe UI", 16F);
            txtBuscarVentaDetalles.Location = new Point(290, 363);
            txtBuscarVentaDetalles.Name = "txtBuscarVentaDetalles";
            txtBuscarVentaDetalles.Size = new Size(358, 36);
            txtBuscarVentaDetalles.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(39, 370);
            label2.Name = "label2";
            label2.Size = new Size(227, 25);
            label2.TabIndex = 9;
            label2.Text = "Buscar detalles de ventas:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvVentaDetalles);
            panel2.Location = new Point(39, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 227);
            panel2.TabIndex = 9;
            // 
            // dgvVentaDetalles
            // 
            dgvVentaDetalles.AllowUserToDeleteRows = false;
            dgvVentaDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentaDetalles.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvVentaDetalles.ColumnHeadersHeight = 40;
            dgvVentaDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentaDetalles.Location = new Point(0, 3);
            dgvVentaDetalles.Name = "dgvVentaDetalles";
            dgvVentaDetalles.ReadOnly = true;
            dgvVentaDetalles.RowHeadersVisible = false;
            dgvVentaDetalles.Size = new Size(1007, 224);
            dgvVentaDetalles.TabIndex = 2;
            // 
            // VentasDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(btnBuscarVentaDetalles);
            Controls.Add(txtBuscarVentaDetalles);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnBuscarVenta);
            Controls.Add(txtBuscarVenta);
            Controls.Add(label1);
            Name = "VentasDetalles";
            Size = new Size(1085, 665);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentaDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnBuscarVenta;
        private TextBox txtBuscarVenta;
        private Label label1;
        private Panel panel1;
        private Button btnBuscarVentaDetalles;
        private TextBox txtBuscarVentaDetalles;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvVentaDetalles;
    }
}
