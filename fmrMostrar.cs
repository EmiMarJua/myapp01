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
    public partial class Mostrar_Informacion : Form
    {

        Datos datos;

        public Mostrar_Informacion()
        {
            InitializeComponent();
        }

        private void Mostrar_Informacion_Load(object sender, EventArgs e)
        {
            datos = new Datos();
            DataSet ds = datos.Mostrar("SELECT * FROM datos");

            if (ds != null)
            {
                dgvMostrar.DataSource = ds.Tables[0];
            }
            else
            {

                MessageBox.Show("No se pudo obtener la información de la base de datos","Sistema", 
                                    MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void buttInsertar_Click(object sender, EventArgs e)
        {
            Agregar ag = new Agregar();
            ag.Show();
        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
