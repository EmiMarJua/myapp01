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
            this.buttCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttCalcular
            // 
            this.buttCalcular.Location = new System.Drawing.Point(29, 184);
            this.buttCalcular.Name = "buttCalcular";
            this.buttCalcular.Size = new System.Drawing.Size(100, 30);
            this.buttCalcular.TabIndex = 0;
            this.buttCalcular.Text = "Calcular";
            this.buttCalcular.UseVisualStyleBackColor = true;
            this.buttCalcular.Click += new System.EventHandler(this.buttCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(12, 34);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(199, 22);
            this.textNum1.TabIndex = 3;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(12, 111);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(199, 22);
            this.textNum2.TabIndex = 4;
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(219, 188);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(199, 22);
            this.textResultado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // buttLimpiar
            // 
            this.buttLimpiar.Location = new System.Drawing.Point(333, 30);
            this.buttLimpiar.Name = "buttLimpiar";
            this.buttLimpiar.Size = new System.Drawing.Size(100, 30);
            this.buttLimpiar.TabIndex = 7;
            this.buttLimpiar.Text = "Limpiar";
            this.buttLimpiar.UseVisualStyleBackColor = true;
            this.buttLimpiar.Click += new System.EventHandler(this.buttLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 294);
            this.Controls.Add(this.buttLimpiar);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttCalcular);
            this.Name = "Form1";
            this.Text = "Primera App Topap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttLimpiar;
    }
}

