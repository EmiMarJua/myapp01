using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp01
{
    public partial class Form2 : Form
    {

        public String actNombre { get; set; }
        public String actCorreo { get; set; }

        public Form2(string nombre, string correo)
        {
            InitializeComponent();
            textNombre.Text = nombre;
            textCorreo.Text = correo;   
        }

        private void buttActualizar_Click(object sender, EventArgs e)
        {

            actNombre = textNombre.Text;
            actCorreo = textCorreo.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttCancelar_Click(object sender, EventArgs e)
        {

            

        }
    }
}
