namespace HMTC_Practica11
{
    partial class frmPractica11
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboRojo = new ComboBox();
            cboVerde = new ComboBox();
            cboAzul = new ComboBox();
            cmdCambiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 57);
            label1.Name = "label1";
            label1.Size = new Size(140, 46);
            label1.TabIndex = 0;
            label1.Text = "Colores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 148);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Rojo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 215);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Verde:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 278);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Azul:";
            // 
            // cboRojo
            // 
            cboRojo.FormattingEnabled = true;
            cboRojo.Location = new Point(298, 148);
            cboRojo.Name = "cboRojo";
            cboRojo.Size = new Size(232, 28);
            cboRojo.TabIndex = 4;
            // 
            // cboVerde
            // 
            cboVerde.FormattingEnabled = true;
            cboVerde.Location = new Point(298, 212);
            cboVerde.Name = "cboVerde";
            cboVerde.Size = new Size(232, 28);
            cboVerde.TabIndex = 5;
            // 
            // cboAzul
            // 
            cboAzul.FormattingEnabled = true;
            cboAzul.Location = new Point(298, 275);
            cboAzul.Name = "cboAzul";
            cboAzul.Size = new Size(232, 28);
            cboAzul.TabIndex = 6;
            // 
            // cmdCambiar
            // 
            cmdCambiar.Location = new Point(298, 337);
            cmdCambiar.Name = "cmdCambiar";
            cmdCambiar.Size = new Size(222, 61);
            cmdCambiar.TabIndex = 7;
            cmdCambiar.Text = "Cambiar";
            cmdCambiar.UseVisualStyleBackColor = true;
            cmdCambiar.Click += cmdCambiar_Click;
            // 
            // frmPractica11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdCambiar);
            Controls.Add(cboAzul);
            Controls.Add(cboVerde);
            Controls.Add(cboRojo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPractica11";
            Text = "Practica 11";
            Load += frmPractica11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboRojo;
        private ComboBox cboVerde;
        private ComboBox cboAzul;
        private Button cmdCambiar;
    }
}
