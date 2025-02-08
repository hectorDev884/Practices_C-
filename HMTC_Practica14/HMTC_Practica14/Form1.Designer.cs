namespace HMTC_Practica14
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            picImagen = new PictureBox();
            cmdCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 41);
            label1.Name = "label1";
            label1.Size = new Size(173, 46);
            label1.TabIndex = 0;
            label1.Text = "Imagenes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 142);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Imagen: ";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(273, 133);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(264, 223);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagen.TabIndex = 2;
            picImagen.TabStop = false;
            // 
            // cmdCargar
            // 
            cmdCargar.Location = new Point(288, 372);
            cmdCargar.Name = "cmdCargar";
            cmdCargar.Size = new Size(238, 39);
            cmdCargar.TabIndex = 3;
            cmdCargar.Text = "Cargar";
            cmdCargar.UseVisualStyleBackColor = true;
            cmdCargar.Click += cmdCargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdCargar);
            Controls.Add(picImagen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox picImagen;
        private Button cmdCargar;
    }
}
