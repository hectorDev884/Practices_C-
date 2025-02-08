namespace HMTC_Practica20
{
    public partial class frmPractica20 : Form
    {
        public frmPractica20()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            // maximum indica el valor máximo de la barra
            progressBar1.Maximum = 1000000;
            //minimum indica el valor mínimo de la barra
            progressBar1.Minimum = 0;
            //value indica desde donde se va a comenzar a llenar la barra, la
            //nuestra iniciara desde cero
            progressBar1.Value = 0;
            //Por ejemplo podemos hacer que la barra inicie desde la mitad
            //la siguiente instrucción indica que inicie cargando desde la mitad del
            //tamaño de la barra
            //progressBar1.Value = progressBar1.Maximum / 2;
            //step indica el paso de la barra, entre más pequeño sea la barra
            //tardará más en cargar
            progressBar1.Step = 1;
            //el ciclo for cargará la barra
            for (int i = progressBar1.Minimum; i < progressBar1.Maximum; i = i +
            progressBar1.Step)
            {
                //esta instrucción avanza la posición actual de la barra
                progressBar1.PerformStep();
            }
        }
    }
}
