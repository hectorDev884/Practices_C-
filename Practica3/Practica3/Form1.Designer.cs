namespace Practica3
{
    partial class frmPractica3
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
            cmdImprime = new Button();
            cmdSalir = new Button();
            SuspendLayout();
            // 
            // cmdImprime
            // 
            cmdImprime.Location = new Point(158, 151);
            cmdImprime.Name = "cmdImprime";
            cmdImprime.Size = new Size(149, 93);
            cmdImprime.TabIndex = 0;
            cmdImprime.Text = "Imprime";
            cmdImprime.UseVisualStyleBackColor = true;
            cmdImprime.Click += cmdImprime_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(426, 151);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(149, 93);
            cmdSalir.TabIndex = 1;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // frmPractica3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdSalir);
            Controls.Add(cmdImprime);
            Name = "frmPractica3";
            Text = "Practica 3";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdImprime;
        private Button cmdSalir;
    }
}
