namespace HMTC_Practica16
{
    public partial class frmPractica16 : Form
    {
        public frmPractica16()
        {
            InitializeComponent();
        }

        private void cdmCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.InitialDirectory = "C:\\";
            fo.Filter = "png files (*.png)|*.png";
            fo.RestoreDirectory = true;
            if (fo.ShowDialog() == DialogResult.OK)
            {
                if (fo.OpenFile() != null)
                    picImagen.Load(fo.FileName);
            }
        }
    }
}
