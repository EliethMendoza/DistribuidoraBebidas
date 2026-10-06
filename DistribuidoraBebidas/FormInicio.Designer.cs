namespace DistribuidoraBebidas
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            registro_label = new Label();
            label2 = new Label();
            inicio_mostrarContrasena = new CheckBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            inicio_contrasena = new TextBox();
            inicio_nombreUsuario = new TextBox();
            btn_iniciarSesion = new Button();
            btn_cerrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(registro_label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(inicio_mostrarContrasena);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(inicio_contrasena);
            panel1.Controls.Add(inicio_nombreUsuario);
            panel1.Controls.Add(btn_iniciarSesion);
            panel1.Location = new Point(139, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 405);
            panel1.TabIndex = 0;
            // 
            // registro_label
            // 
            registro_label.AutoSize = true;
            registro_label.Cursor = Cursors.Hand;
            registro_label.Font = new Font("Segoe UI", 10F);
            registro_label.ForeColor = Color.FromArgb(0, 115, 209);
            registro_label.Location = new Point(299, 372);
            registro_label.Name = "registro_label";
            registro_label.Size = new Size(70, 19);
            registro_label.TabIndex = 9;
            registro_label.Text = "Regístrate";
            registro_label.Click += registro_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(112, 372);
            label2.Name = "label2";
            label2.Size = new Size(178, 19);
            label2.TabIndex = 8;
            label2.Text = "¿Aún no tienes una cuenta?";
            // 
            // inicio_mostrarContrasena
            // 
            inicio_mostrarContrasena.AutoSize = true;
            inicio_mostrarContrasena.Cursor = Cursors.Hand;
            inicio_mostrarContrasena.Font = new Font("Segoe UI", 12F);
            inicio_mostrarContrasena.Location = new Point(212, 273);
            inicio_mostrarContrasena.Name = "inicio_mostrarContrasena";
            inicio_mostrarContrasena.Size = new Size(167, 25);
            inicio_mostrarContrasena.TabIndex = 7;
            inicio_mostrarContrasena.Text = "Mostrar Contraseña";
            inicio_mostrarContrasena.UseVisualStyleBackColor = true;
            inicio_mostrarContrasena.CheckedChanged += inicio_mostrarContrasena_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 123);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 6;
            label1.Text = "Cuenta de Inicio de Sesión";
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
            pictureBox2.Location = new Point(104, 221);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.username_icon;
            pictureBox1.Location = new Point(104, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // inicio_contrasena
            // 
            inicio_contrasena.Font = new Font("Segoe UI", 14F);
            inicio_contrasena.Location = new Point(145, 221);
            inicio_contrasena.Name = "inicio_contrasena";
            inicio_contrasena.PasswordChar = '*';
            inicio_contrasena.Size = new Size(234, 32);
            inicio_contrasena.TabIndex = 2;
            // 
            // inicio_nombreUsuario
            // 
            inicio_nombreUsuario.Font = new Font("Segoe UI", 14F);
            inicio_nombreUsuario.Location = new Point(145, 166);
            inicio_nombreUsuario.Name = "inicio_nombreUsuario";
            inicio_nombreUsuario.Size = new Size(234, 32);
            inicio_nombreUsuario.TabIndex = 1;
            // 
            // btn_iniciarSesion
            // 
            btn_iniciarSesion.BackColor = Color.FromArgb(0, 115, 209);
            btn_iniciarSesion.Cursor = Cursors.Hand;
            btn_iniciarSesion.FlatAppearance.BorderSize = 0;
            btn_iniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_iniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_iniciarSesion.FlatStyle = FlatStyle.Flat;
            btn_iniciarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_iniciarSesion.ForeColor = Color.White;
            btn_iniciarSesion.Location = new Point(104, 313);
            btn_iniciarSesion.Name = "btn_iniciarSesion";
            btn_iniciarSesion.Size = new Size(275, 44);
            btn_iniciarSesion.TabIndex = 0;
            btn_iniciarSesion.Text = "Iniciar Sesión";
            btn_iniciarSesion.UseVisualStyleBackColor = false;
            btn_iniciarSesion.Click += btn_iniciarSesion_Click;
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
            btn_cerrar.TabIndex = 1;
            btn_cerrar.Text = "X";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 115, 209);
            ClientSize = new Size(762, 520);
            Controls.Add(btn_cerrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_iniciarSesion;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox inicio_contrasena;
        private TextBox inicio_nombreUsuario;
        private CheckBox inicio_mostrarContrasena;
        private Label label1;
        private Label registro_label;
        private Label label2;
        private Button btn_cerrar;
    }
}
