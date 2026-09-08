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
            this.components = new System.ComponentModel.Container();
            this.labReloj = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.labFecha = new System.Windows.Forms.Label();
            this.labEjecucion = new System.Windows.Forms.Label();
            this.buttEncener = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // labReloj
            // 
            this.labReloj.AutoSize = true;
            this.labReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labReloj.Location = new System.Drawing.Point(111, 33);
            this.labReloj.Name = "labReloj";
            this.labReloj.Size = new System.Drawing.Size(64, 69);
            this.labReloj.TabIndex = 0;
            this.labReloj.Text = "0";
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.Location = new System.Drawing.Point(111, 125);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(64, 69);
            this.labFecha.TabIndex = 1;
            this.labFecha.Text = "0";
            // 
            // labEjecucion
            // 
            this.labEjecucion.AutoSize = true;
            this.labEjecucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEjecucion.Location = new System.Drawing.Point(12, 307);
            this.labEjecucion.Name = "labEjecucion";
            this.labEjecucion.Size = new System.Drawing.Size(289, 29);
            this.labEjecucion.TabIndex = 2;
            this.labEjecucion.Text = "Tiempo en Ejecucion: 0";
            // 
            // buttEncener
            // 
            this.buttEncener.Location = new System.Drawing.Point(508, 307);
            this.buttEncener.Name = "buttEncener";
            this.buttEncener.Size = new System.Drawing.Size(75, 23);
            this.buttEncener.TabIndex = 3;
            this.buttEncener.Text = "Encender";
            this.buttEncener.UseVisualStyleBackColor = true;
            this.buttEncener.Click += new System.EventHandler(this.buttEncener_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(620, 24);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttEncener);
            this.Controls.Add(this.labEjecucion);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.labReloj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labReloj;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Label labEjecucion;
        private System.Windows.Forms.Button buttEncener;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

