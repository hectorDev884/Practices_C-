namespace HMTC_Practica10
{
    partial class frmPractica10
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
            rdbPrimaria = new RadioButton();
            rdbSecundaria = new RadioButton();
            rdbLicenciatura = new RadioButton();
            rdbBachillerato = new RadioButton();
            cmdImprime = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(320, 34);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(310, 46);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Estudios Maximos";
            // 
            // rdbPrimaria
            // 
            rdbPrimaria.AutoSize = true;
            rdbPrimaria.Location = new Point(148, 94);
            rdbPrimaria.Name = "rdbPrimaria";
            rdbPrimaria.Size = new Size(85, 24);
            rdbPrimaria.TabIndex = 1;
            rdbPrimaria.Text = "Primaria";
            rdbPrimaria.UseVisualStyleBackColor = true;
            // 
            // rdbSecundaria
            // 
            rdbSecundaria.AutoSize = true;
            rdbSecundaria.Location = new Point(148, 164);
            rdbSecundaria.Name = "rdbSecundaria";
            rdbSecundaria.Size = new Size(103, 24);
            rdbSecundaria.TabIndex = 2;
            rdbSecundaria.Text = "Secundaria";
            rdbSecundaria.UseVisualStyleBackColor = true;
            // 
            // rdbLicenciatura
            // 
            rdbLicenciatura.AutoSize = true;
            rdbLicenciatura.Location = new Point(148, 311);
            rdbLicenciatura.Name = "rdbLicenciatura";
            rdbLicenciatura.Size = new Size(109, 24);
            rdbLicenciatura.TabIndex = 3;
            rdbLicenciatura.Text = "Licenciatura";
            rdbLicenciatura.UseVisualStyleBackColor = true;
            // 
            // rdbBachillerato
            // 
            rdbBachillerato.AutoSize = true;
            rdbBachillerato.Location = new Point(148, 234);
            rdbBachillerato.Name = "rdbBachillerato";
            rdbBachillerato.Size = new Size(109, 24);
            rdbBachillerato.TabIndex = 4;
            rdbBachillerato.Text = "Bachillerato";
            rdbBachillerato.UseVisualStyleBackColor = true;
            // 
            // cmdImprime
            // 
            cmdImprime.Location = new Point(340, 164);
            cmdImprime.Name = "cmdImprime";
            cmdImprime.Size = new Size(219, 81);
            cmdImprime.TabIndex = 5;
            cmdImprime.Text = "Imprime";
            cmdImprime.UseVisualStyleBackColor = true;
            cmdImprime.Click += cmdImprime_Click;
            // 
            // frmPractica10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdImprime);
            Controls.Add(rdbBachillerato);
            Controls.Add(rdbLicenciatura);
            Controls.Add(rdbSecundaria);
            Controls.Add(rdbPrimaria);
            Controls.Add(lblMensaje);
            Name = "frmPractica10";
            Text = "Practica 10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private RadioButton rdbPrimaria;
        private RadioButton rdbSecundaria;
        private RadioButton rdbLicenciatura;
        private RadioButton rdbBachillerato;
        private Button cmdImprime;
    }
}
