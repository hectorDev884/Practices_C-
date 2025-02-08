namespace Practica2
{
    public partial class frmPractica2 : Form
    {
        public frmPractica2()
        {
            InitializeComponent();
        }

        private void cmdArea_Click(object sender, EventArgs e)
        {
            double b, a;
            double area;
            string texto = Microsoft.VisualBasic.Interaction.InputBox(
            "Introduzca la base",
            "Introducir datos",
            "");
            b = Convert.ToDouble(texto);
            texto = Microsoft.VisualBasic.Interaction.InputBox(
            "Introduzca la altura",
            "Introducir datos",
            "");
            a = Convert.ToDouble(texto);
            area = b * a / 2;
            MessageBox.Show("El área del triangulo es: " + area);
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
