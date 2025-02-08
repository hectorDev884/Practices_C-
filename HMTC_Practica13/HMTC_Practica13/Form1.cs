namespace HMTC_Practica13
{
    public partial class frmPractica13 : Form
    {
        public frmPractica13()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            txtBase.Text = Convert.ToString(hScrollBar1.Value);
            txtArea.Text = Convert.ToString(hScrollBar1.Value * vScrollBar1.Value / 2);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            txtAltura.Text = Convert.ToString(vScrollBar1.Value);
            txtArea.Text = Convert.ToString(hScrollBar1.Value * vScrollBar1.Value / 2);
        }
    }
}
