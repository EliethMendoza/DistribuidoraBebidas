namespace DistribuidoraBebidas
{
    partial class AgregarProductos
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
            panel1 = new Panel();
            dgvProductos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nombreProducto = new TextBox();
            cbxCategoria = new ComboBox();
            cbxMarca = new ComboBox();
            precioProducto = new TextBox();
            label4 = new Label();
            stockProducto = new TextBox();
            label5 = new Label();
            btn_limpiar = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            btn_agregar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProductos);
            panel1.Location = new Point(13, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 337);
            panel1.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvProductos.ColumnHeadersHeight = 40;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.Size = new Size(1059, 337);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(13, 34);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(380, 34);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 19;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(747, 34);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 21;
            label3.Text = "Marca";
            // 
            // nombreProducto
            // 
            nombreProducto.Font = new Font("Segoe UI", 14F);
            nombreProducto.Location = new Point(13, 71);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Size = new Size(325, 32);
            nombreProducto.TabIndex = 18;
            // 
            // cbxCategoria
            // 
            cbxCategoria.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            cbxCategoria.Font = new Font("Segoe UI", 14F);
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbxCategoria.Location = new Point(380, 70);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(325, 33);
            cbxCategoria.TabIndex = 25;
            // 
            // cbxMarca
            // 
            cbxMarca.Font = new Font("Segoe UI", 14F);
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbxMarca.Location = new Point(747, 70);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(325, 33);
            cbxMarca.TabIndex = 26;
            // 
            // precioProducto
            // 
            precioProducto.Font = new Font("Segoe UI", 14F);
            precioProducto.Location = new Point(13, 170);
            precioProducto.Name = "precioProducto";
            precioProducto.Size = new Size(325, 32);
            precioProducto.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(13, 133);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 27;
            label4.Text = "Precio Unidad";
            // 
            // stockProducto
            // 
            stockProducto.Font = new Font("Segoe UI", 14F);
            stockProducto.Location = new Point(380, 170);
            stockProducto.Name = "stockProducto";
            stockProducto.Size = new Size(325, 32);
            stockProducto.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(380, 133);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 29;
            label5.Text = "Cantidad de Producto";
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
            btn_limpiar.Location = new Point(522, 242);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Padding = new Padding(14, 0, 0, 0);
            btn_limpiar.Size = new Size(155, 49);
            btn_limpiar.TabIndex = 34;
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
            btn_eliminar.Location = new Point(352, 242);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Padding = new Padding(14, 0, 0, 0);
            btn_eliminar.Size = new Size(155, 49);
            btn_eliminar.TabIndex = 33;
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
            btn_editar.Location = new Point(183, 242);
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(14, 0, 0, 0);
            btn_editar.Size = new Size(155, 49);
            btn_editar.TabIndex = 32;
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
            btn_agregar.Location = new Point(13, 242);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Padding = new Padding(14, 0, 0, 0);
            btn_agregar.Size = new Size(155, 49);
            btn_agregar.TabIndex = 31;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btnAgregar_Click;
            // 
            // AgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_limpiar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_agregar);
            Controls.Add(stockProducto);
            Controls.Add(label5);
            Controls.Add(precioProducto);
            Controls.Add(label4);
            Controls.Add(cbxMarca);
            Controls.Add(cbxCategoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nombreProducto);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AgregarProductos";
            Size = new Size(1085, 665);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nombreProducto;
        private ComboBox cbxCategoria;
        private ComboBox cbxMarca;
        private TextBox precioProducto;
        private Label label4;
        private TextBox stockProducto;
        private Label label5;
        private Button btn_limpiar;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_agregar;
        private DataGridView dgvProductos;
    }
}
