using WinMySQL.Formulario_Alumno;
using WinMySQL.Formulario_Mestro;
using WinMySQL.Views;

namespace WinMySQL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias materias = new frmMaterias();
            materias.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaestro maestro = new frmMaestro();
            maestro.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosAlumno alumno = new frmDatosAlumno();
            alumno.Show();
        }
    }
}
