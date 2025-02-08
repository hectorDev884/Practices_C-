namespace HMTC_Practica21
{
    partial class frmPractica21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPractica21));
            cmdSalir = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // cmdSalir
            // 
            resources.ApplyResources(cmdSalir, "cmdSalir");
            cmdSalir.Name = "cmdSalir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dgvDatos, "dgvDatos");
            dgvDatos.Name = "dgvDatos";
            // 
            // frmPractica21
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvDatos);
            Controls.Add(cmdSalir);
            Name = "frmPractica21";
            Load += frmPractica21_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cmdSalir;
        private DataGridView dgvDatos;
    }
}
