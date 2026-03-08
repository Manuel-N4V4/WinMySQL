using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;
using WinMySQL.Formulario_Mestro;
using WinMySQL.Views;

namespace WinMySQL.Formulario_Alumno
{
    public partial class frmDatosAlumno : Form
    {
        Datos alumno = new Datos();
        DataSet ds;
        public frmDatosAlumno()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno alumno = new frmAlumno();
            alumno.ShowDialog();
        }

        private void frmDatosAlumno_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = alumno.ejecutar("SELECT * FROM Alumnos");
                dgvAlumnos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ID: " + dgvAlumnos.CurrentRow.Cells[0].Value);

            frmAlumno alumno = new frmAlumno(
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
                dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[4].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[5].Value.ToString(),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[6].Value.ToString()),
                dgvAlumnos.CurrentRow.Cells[7].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[8].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[9].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[10].Value.ToString(),
                Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells[11].Value),
                Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells[12].Value),
                Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells[13].Value)
                );

            alumno.ShowDialog();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Desea eliminar el registro?","SISTEMA",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool resultado = alumno.ejecutarComando("DELETE FROM Alumnos WHERE id = " + id);
                if(resultado)
                {
                    MessageBox.Show("Registro eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro");
                }
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
