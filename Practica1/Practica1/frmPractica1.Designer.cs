namespace Practica1
{
    partial class frmPractica1
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
            cmdSaludar = new Button();
            SuspendLayout();
            // 
            // cmdSaludar
            // 
            cmdSaludar.Location = new Point(292, 193);
            cmdSaludar.Name = "cmdSaludar";
            cmdSaludar.Size = new Size(152, 62);
            cmdSaludar.TabIndex = 1;
            cmdSaludar.Text = "Saludar";
            cmdSaludar.UseVisualStyleBackColor = true;
            cmdSaludar.Click += cmdSaludar_Click;
            // 
            // frmPractica1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdSaludar);
            Name = "frmPractica1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Practica 1";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdSaludar;
    }
}
