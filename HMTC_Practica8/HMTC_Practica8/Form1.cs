namespace HMTC_Practica8
{
    public partial class frmPractica8 : Form
    {
        public frmPractica8()
        {
            InitializeComponent();
        }

        private void cmdImprime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtObservaciones.Text);
        }
    }
}
