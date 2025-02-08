namespace HMTC_Practica7
{
    public partial class frmPractica7 : Form
    {
        public frmPractica7()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;

        }

        private void cmdValidar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "12345")
                lblMensaje.Text = "Clave Correcta";
            else lblMensaje.Text = "Clave Incorrecta";
        }
    }
}
