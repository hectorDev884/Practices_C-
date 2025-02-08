namespace HMTC_Practica16
{
    partial class frmPractica16
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cdmCargar = new Button();
            picImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // cdmCargar
            // 
            cdmCargar.Location = new Point(120, 51);
            cdmCargar.Name = "cdmCargar";
            cdmCargar.Size = new Size(120, 132);
            cdmCargar.TabIndex = 0;
            cdmCargar.Text = "Cargar";
            cdmCargar.UseVisualStyleBackColor = true;
            cdmCargar.Click += cdmCargar_Click;
            // 
            // picImagen
            // 
            picImagen.Location = new Point(323, 53);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(359, 356);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagen.TabIndex = 1;
            picImagen.TabStop = false;
            // 
            // frmPractica16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picImagen);
            Controls.Add(cdmCargar);
            Name = "frmPractica16";
            Text = "Practica 16";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cdmCargar;
        private PictureBox picImagen;
    }
}
