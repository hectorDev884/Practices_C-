namespace HMTC_Practica13
{
    partial class frmPractica13
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
            txtBase = new TextBox();
            txtAltura = new TextBox();
            txtArea = new TextBox();
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 56);
            label1.Name = "label1";
            label1.Size = new Size(310, 46);
            label1.TabIndex = 0;
            label1.Text = "Area del triangulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 163);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Base:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 256);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Altura:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 357);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Area: ";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(245, 160);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(239, 27);
            txtBase.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(245, 256);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(239, 27);
            txtAltura.TabIndex = 5;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(245, 357);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(239, 27);
            txtArea.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(487, 219);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(36, 100);
            vScrollBar1.TabIndex = 7;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(499, 159);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(218, 28);
            hScrollBar1.TabIndex = 8;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // frmPractica13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hScrollBar1);
            Controls.Add(vScrollBar1);
            Controls.Add(txtArea);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPractica13";
            Text = "Practica 13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBase;
        private TextBox txtAltura;
        private TextBox txtArea;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
    }
}
