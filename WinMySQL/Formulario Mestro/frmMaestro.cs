using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;
using WinMySQL.Formulario_Mestro;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinMySQL.Views
{
    public partial class frmMaestro : Form
    {
        Datos maestro = new Datos();
        DataSet ds;
        public frmMaestro()
        {
            InitializeComponent();
        }

        private void frmMaestro_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = maestro.ejecutar("SELECT * FROM Profesores");
                if (ds != null)
                {
                    dgvMaestros.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDatosMaestro dm = new frmDatosMaestro();
            dm.ShowDialog();
        }

        private void dgvMaestros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ID: " + dgvMaestros.CurrentRow.Cells[0].Value);

            frmDatosMaestro dm = new frmDatosMaestro(
                Convert.ToInt32(dgvMaestros.CurrentRow.Cells[0].Value),
                dgvMaestros.CurrentRow.Cells[1].Value.ToString(),
                dgvMaestros.CurrentRow.Cells[2].Value.ToString(),
                dgvMaestros.CurrentRow.Cells[3].Value.ToString(),
                dgvMaestros.CurrentRow.Cells[4].Value.ToString(),
                dgvMaestros.CurrentRow.Cells[5].Value.ToString(),
                dgvMaestros.CurrentRow.Cells[6].Value.ToString(),
                dgvMaestros.CurrentRow.Cells[7].Value.ToString(),
                dgvMaestros.CurrentRow.Cells[8].Value.ToString(),
                dgvMaestros.CurrentRow.Cells[9].Value.ToString(),
                Convert.ToDateTime(dgvMaestros.CurrentRow.Cells[10].Value)
                );
            dm.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(dgvMaestros.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("¿Desea eliminar el registro?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool resultado = maestro.ejecutarComando($"DELETE FROM Profesores WHERE id = {indice}");
                if (resultado)
                {
                    MessageBox.Show("Registro eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro");
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvMaestros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
