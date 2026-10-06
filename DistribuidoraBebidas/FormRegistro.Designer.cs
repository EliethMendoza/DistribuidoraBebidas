namespace DistribuidoraBebidas
{
    partial class FormRegistro
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
            pictureBox4 = new PictureBox();
            registro_cContrasena = new TextBox();
            inicio_label = new Label();
            label2 = new Label();
            registro_mostrarContrasena = new CheckBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            registro_contrasena = new TextBox();
            registro_nombreUsuario = new TextBox();
            btn_registrarCuenta = new Button();
            btn_cerrar = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(registro_cContrasena);
            panel1.Controls.Add(inicio_label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(registro_mostrarContrasena);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(registro_contrasena);
            panel1.Controls.Add(registro_nombreUsuario);
            panel1.Controls.Add(btn_registrarCuenta);
            panel1.Location = new Point(139, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 405);
            panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.padlock;
            pictureBox4.Location = new Point(104, 257);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // registro_cContrasena
            // 
            registro_cContrasena.Font = new Font("Segoe UI", 14F);
            registro_cContrasena.Location = new Point(145, 257);
            registro_cContrasena.Name = "registro_cContrasena";
            registro_cContrasena.PasswordChar = '*';
            registro_cContrasena.Size = new Size(234, 32);
            registro_cContrasena.TabIndex = 10;
            // 
            // inicio_label
            // 
            inicio_label.AutoSize = true;
            inicio_label.Cursor = Cursors.Hand;
            inicio_label.Font = new Font("Segoe UI", 10F);
            inicio_label.ForeColor = Color.FromArgb(0, 115, 209);
            inicio_label.Location = new Point(265, 378);
            inicio_label.Name = "inicio_label";
            inicio_label.Size = new Size(88, 19);
            inicio_label.TabIndex = 9;
            inicio_label.Text = "Iniciar Sesión";
            inicio_label.Click += inicio_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(132, 378);
            label2.Name = "label2";
            label2.Size = new Size(131, 19);
            label2.TabIndex = 8;
            label2.Text = "¿Tienes una cuenta?";
            // 
            // registro_mostrarContrasena
            // 
            registro_mostrarContrasena.AutoSize = true;
            registro_mostrarContrasena.Cursor = Cursors.Hand;
            registro_mostrarContrasena.Font = new Font("Segoe UI", 12F);
            registro_mostrarContrasena.Location = new Point(212, 297);
            registro_mostrarContrasena.Name = "registro_mostrarContrasena";
            registro_mostrarContrasena.Size = new Size(167, 25);
            registro_mostrarContrasena.TabIndex = 7;
            registro_mostrarContrasena.Text = "Mostrar Contraseña";
            registro_mostrarContrasena.UseVisualStyleBackColor = true;
            registro_mostrarContrasena.CheckedChanged += registro_mostrarContrasena_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 121);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 6;
            label1.Text = "Registrar Cuenta";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(203, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.padlock;
            pictureBox2.Location = new Point(104, 207);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.username_icon;
            pictureBox1.Location = new Point(104, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // registro_contrasena
            // 
            registro_contrasena.Font = new Font("Segoe UI", 14F);
            registro_contrasena.Location = new Point(145, 207);
            registro_contrasena.Name = "registro_contrasena";
            registro_contrasena.PasswordChar = '*';
            registro_contrasena.Size = new Size(234, 32);
            registro_contrasena.TabIndex = 2;
            // 
            // registro_nombreUsuario
            // 
            registro_nombreUsuario.Font = new Font("Segoe UI", 14F);
            registro_nombreUsuario.Location = new Point(145, 157);
            registro_nombreUsuario.Name = "registro_nombreUsuario";
            registro_nombreUsuario.Size = new Size(234, 32);
            registro_nombreUsuario.TabIndex = 1;
            // 
            // btn_registrarCuenta
            // 
            btn_registrarCuenta.BackColor = Color.FromArgb(0, 115, 209);
            btn_registrarCuenta.Cursor = Cursors.Hand;
            btn_registrarCuenta.FlatAppearance.BorderSize = 0;
            btn_registrarCuenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_registrarCuenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_registrarCuenta.FlatStyle = FlatStyle.Flat;
            btn_registrarCuenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrarCuenta.ForeColor = Color.White;
            btn_registrarCuenta.Location = new Point(104, 330);
            btn_registrarCuenta.Name = "btn_registrarCuenta";
            btn_registrarCuenta.Size = new Size(275, 44);
            btn_registrarCuenta.TabIndex = 0;
            btn_registrarCuenta.Text = "Crear Cuenta";
            btn_registrarCuenta.UseVisualStyleBackColor = false;
            btn_registrarCuenta.Click += btn_registrar_Click;
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
            btn_cerrar.Location = new Point(711, 12);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(39, 29);
            btn_cerrar.TabIndex = 2;
            btn_cerrar.Text = "X";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 115, 209);
            ClientSize = new Size(762, 520);
            Controls.Add(btn_cerrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label inicio_label;
        private Label label2;
        private CheckBox registro_mostrarContrasena;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox registro_contrasena;
        private TextBox registro_nombreUsuario;
        private Button btn_registrarCuenta;
        private Button btn_cerrar;
        private PictureBox pictureBox4;
        private TextBox registro_cContrasena;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}