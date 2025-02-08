namespace Practica_6
{
    partial class frmPractica6
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
            cmdCalcular = new Button();
            lblAltura = new Label();
            lblBase = new Label();
            lblArea = new Label();
            lblMensaje = new Label();
            txtArea = new TextBox();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            SuspendLayout();
            // 
            // cmdCalcular
            // 
            cmdCalcular.Location = new Point(339, 356);
            cmdCalcular.Name = "cmdCalcular";
            cmdCalcular.Size = new Size(148, 42);
            cmdCalcular.TabIndex = 0;
            cmdCalcular.Text = "Calcular";
            cmdCalcular.UseVisualStyleBackColor = true;
            cmdCalcular.Click += cmdCalcular_Click;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(308, 212);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(56, 20);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura: ";
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(66, 212);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(43, 20);
            lblBase.TabIndex = 2;
            lblBase.Text = "Base:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(541, 209);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(47, 20);
            lblArea.TabIndex = 3;
            lblArea.Text = "Area: ";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(189, 60);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(441, 46);
            lblMensaje.TabIndex = 4;
            lblMensaje.Text = "Calcular Area de Traingulo";
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(594, 206);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(78, 27);
            txtArea.TabIndex = 5;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(115, 209);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(78, 27);
            txtBase.TabIndex = 6;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(370, 212);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(78, 27);
            txtAltura.TabIndex = 7;
            // 
            // frmPractica6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(txtArea);
            Controls.Add(lblMensaje);
            Controls.Add(lblArea);
            Controls.Add(lblBase);
            Controls.Add(lblAltura);
            Controls.Add(cmdCalcular);
            Name = "frmPractica6";
            Text = "Practica 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdCalcular;
        private Label lblAltura;
        private Label lblBase;
        private Label lblArea;
        private Label lblMensaje;
        private TextBox txtArea;
        private TextBox txtBase;
        private TextBox txtAltura;
    }
}
