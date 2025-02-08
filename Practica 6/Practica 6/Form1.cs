namespace Practica_6
{
    public partial class frmPractica6 : Form
    {
        public frmPractica6()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            txtArea.Text = Convert.ToString(Convert.ToDecimal(txtBase.Text) *
            Convert.ToDecimal(txtAltura.Text) / 2);
        }
    }
}
