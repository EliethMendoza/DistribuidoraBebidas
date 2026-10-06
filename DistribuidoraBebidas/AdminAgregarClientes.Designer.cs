namespace DistribuidoraBebidas
{
    partial class AdminAgregarClientes
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dgvClientes = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            btn_limpiar = new Button();
            direccionCliente = new TextBox();
            btn_eliminar = new Button();
            label5 = new Label();
            btn_editar = new Button();
            telefonoCliente = new TextBox();
            btn_agregar = new Button();
            label3 = new Label();
            cedulaCliente = new TextBox();
            label2 = new Label();
            nombreCliente = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvClientes);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(372, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 638);
            panel2.TabIndex = 3;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.ColumnHeadersHeight = 40;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(18, 51);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = Color.White;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.Size = new Size(660, 573);
            dgvClientes.TabIndex = 19;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(18, 17);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 18;
            label4.Text = "Datos de los Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(direccionCliente);
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(telefonoCliente);
            panel1.Controls.Add(btn_agregar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cedulaCliente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nombreCliente);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 638);
            panel1.TabIndex = 2;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.FromArgb(0, 115, 209);
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.FlatAppearance.BorderSize = 0;
            btn_limpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_limpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Image = Properties.Resources.icono_limpiar;
            btn_limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpiar.Location = new Point(184, 575);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Padding = new Padding(14, 0, 0, 0);
            btn_limpiar.Size = new Size(155, 49);
            btn_limpiar.TabIndex = 20;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btnLimpiar_Click;
            // 
            // direccionCliente
            // 
            direccionCliente.Font = new Font("Segoe UI", 14F);
            direccionCliente.Location = new Point(14, 353);
            direccionCliente.Name = "direccionCliente";
            direccionCliente.Size = new Size(325, 32);
            direccionCliente.TabIndex = 19;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(0, 115, 209);
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Image = Properties.Resources.icono_borrar;
            btn_eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eliminar.Location = new Point(14, 575);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Padding = new Padding(14, 0, 0, 0);
            btn_eliminar.Size = new Size(155, 49);
            btn_eliminar.TabIndex = 19;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(14, 320);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 18;
            label5.Text = "Dirección";
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(0, 115, 209);
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.BorderSize = 0;
            btn_editar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_editar.ForeColor = Color.White;
            btn_editar.Image = Properties.Resources.icono_editar3;
            btn_editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editar.Location = new Point(184, 502);
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(14, 0, 0, 0);
            btn_editar.Size = new Size(155, 49);
            btn_editar.TabIndex = 18;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btnEditar_Click;
            // 
            // telefonoCliente
            // 
            telefonoCliente.Font = new Font("Segoe UI", 14F);
            telefonoCliente.Location = new Point(14, 246);
            telefonoCliente.Name = "telefonoCliente";
            telefonoCliente.Size = new Size(325, 32);
            telefonoCliente.TabIndex = 17;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(0, 115, 209);
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_agregar.ForeColor = Color.White;
            btn_agregar.Image = Properties.Resources.icono_agregar;
            btn_agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar.Location = new Point(14, 502);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Padding = new Padding(14, 0, 0, 0);
            btn_agregar.Size = new Size(155, 49);
            btn_agregar.TabIndex = 17;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(14, 213);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 4;
            label3.Text = "Teléfono";
            // 
            // cedulaCliente
            // 
            cedulaCliente.Font = new Font("Segoe UI", 14F);
            cedulaCliente.Location = new Point(14, 148);
            cedulaCliente.Name = "cedulaCliente";
            cedulaCliente.Size = new Size(325, 32);
            cedulaCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(14, 115);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 2;
            label2.Text = "Cédula";
            // 
            // nombreCliente
            // 
            nombreCliente.Font = new Font("Segoe UI", 14F);
            nombreCliente.Location = new Point(14, 51);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(325, 32);
            nombreCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Cliente";
            // 
            // AdminAgregarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "AdminAgregarClientes";
            Size = new Size(1085, 665);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private TextBox cedulaCliente;
        private Label label2;
        private TextBox nombreCliente;
        private Label label1;
        private TextBox direccionCliente;
        private Label label5;
        private TextBox telefonoCliente;
        private Button btn_limpiar;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_agregar;
        private DataGridView dgvClientes;
    }
}
