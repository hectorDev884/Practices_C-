namespace HMTC_Practica17
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
            cmdGrabar = new Button();
            rtbInformacion = new RichTextBox();
            SuspendLayout();
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(273, 343);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(207, 74);
            cmdGrabar.TabIndex = 0;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // rtbInformacion
            // 
            rtbInformacion.Location = new Point(184, 101);
            rtbInformacion.Name = "rtbInformacion";
            rtbInformacion.Size = new Size(387, 215);
            rtbInformacion.TabIndex = 1;
            rtbInformacion.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbInformacion);
            Controls.Add(cmdGrabar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdGrabar;
        private RichTextBox rtbInformacion;
    }
}
