namespace DistribuidoraBebidas
{
    partial class AgregarCategoria
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
            panel2 = new Panel();
            label4 = new Label();
            dgvCategorias = new DataGridView();
            panel1 = new Panel();
            nombreCategoria = new TextBox();
            btn_limpiar = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            btn_agregar = new Button();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dgvCategorias);
            panel2.Location = new Point(373, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 638);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(18, 41);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 18;
            label4.Text = "Categorías";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(18, 91);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 62;
            dgvCategorias.Size = new Size(656, 533);
            dgvCategorias.TabIndex = 0;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nombreCategoria);
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(btn_agregar);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 638);
            panel1.TabIndex = 4;
            // 
            // nombreCategoria
            // 
            nombreCategoria.Font = new Font("Segoe UI", 14F);
            nombreCategoria.Location = new Point(14, 91);
            nombreCategoria.Name = "nombreCategoria";
            nombreCategoria.Size = new Size(325, 32);
            nombreCategoria.TabIndex = 17;
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
            btn_limpiar.TabIndex = 16;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btnLimpiar_Click;
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
            btn_eliminar.TabIndex = 15;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btnEliminar_Click;
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
            btn_editar.Location = new Point(184, 507);
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(14, 0, 0, 0);
            btn_editar.Size = new Size(155, 49);
            btn_editar.TabIndex = 14;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btnEditar_Click;
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
            btn_agregar.Location = new Point(14, 507);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Padding = new Padding(14, 0, 0, 0);
            btn_agregar.Size = new Size(155, 49);
            btn_agregar.TabIndex = 13;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(14, 41);
            label2.Name = "label2";
            label2.Size = new Size(204, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Categoría";
            // 
            // AgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarCategoria";
            Size = new Size(1085, 665);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private DataGridView dgvCategorias;
        private Panel panel1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Button btn_limpiar;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_agregar;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox nombreCategoria;
    }
}
