namespace HMTC_Practica18
{
    public partial class frmPractica18 : Form
    {
        public frmPractica18()
        {
            InitializeComponent();
        }

        private void nudDistancia_ValueChanged(object sender, EventArgs e)
        {
            if (nudDistancia.Value != 0 && nudVelocidad.Value != 0)
                txtTiempo.Text = Convert.ToString(nudDistancia.Value /
                nudVelocidad.Value);
        }

        private void nudVelocidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudDistancia.Value != 0 && nudVelocidad.Value != 0)
                txtTiempo.Text = Convert.ToString(nudDistancia.Value /
                nudVelocidad.Value);
        }
    }
}
