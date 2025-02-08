namespace Practica_4
{
    partial class frmPractica4
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
            cmdRojo = new Button();
            cmdAmarillo = new Button();
            cmdAzul = new Button();
            SuspendLayout();
            // 
            // cmdRojo
            // 
            cmdRojo.Location = new Point(34, 159);
            cmdRojo.Name = "cmdRojo";
            cmdRojo.Size = new Size(162, 78);
            cmdRojo.TabIndex = 0;
            cmdRojo.Text = "Rojo";
            cmdRojo.UseVisualStyleBackColor = true;
            cmdRojo.Click += cmdRojo_Click;
            // 
            // cmdAmarillo
            // 
            cmdAmarillo.Location = new Point(494, 159);
            cmdAmarillo.Name = "cmdAmarillo";
            cmdAmarillo.Size = new Size(162, 78);
            cmdAmarillo.TabIndex = 1;
            cmdAmarillo.Text = "Amarillo";
            cmdAmarillo.UseVisualStyleBackColor = true;
            cmdAmarillo.Click += cmdAmarillo_Click;
            // 
            // cmdAzul
            // 
            cmdAzul.Location = new Point(273, 159);
            cmdAzul.Name = "cmdAzul";
            cmdAzul.Size = new Size(162, 78);
            cmdAzul.TabIndex = 2;
            cmdAzul.Text = "Azul";
            cmdAzul.UseVisualStyleBackColor = true;
            cmdAzul.Click += cmdAzul_Click;
            // 
            // frmPractica4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 356);
            Controls.Add(cmdAzul);
            Controls.Add(cmdAmarillo);
            Controls.Add(cmdRojo);
            Name = "frmPractica4";
            Text = "Colores";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdRojo;
        private Button cmdAmarillo;
        private Button cmdAzul;
    }
}
