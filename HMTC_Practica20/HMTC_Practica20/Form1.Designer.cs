namespace HMTC_Practica20
{
    partial class frmPractica20
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
            cmdCargar = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // cmdCargar
            // 
            cmdCargar.Location = new Point(300, 146);
            cmdCargar.Name = "cmdCargar";
            cmdCargar.Size = new Size(181, 92);
            cmdCargar.TabIndex = 0;
            cmdCargar.Text = "Cargar";
            cmdCargar.UseVisualStyleBackColor = true;
            cmdCargar.Click += cmdCargar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(203, 301);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(371, 60);
            progressBar1.TabIndex = 1;
            // 
            // frmPractica20
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(cmdCargar);
            Name = "frmPractica20";
            Text = "Practica 20";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdCargar;
        private ProgressBar progressBar1;
    }
}
