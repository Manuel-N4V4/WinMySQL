using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmAlumno : Form
    {
        Datos datos = new Datos();
        int id = 0;
        bool update = false;
        public frmAlumno()
        {
            InitializeComponent();
        }

        public frmAlumno(int id,string nombre, string apellidoPaterno,string apellidoMaterno,
            string numControl,string carrera,int semestre,string telefono,string correo,
            string direccion,string ciudad,DateTime fechaNacimiento,DateTime fechaIngreso,DateTime fechaEgreso)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = nombre;
            txtPaterno.Text = apellidoPaterno;
            txtMaterno.Text = apellidoMaterno;
            txtNumControl.Text = numControl;
            txtCarrera.Text = carrera;
            nudSemestre.Value = semestre;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            txtDireccion.Text = direccion;
            txtCiudad.Text = ciudad;
            dtpFechaNacimiento.Value = fechaNacimiento;
            dtpIngreso.Value = fechaIngreso;
            dtpEgreso.Value = fechaEgreso;
            update = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           if(update == false)
            {
                bool resultado = datos.ejecutarComando(
                    $"INSERT INTO Alumnos (nombre, apellido_paterno, apellido_materno, numero_control, carrera, semestre, telefono, correo, direccion, ciudad, fecha_nacimiento, fecha_ingreso, fecha_egreso) " +
                    $"VALUES ('{txtNombre.Text}','{txtPaterno.Text}','{txtMaterno.Text}','{txtNumControl.Text}','{txtCarrera.Text}',{nudSemestre.Value},'{txtTelefono.Text}','{txtCorreo.Text}','{txtDireccion.Text}','{txtCiudad.Text}','{dtpFechaNacimiento.Value:yyyy-MM-dd}','{dtpIngreso.Value:yyyy-MM-dd}','{dtpEgreso.Value:yyyy-MM-dd}')"
                    );
                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el alumno");
                }
            }
           else
            {
                bool resultado = datos.ejecutarComando($"Update Alumnos set nombre = '{txtNombre.Text}', apellido_paterno = '{txtPaterno.Text}', apellido_materno = '{txtMaterno.Text}', numero_control = '{txtNumControl.Text}', carrera = '{txtCarrera.Text}', semestre = {nudSemestre.Value}, telefono = '{txtTelefono.Text}', correo = '{txtCorreo.Text}', direccion = '{txtDireccion.Text}', ciudad = '{txtCiudad.Text}', fecha_nacimiento = '{dtpFechaNacimiento.Value:yyyy-MM-dd}', fecha_ingreso = '{dtpIngreso.Value:yyyy-MM-dd}', fecha_egreso = '{dtpEgreso.Value:yyyy-MM-dd}' where id = {id}");
                if(resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente", "SISTEMA");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el alumno", "SISTEMA");
                    this.Close();
                }
            }
        }
    }
}
