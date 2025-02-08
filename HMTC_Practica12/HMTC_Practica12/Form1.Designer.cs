namespace HMTC_Practica12
{
    partial class frmPractica12
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
            cmdAgregar = new Button();
            label1 = new Label();
            txtMaterial = new TextBox();
            lstMateriales = new ListBox();
            SuspendLayout();
            // 
            // cmdAgregar
            // 
            cmdAgregar.Location = new Point(550, 82);
            cmdAgregar.Name = "cmdAgregar";
            cmdAgregar.Size = new Size(119, 55);
            cmdAgregar.TabIndex = 0;
            cmdAgregar.Text = "Agregar";
            cmdAgregar.UseVisualStyleBackColor = true;
            cmdAgregar.Click += cmdAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 99);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Material: ";
            // 
            // txtMaterial
            // 
            txtMaterial.Location = new Point(253, 96);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(244, 27);
            txtMaterial.TabIndex = 2;
            // 
            // lstMateriales
            // 
            lstMateriales.FormattingEnabled = true;
            lstMateriales.Location = new Point(250, 178);
            lstMateriales.Name = "lstMateriales";
            lstMateriales.Size = new Size(253, 164);
            lstMateriales.TabIndex = 3;
            lstMateriales.SelectedIndexChanged += lstMateriales_SelectedIndexChanged;
            // 
            // frmPractica12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMateriales);
            Controls.Add(txtMaterial);
            Controls.Add(label1);
            Controls.Add(cmdAgregar);
            Name = "frmPractica12";
            Text = "Practica 12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAgregar;
        private Label label1;
        private TextBox txtMaterial;
        private ListBox lstMateriales;
    }
}
