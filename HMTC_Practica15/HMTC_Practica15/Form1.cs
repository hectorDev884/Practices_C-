namespace HMTC_Practica15
{
    public partial class frmPractica15 : Form
    {
        public frmPractica15()
        {
            InitializeComponent();
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrimero frm1 = new frmPrimero();
            frm1.Show();
        }

        private void segundoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSegundo frm2 = new frmSegundo();
            frm2.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

