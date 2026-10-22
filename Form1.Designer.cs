namespace MyApp01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.méxicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMunicipiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstadosYMunicipiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.informacionToolStripMenuItem.Text = "Informacion";
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click_2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.méxicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // méxicoToolStripMenuItem
            // 
            this.méxicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEstadosToolStripMenuItem,
            this.verMunicipiosToolStripMenuItem,
            this.verEstadosYMunicipiosToolStripMenuItem});
            this.méxicoToolStripMenuItem.Name = "méxicoToolStripMenuItem";
            this.méxicoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.méxicoToolStripMenuItem.Text = "México";
            // 
            // verEstadosToolStripMenuItem
            // 
            this.verEstadosToolStripMenuItem.Name = "verEstadosToolStripMenuItem";
            this.verEstadosToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.verEstadosToolStripMenuItem.Text = "Ver Estados";
            this.verEstadosToolStripMenuItem.Click += new System.EventHandler(this.verEstadosToolStripMenuItem_Click_1);
            // 
            // verMunicipiosToolStripMenuItem
            // 
            this.verMunicipiosToolStripMenuItem.Name = "verMunicipiosToolStripMenuItem";
            this.verMunicipiosToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.verMunicipiosToolStripMenuItem.Text = "Ver Municipios";
            this.verMunicipiosToolStripMenuItem.Click += new System.EventHandler(this.verMunicipiosToolStripMenuItem_Click);
            // 
            // verEstadosYMunicipiosToolStripMenuItem
            // 
            this.verEstadosYMunicipiosToolStripMenuItem.Name = "verEstadosYMunicipiosToolStripMenuItem";
            this.verEstadosYMunicipiosToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.verEstadosYMunicipiosToolStripMenuItem.Text = "Ver Estados y Municipios";
            this.verEstadosYMunicipiosToolStripMenuItem.Click += new System.EventHandler(this.verEstadosYMunicipiosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 526);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Uso de BD pero sin Docker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem méxicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMunicipiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstadosYMunicipiosToolStripMenuItem;
    }
}

