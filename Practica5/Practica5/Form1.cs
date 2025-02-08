namespace Practica5
{
    public partial class frmPractica5 : Form
    {
        Double Resultado = 0;
        Char operacion = 'X';
        public frmPractica5()
        {
            InitializeComponent();
        }
        private void cmdCero_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (!(operacion != 'X'))
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdCero.Text;
            }
        }
        private void cmdUno_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdUno.Text;
            }
        }
        private void cmdCuatro_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdCuatro.Text;
            }
        }
        private void cmdSiete_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdSiete.Text;
            }
        }
        private void cmdOcho_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdOcho.Text;
            }
        }
        private void cmdCinco_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdCinco.Text;
            }
        }
        private void cmdDos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdDos.Text;
            }
        }
        private void cmdNueve_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdNueve.Text;
            }
        }
        private void cmdSeis_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdSeis.Text;
            }
        }
        private void cmdTres_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion != 'X')
                    txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text + cmdTres.Text;
            }
        }
        private void cmdPunto_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
        private void cmdIgual_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                if (operacion == '+')
                {
                    Resultado = Resultado + Convert.ToDouble(txtResultado.Text);
                    txtResultado.Text = Convert.ToString(Resultado);
                }
                else if (operacion == '-')
                {
                    Resultado = Resultado - Convert.ToDouble(txtResultado.Text);
                    txtResultado.Text = Convert.ToString(Resultado);
                }
                else if (operacion == '/')
                {
                    Resultado = Resultado / Convert.ToDouble(txtResultado.Text);
                    txtResultado.Text = Convert.ToString(Resultado);
                }
                else if (operacion == '*')
                {
                    Resultado = Resultado * Convert.ToDouble(txtResultado.Text);
                    txtResultado.Text = Convert.ToString(Resultado);
                }
            }
        }
        private void cmdSuma_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                Resultado = Convert.ToDouble(txtResultado.Text);
                operacion = '+';
            }
        }
        private void cmdResta_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                Resultado = Convert.ToDouble(txtResultado.Text);
                operacion = '-';
            }
        }
        private void cmdMultiplica_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                Resultado = Convert.ToDouble(txtResultado.Text);
                operacion = '*';
            }
        }
        private void cmdDivide_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length < 12)
            {
                Resultado = Convert.ToDouble(txtResultado.Text);
                operacion = '/';
            }
        }
        private void frmPractica5_Load(object sender, EventArgs e)
        {
        }

        private void cmdBorra_Click(object sender, EventArgs e)
        {
            this.operacion = 'X';
            this.Resultado = 0;
            txtResultado.Text = "0";
        }
    }

}
