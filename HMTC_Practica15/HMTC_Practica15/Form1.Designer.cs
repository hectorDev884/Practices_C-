namespace HMTC_Practica15
{
    partial class frmPractica15
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
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            formulario1ToolStripMenuItem = new ToolStripMenuItem();
            segundoFormularioToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formulario1ToolStripMenuItem, segundoFormularioToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // formulario1ToolStripMenuItem
            // 
            formulario1ToolStripMenuItem.Name = "formulario1ToolStripMenuItem";
            formulario1ToolStripMenuItem.Size = new Size(227, 26);
            formulario1ToolStripMenuItem.Text = "Primer Formulario";
            formulario1ToolStripMenuItem.Click += formulario1ToolStripMenuItem_Click;
            // 
            // segundoFormularioToolStripMenuItem
            // 
            segundoFormularioToolStripMenuItem.Name = "segundoFormularioToolStripMenuItem";
            segundoFormularioToolStripMenuItem.Size = new Size(227, 26);
            segundoFormularioToolStripMenuItem.Text = "Segundo Formulario";
            segundoFormularioToolStripMenuItem.Click += segundoFormularioToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // frmPractica15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPractica15";
            Text = "Practica 15";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem formulario1ToolStripMenuItem;
        private ToolStripMenuItem segundoFormularioToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
