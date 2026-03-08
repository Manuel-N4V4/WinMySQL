using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Formulario_Mestro
{
    public partial class frmDatosMaestro : Form
    {
        Datos maestro = new Datos();
        bool update = false;
        int id = 0;
        public frmDatosMaestro()
        {
            InitializeComponent();
        }

        public frmDatosMaestro(
    int id,
    string nombre,
    string apellidoPaterno,
    string apellidoMaterno,
    string numeroEmpleado,
    string carrera,
    string telefono,
    string correo,
    string direccion,
    string ciudad,
    DateTime fechaContratacion)
        {
            InitializeComponent();
            this.id = id;

            txtNombre.Text = nombre;
            txtPaterno.Text = apellidoPaterno;
            txtMaterno.Text = apellidoMaterno;
            txtNumEmpleado.Text = numeroEmpleado;
            txtCarrera.Text = carrera;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            txtDireccion.Text = direccion;
            txtCiudad.Text = ciudad;
            dtpFechaContratacion.Value = fechaContratacion;
            update = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                bool resultado = maestro.ejecutarComando(
                $"INSERT INTO Profesores (nombre, apellido_paterno, apellido_materno, numero_empleado, carrera, telefono, correo, direccion, ciudad, fecha_contratacion) " +
                $"VALUES ('{txtNombre.Text}','{txtPaterno.Text}','{txtMaterno.Text}','{txtNumEmpleado.Text}','{txtCarrera.Text}','{txtTelefono.Text}','{txtCorreo.Text}','{txtDireccion.Text}','{txtCiudad.Text}','{dtpFechaContratacion.Value:yyyy-MM-dd}')"
                );

                if (resultado)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar profesor");
                }
            }
            else
            {
                bool resultado = maestro.ejecutarComando(
                    $"UPDATE Profesores SET nombre='{txtNombre.Text}', apellido_paterno='{txtPaterno.Text}', apellido_materno='{txtMaterno.Text}', numero_empleado='{txtNumEmpleado.Text}', carrera='{txtCarrera.Text}', telefono='{txtTelefono.Text}', correo='{txtCorreo.Text}', direccion='{txtDireccion.Text}', ciudad='{txtCiudad.Text}', fecha_contratacion='{dtpFechaContratacion.Value:yyyy-MM-dd}' " +
                    $"WHERE id={id}"
                    );
                if (resultado)
                {
                    MessageBox.Show("Profesor actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar profesor");
                }
            }
        }
    }
}
