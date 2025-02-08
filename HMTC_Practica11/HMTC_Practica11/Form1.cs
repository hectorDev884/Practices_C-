namespace HMTC_Practica11
{
    public partial class frmPractica11 : Form
    {
        public frmPractica11()
        {
            InitializeComponent();
        }

        private void frmPractica11_Load(object sender, EventArgs e)
        {
            for (int f = 0; f <= 255; f++)
            {
                cboRojo.Items.Add(f.ToString());
                cboVerde.Items.Add(f.ToString());
                cboAzul.Items.Add(f.ToString());
            }
            cboRojo.SelectedIndex = 0;
            cboVerde.SelectedIndex = 0;
            cboAzul.SelectedIndex = 0;

        }

        private void cmdCambiar_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(cboRojo.Text);
            int verde = int.Parse(cboVerde.Text);
            int azul = int.Parse(cboAzul.Text);
            BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
