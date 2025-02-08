namespace HMTC_Practica17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                if (saveFileDialog1 != null)
                    rtbInformacion.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }
    }
}
