namespace HTMC_Practica19
{
    public partial class frmPractica19 : Form
    {
        public frmPractica19()
        {
            InitializeComponent();
        }

        private void InitializeTimer()
        {
            // Call this procedure when the application starts.
            // Set to 1 second.
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            // Enable timer.
            timer1.Enabled = true;
            cmdActivar.Text = "Detener";
            cmdActivar.Click += new EventHandler(cmdActivar_Click);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Asignar hora actual a la etiqueta
            lblDatoHora.Text = DateTime.Now.ToString();
        }

        private void cmdActivar_Click(object sender, EventArgs e)
        {
            if (cmdActivar.Text == "Detener")
            {
                cmdActivar.Text = "Iniciar";
                timer1.Enabled = false;
            }
            else
            {
                cmdActivar.Text = "Detener";
                timer1.Enabled = true;
            }
        }
    }
}
