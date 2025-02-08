namespace Practica2
{
    partial class frmPractica2
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
            cmdArea = new Button();
            cmdSalir = new Button();
            SuspendLayout();
            // 
            // cmdArea
            // 
            cmdArea.Location = new Point(204, 102);
            cmdArea.Name = "cmdArea";
            cmdArea.Size = new Size(154, 75);
            cmdArea.TabIndex = 0;
            cmdArea.Text = "Area";
            cmdArea.UseVisualStyleBackColor = true;
            cmdArea.Click += cmdArea_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(406, 99);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(181, 78);
            cmdSalir.TabIndex = 1;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // frmPractica2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdSalir);
            Controls.Add(cmdArea);
            Name = "frmPractica2";
            Text = "Practica 2";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdArea;
        private Button cmdSalir;
    }
}
