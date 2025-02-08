namespace HMTC_Practica8
{
    partial class frmPractica8
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
            lblMensaje = new Label();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            cmdImprime = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(255, 35);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(251, 46);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Observaciones";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(149, 157);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(108, 20);
            lblObservaciones.TabIndex = 1;
            lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(291, 157);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(327, 148);
            txtObservaciones.TabIndex = 2;
            // 
            // cmdImprime
            // 
            cmdImprime.Location = new Point(303, 321);
            cmdImprime.Name = "cmdImprime";
            cmdImprime.Size = new Size(175, 67);
            cmdImprime.TabIndex = 3;
            cmdImprime.Text = "Imprime";
            cmdImprime.UseVisualStyleBackColor = true;
            cmdImprime.Click += cmdImprime_Click;
            // 
            // frmPractica8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdImprime);
            Controls.Add(txtObservaciones);
            Controls.Add(lblObservaciones);
            Controls.Add(lblMensaje);
            Name = "frmPractica8";
            Text = "Practica 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Label lblObservaciones;
        private TextBox txtObservaciones;
        private Button cmdImprime;
    }
}
