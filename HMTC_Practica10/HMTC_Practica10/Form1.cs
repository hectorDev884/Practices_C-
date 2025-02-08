namespace HMTC_Practica10
{
    public partial class frmPractica10 : Form
    {
        public frmPractica10()
        {
            InitializeComponent();
        }

        private void cmdImprime_Click(object sender, EventArgs e)
        {
            if (rdbPrimaria.Checked == true)
                MessageBox.Show("Primaria");
            if (rdbSecundaria.Checked == true)
                MessageBox.Show("Secundaria");
            if (rdbBachillerato.Checked == true)
                MessageBox.Show("Bachillerato");
            if (rdbLicenciatura.Checked == true)
                MessageBox.Show("Licenciatura");
        }
    }
}
