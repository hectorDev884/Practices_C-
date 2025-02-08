namespace HMTC_Practica7
{
    partial class frmPractica7
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
            cmdValidar = new Button();
            lblMensaje = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // cmdValidar
            // 
            cmdValidar.Location = new Point(299, 313);
            cmdValidar.Name = "cmdValidar";
            cmdValidar.Size = new Size(178, 48);
            cmdValidar.TabIndex = 0;
            cmdValidar.Text = "Validar";
            cmdValidar.UseVisualStyleBackColor = true;
            cmdValidar.Click += cmdValidar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(241, 52);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(306, 46);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Valida Contrasena";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(264, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(343, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // frmPractica7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblMensaje);
            Controls.Add(cmdValidar);
            Name = "frmPractica7";
            Text = "Ingrese Contrasenia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdValidar;
        private Label lblMensaje;
        private Label lblPassword;
        private TextBox txtPassword;
    }
}
