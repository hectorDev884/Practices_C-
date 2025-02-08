namespace Practica_4
{
    public partial class frmPractica4 : Form
    {
        public frmPractica4()
        {
            InitializeComponent();
        }

        private void cmdAmarillo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void cmdAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }

        private void cmdRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
