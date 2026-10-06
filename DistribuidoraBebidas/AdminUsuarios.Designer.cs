namespace DistribuidoraBebidas
{
    partial class AdminUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            estadoUsuario = new ComboBox();
            Estado = new Label();
            btn_limpiar = new Button();
            cargoUsuario = new ComboBox();
            btn_eliminar = new Button();
            label3 = new Label();
            btn_editar = new Button();
            contrasenaUsuario = new TextBox();
            btn_agregar = new Button();
            label2 = new Label();
            nombreUsuario = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            dgvUsuarios = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(estadoUsuario);
            panel1.Controls.Add(Estado);
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(cargoUsuario);
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(contrasenaUsuario);
            panel1.Controls.Add(btn_agregar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nombreUsuario);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 640);
            panel1.TabIndex = 0;
            // 
            // estadoUsuario
            // 
            estadoUsuario.Font = new Font("Segoe UI", 14F);
            estadoUsuario.FormattingEnabled = true;
            estadoUsuario.Items.AddRange(new object[] { "Activo", "Inactivo" });
            estadoUsuario.Location = new Point(24, 366);
            estadoUsuario.Name = "estadoUsuario";
            estadoUsuario.Size = new Size(325, 33);
            estadoUsuario.TabIndex = 22;
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Estado.Location = new Point(24, 333);
            Estado.Name = "Estado";
            Estado.Size = new Size(71, 25);
            Estado.TabIndex = 21;
            Estado.Text = "Estado";
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
            btn_limpiar.Location = new Point(194, 566);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Padding = new Padding(14, 0, 0, 0);
            btn_limpiar.Size = new Size(155, 49);
            btn_limpiar.TabIndex = 20;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btnLimpiar_Click;
            // 
            // cargoUsuario
            // 
            cargoUsuario.Font = new Font("Segoe UI", 14F);
            cargoUsuario.FormattingEnabled = true;
            cargoUsuario.Items.AddRange(new object[] { "Administrador", "Vendedor" });
            cargoUsuario.Location = new Point(24, 262);
            cargoUsuario.Name = "cargoUsuario";
            cargoUsuario.Size = new Size(325, 33);
            cargoUsuario.TabIndex = 17;
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
            btn_eliminar.Location = new Point(24, 566);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Padding = new Padding(14, 0, 0, 0);
            btn_eliminar.Size = new Size(155, 49);
            btn_eliminar.TabIndex = 19;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(24, 229);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 4;
            label3.Text = "Cargo";
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
            btn_editar.Location = new Point(194, 493);
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(14, 0, 0, 0);
            btn_editar.Size = new Size(155, 49);
            btn_editar.TabIndex = 18;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btnEditar_Click;
            // 
            // contrasenaUsuario
            // 
            contrasenaUsuario.Font = new Font("Segoe UI", 14F);
            contrasenaUsuario.Location = new Point(24, 164);
            contrasenaUsuario.Name = "contrasenaUsuario";
            contrasenaUsuario.Size = new Size(325, 32);
            contrasenaUsuario.TabIndex = 3;
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
            btn_agregar.Location = new Point(24, 493);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Padding = new Padding(14, 0, 0, 0);
            btn_agregar.Size = new Size(155, 49);
            btn_agregar.TabIndex = 17;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(24, 131);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // nombreUsuario
            // 
            nombreUsuario.Font = new Font("Segoe UI", 14F);
            nombreUsuario.Location = new Point(24, 63);
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Size = new Size(325, 32);
            nombreUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dgvUsuarios);
            panel2.Location = new Point(401, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 640);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(25, 30);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 18;
            label4.Text = "Datos de los Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 40;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Location = new Point(25, 63);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.White;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.Size = new Size(619, 552);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dataGridViewUsuarios_CellClick;
            // 
            // AdminUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminUsuarios";
            Size = new Size(1085, 665);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private TextBox contrasenaUsuario;
        private Label label2;
        private TextBox nombreUsuario;
        private Label label1;
        private ComboBox cargoUsuario;
        private Label label4;
        private DataGridView dgvUsuarios;
        private Button btn_limpiar;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_agregar;
        private ComboBox estadoUsuario;
        private Label Estado;
    }
}
