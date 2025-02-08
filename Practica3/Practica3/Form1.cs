namespace Practica3
{
    public partial class frmPractica3 : Form
    {
        public frmPractica3()
        {
            InitializeComponent();
        }

        private void cmdImprime_Click(object sender, EventArgs e)
        {
            //
            // Ejemplo simple MessageBox.Show. [1]
            //
            MessageBox.Show("Hola");
            //
            // Mensaje con texto y título. [2]
            //
            MessageBox.Show("Programación Visual",
            "Mensaje importante");
            //
            // Mensaje con botones yes and no. [3]
            //
            DialogResult result1 = MessageBox.Show("Tienes Maestría?",
            "Mensaje importante",
            MessageBoxButtons.YesNo);
            //
            // Mensaje con question icon. [4]
            //
            DialogResult result2 = MessageBox.Show("Tienes Maestría?",
            "Mensaje importante",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
            //
            // Mensaje con question icon and botón default. [5]
            //
            DialogResult result3 = MessageBox.Show("Te gusta el cine?",
            "La pregunta",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            //
            // Examinando las respuestas . [6]
            //
            if (result1 == DialogResult.Yes &&
            result2 == DialogResult.Yes &&
            result3 == DialogResult.No)
            {
                MessageBox.Show("Su respuesta es Si, Si, No.");
            }

            //
            // Cuadro de diálogo alineado a la derecha (No es útil). [7]

            //
            MessageBox.Show("El clima es cálido?",
            "Error critical",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign,
            true);
            //
            // Usando exclamation icon. [8]
            //
            MessageBox.Show("El clima es cálido",
            "nota Importante",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1);
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
