namespace WinMySQL.Views
{
    partial class frmAlumno
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
            dtpFechaNacimiento = new DateTimePicker();
            btnAceptar = new Button();
            txtCarrera = new TextBox();
            txtNumControl = new TextBox();
            txtCiudad = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtMaterno = new TextBox();
            txtPaterno = new TextBox();
            txtNombre = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            nudSemestre = new NumericUpDown();
            dtpIngreso = new DateTimePicker();
            label12 = new Label();
            dtpEgreso = new DateTimePicker();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(553, 107);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(291, 27);
            dtpFechaNacimiento.TabIndex = 44;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(710, 224);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(134, 29);
            btnAceptar.TabIndex = 43;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(71, 153);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(304, 27);
            txtCarrera.TabIndex = 42;
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(167, 115);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(208, 27);
            txtNumControl.TabIndex = 41;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(466, 79);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(378, 27);
            txtCiudad.TabIndex = 40;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(466, 49);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(378, 27);
            txtDireccion.TabIndex = 39;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(466, 14);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(378, 27);
            txtCorreo.TabIndex = 38;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(78, 185);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(297, 27);
            txtTelefono.TabIndex = 37;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(136, 84);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(239, 27);
            txtMaterno.TabIndex = 36;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(136, 51);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(239, 27);
            txtPaterno.TabIndex = 35;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 27);
            txtNombre.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(392, 112);
            label10.Name = "label10";
            label10.Size = new Size(146, 20);
            label10.TabIndex = 33;
            label10.Text = "Fecha de nacimiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(392, 82);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 32;
            label9.Text = "Ciudad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(393, 49);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 31;
            label8.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 17);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 30;
            label7.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 191);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 29;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 153);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 28;
            label5.Text = "Carrera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 119);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 27;
            label4.Text = "Numero de control";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 87);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 26;
            label3.Text = "Apellido materno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 54);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 25;
            label2.Text = "Apellido paterno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 24;
            label1.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 224);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 45;
            label11.Text = "Semestre";
            // 
            // nudSemestre
            // 
            nudSemestre.Location = new Point(78, 224);
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(84, 27);
            nudSemestre.TabIndex = 47;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Location = new Point(553, 140);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(291, 27);
            dtpIngreso.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(392, 145);
            label12.Name = "label12";
            label12.Size = new Size(121, 20);
            label12.TabIndex = 48;
            label12.Text = "Fecha de ingreso";
            // 
            // dtpEgreso
            // 
            dtpEgreso.Location = new Point(553, 173);
            dtpEgreso.Name = "dtpEgreso";
            dtpEgreso.Size = new Size(291, 27);
            dtpEgreso.TabIndex = 51;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(392, 178);
            label13.Name = "label13";
            label13.Size = new Size(117, 20);
            label13.TabIndex = 50;
            label13.Text = "Fecha de egreso";
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 263);
            Controls.Add(dtpEgreso);
            Controls.Add(label13);
            Controls.Add(dtpIngreso);
            Controls.Add(label12);
            Controls.Add(nudSemestre);
            Controls.Add(label11);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(btnAceptar);
            Controls.Add(txtCarrera);
            Controls.Add(txtNumControl);
            Controls.Add(txtCiudad);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlumno";
            Text = "frmAlumno";
            ((System.ComponentModel.ISupportInitialize)nudSemestre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaNacimiento;
        private Button btnAceptar;
        private TextBox txtCarrera;
        private TextBox txtNumControl;
        private TextBox txtCiudad;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtMaterno;
        private TextBox txtPaterno;
        private TextBox txtNombre;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private NumericUpDown nudSemestre;
        private DateTimePicker dtpIngreso;
        private Label label12;
        private DateTimePicker dtpEgreso;
        private Label label13;
    }
}