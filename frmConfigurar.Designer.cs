namespace MyApp01
{
    partial class frmConfigurar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpConfigura = new System.Windows.Forms.DateTimePicker();
            this.buttAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpConfigura
            // 
            this.dtpConfigura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpConfigura.Location = new System.Drawing.Point(45, 71);
            this.dtpConfigura.Name = "dtpConfigura";
            this.dtpConfigura.ShowUpDown = true;
            this.dtpConfigura.Size = new System.Drawing.Size(200, 22);
            this.dtpConfigura.TabIndex = 0;
            // 
            // buttAceptar
            // 
            this.buttAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttAceptar.Location = new System.Drawing.Point(387, 61);
            this.buttAceptar.Name = "buttAceptar";
            this.buttAceptar.Size = new System.Drawing.Size(125, 40);
            this.buttAceptar.TabIndex = 1;
            this.buttAceptar.Text = "Aceptar";
            this.buttAceptar.UseVisualStyleBackColor = true;
            this.buttAceptar.Click += new System.EventHandler(this.buttAceptar_Click);
            // 
            // frmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 155);
            this.Controls.Add(this.buttAceptar);
            this.Controls.Add(this.dtpConfigura);
            this.Name = "frmConfigurar";
            this.Text = "Configurar Alarma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpConfigura;
        private System.Windows.Forms.Button buttAceptar;
    }
}