namespace MyApp01
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttActualizar = new System.Windows.Forms.Button();
            this.buttCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(56, 79);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(295, 22);
            this.textNombre.TabIndex = 1;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(56, 190);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(398, 22);
            this.textCorreo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo";
            // 
            // buttActualizar
            // 
            this.buttActualizar.Location = new System.Drawing.Point(120, 242);
            this.buttActualizar.Name = "buttActualizar";
            this.buttActualizar.Size = new System.Drawing.Size(95, 38);
            this.buttActualizar.TabIndex = 4;
            this.buttActualizar.Text = "Actualizar";
            this.buttActualizar.UseVisualStyleBackColor = true;
            this.buttActualizar.Click += new System.EventHandler(this.buttActualizar_Click);
            // 
            // buttCancelar
            // 
            this.buttCancelar.Location = new System.Drawing.Point(302, 242);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(104, 38);
            this.buttCancelar.TabIndex = 5;
            this.buttCancelar.Text = "Cancelar";
            this.buttCancelar.UseVisualStyleBackColor = true;
            this.buttCancelar.Click += new System.EventHandler(this.buttCancelar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 305);
            this.Controls.Add(this.buttCancelar);
            this.Controls.Add(this.buttActualizar);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttActualizar;
        private System.Windows.Forms.Button buttCancelar;
    }
}