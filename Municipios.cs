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
    public partial class Municipios : Form
    {
        public Municipios()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            EstadosMunicipios datos = new EstadosMunicipios();

            DataSet ds = datos.Mostrar("SELECT * FROM Municipios order by id ASC");

            if (ds != null && ds.Tables.Count > 0)
            {
                dgvMunicipios.AutoGenerateColumns = false;

                dgvMunicipios.Columns[0].DataPropertyName = "id";
                dgvMunicipios.Columns[1].DataPropertyName = "nombre";

                dgvMunicipios.DataSource = ds.Tables[0];
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

        private void Municipios_Load(object sender, EventArgs e)
        {

        }
    }
}
