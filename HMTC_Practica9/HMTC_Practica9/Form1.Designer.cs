namespace HMTC_Practica9
{
    partial class frmPractica
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
            chkPinza = new CheckBox();
            chkTijera = new CheckBox();
            chkMartillo = new CheckBox();
            chkAcepto = new CheckBox();
            cmdImprime = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(219, 82);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(330, 46);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Seleccione Material";
            // 
            // chkPinza
            // 
            chkPinza.AutoSize = true;
            chkPinza.Location = new Point(159, 177);
            chkPinza.Name = "chkPinza";
            chkPinza.Size = new Size(72, 24);
            chkPinza.TabIndex = 1;
            chkPinza.Text = "Pinzas";
            chkPinza.UseVisualStyleBackColor = true;
            // 
            // chkTijera
            // 
            chkTijera.AutoSize = true;
            chkTijera.Location = new Point(159, 239);
            chkTijera.Name = "chkTijera";
            chkTijera.Size = new Size(74, 24);
            chkTijera.TabIndex = 2;
            chkTijera.Text = "Tijeras";
            chkTijera.UseVisualStyleBackColor = true;
            // 
            // chkMartillo
            // 
            chkMartillo.AutoSize = true;
            chkMartillo.Location = new Point(159, 301);
            chkMartillo.Name = "chkMartillo";
            chkMartillo.Size = new Size(83, 24);
            chkMartillo.TabIndex = 3;
            chkMartillo.Text = "Martillo";
            chkMartillo.UseVisualStyleBackColor = true;
            // 
            // chkAcepto
            // 
            chkAcepto.AutoSize = true;
            chkAcepto.Location = new Point(347, 151);
            chkAcepto.Name = "chkAcepto";
            chkAcepto.Size = new Size(79, 24);
            chkAcepto.TabIndex = 4;
            chkAcepto.Text = "Acepto";
            chkAcepto.UseVisualStyleBackColor = true;
            chkAcepto.CheckedChanged += chkAcepto_CheckedChanged;
            // 
            // cmdImprime
            // 
            cmdImprime.Location = new Point(295, 215);
            cmdImprime.Name = "cmdImprime";
            cmdImprime.Size = new Size(200, 71);
            cmdImprime.TabIndex = 5;
            cmdImprime.Text = "Imprime";
            cmdImprime.UseVisualStyleBackColor = true;
            cmdImprime.Click += cmdImprime_Click;
            // 
            // frmPractica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdImprime);
            Controls.Add(chkAcepto);
            Controls.Add(chkMartillo);
            Controls.Add(chkTijera);
            Controls.Add(chkPinza);
            Controls.Add(lblMensaje);
            Name = "frmPractica";
            Text = "Practica 9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private CheckBox chkPinza;
        private CheckBox chkTijera;
        private CheckBox chkMartillo;
        private CheckBox chkAcepto;
        private Button cmdImprime;
    }
}
