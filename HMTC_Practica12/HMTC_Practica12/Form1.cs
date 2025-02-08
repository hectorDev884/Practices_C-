namespace HMTC_Practica12
{
    public partial class frmPractica12 : Form
    {
        public frmPractica12()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            lstMateriales.Items.Add(txtMaterial.Text);
            txtMaterial.Text = "";
            txtMaterial.Focus();
        }
        private void lstMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMateriales.Items.Remove(lstMateriales.SelectedItem);
        }
    }
}
