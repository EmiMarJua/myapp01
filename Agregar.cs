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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        Datos d = new Datos();

        private void buttAgregar_Click(object sender, EventArgs e)
        {

           bool f = d.insertar(textNombre.Text,textPaterno.Text,textMaterno.Text,mtbTelefono.Text,textCorreo.Text);

            if(f == true)
            {
                MessageBox.Show("Registro Completado");
            }

            this.Close();

        }

        private void buttCerrar_Click(object sender, EventArgs e)
        {



        }
    }
}
