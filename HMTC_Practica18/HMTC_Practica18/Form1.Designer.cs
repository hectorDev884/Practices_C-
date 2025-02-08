namespace HMTC_Practica18
{
    partial class frmPractica18
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
            txtTiempo = new TextBox();
            nudDistancia = new NumericUpDown();
            nudVelocidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVelocidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 129);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Distancia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 207);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Velocidad: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 285);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiempo: ";
            // 
            // txtTiempo
            // 
            txtTiempo.Enabled = false;
            txtTiempo.Location = new Point(272, 287);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(252, 27);
            txtTiempo.TabIndex = 3;
            // 
            // nudDistancia
            // 
            nudDistancia.Location = new Point(272, 127);
            nudDistancia.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDistancia.Name = "nudDistancia";
            nudDistancia.Size = new Size(252, 27);
            nudDistancia.TabIndex = 4;
            nudDistancia.ValueChanged += nudDistancia_ValueChanged;
            // 
            // nudVelocidad
            // 
            nudVelocidad.Location = new Point(274, 212);
            nudVelocidad.Name = "nudVelocidad";
            nudVelocidad.Size = new Size(252, 27);
            nudVelocidad.TabIndex = 5;
            nudVelocidad.ValueChanged += nudVelocidad_ValueChanged;
            // 
            // frmPractica18
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudVelocidad);
            Controls.Add(nudDistancia);
            Controls.Add(txtTiempo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPractica18";
            Text = "Practica 18";
            ((System.ComponentModel.ISupportInitialize)nudDistancia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTiempo;
        private NumericUpDown nudDistancia;
        private NumericUpDown nudVelocidad;
    }
}
