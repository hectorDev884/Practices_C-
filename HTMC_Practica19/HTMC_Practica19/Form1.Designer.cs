namespace HTMC_Practica19
{
    partial class frmPractica19
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
            components = new System.ComponentModel.Container();
            cmdActivar = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblDatoHora = new Label();
            SuspendLayout();
            // 
            // cmdActivar
            // 
            cmdActivar.Location = new Point(288, 346);
            cmdActivar.Name = "cmdActivar";
            cmdActivar.Size = new Size(181, 70);
            cmdActivar.TabIndex = 0;
            cmdActivar.Text = "Iniciar";
            cmdActivar.UseVisualStyleBackColor = true;
            cmdActivar.Click += cmdActivar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 54);
            label1.Name = "label1";
            label1.Size = new Size(228, 46);
            label1.TabIndex = 1;
            label1.Text = "Hora Actual: ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblDatoHora
            // 
            lblDatoHora.AutoSize = true;
            lblDatoHora.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatoHora.Location = new Point(225, 175);
            lblDatoHora.Name = "lblDatoHora";
            lblDatoHora.Size = new Size(0, 46);
            lblDatoHora.TabIndex = 2;
            // 
            // frmPractica19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDatoHora);
            Controls.Add(label1);
            Controls.Add(cmdActivar);
            Name = "frmPractica19";
            Text = "Practica 19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdActivar;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label lblDatoHora;
    }
}
