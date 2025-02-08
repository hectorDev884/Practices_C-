namespace HMTC_Practica9
{
    public partial class frmPractica : Form
    {
        public frmPractica()
        {
            InitializeComponent();
        }

        private void cmdImprime_Click(object sender, EventArgs e)
        {
            string t = "";
            if (chkPinza.Checked == true)
                t = t + "(" + chkPinza.Text + ")";
            if (chkTijera.Checked == true)
                t = t + "(" + chkTijera.Text + ")";
            if (chkMartillo.Checked == true)
                t = t + "(" + chkMartillo.Text + ")";
            MessageBox.Show(t);
        }
        private void chkAcepto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcepto.Checked == true)
                cmdImprime.Enabled = true;
            else
                cmdImprime.Enabled = false;
        }
    }
}
