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
    public partial class Estados : Form
    {
        public Estados()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            EstadosMunicipios datos = new EstadosMunicipios();

            DataSet ds = datos.Mostrar("SELECT * FROM estado order by nombre ASC");

            if (ds != null && ds.Tables.Count > 0)
            {
                dgvEstados.AutoGenerateColumns = false;

                dgvEstados.Columns[0].DataPropertyName = "id";
                dgvEstados.Columns[1].DataPropertyName = "nombre";

                dgvEstados.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudo obtener la información de la base de datos");
            }
        }

        private void buttMostrar_Click(object sender, EventArgs e)
        {

            mostrarDatos();

        }

        private void buttCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
