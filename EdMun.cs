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
    public partial class EdMun : Form
    {
        public EdMun()
        {
            InitializeComponent();
            
        }

        private void mostrarDatos()
        {
            EstadosMunicipios datos = new EstadosMunicipios();

            DataSet ds = datos.Mostrar("SELECT m.id,m.nombre AS Municipio,e.id AS idEstado,e.nombre AS Estado FROM Municipios m INNER JOIN Estado e ON m.idEstado = e.id order by e.id ASC;");

            if (ds != null)
            {
                dgvDatos.AutoGenerateColumns = false;

                dgvDatos.Columns[0].DataPropertyName = "id";
                dgvDatos.Columns[1].DataPropertyName = "Municipio";
                dgvDatos.Columns[2].DataPropertyName = "idEstado";
                dgvDatos.Columns[3].DataPropertyName = "Estado";

                dgvDatos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudo obtener la información de la base de datos");
            }
        }

        private void buttMostrar_Click(object sender, EventArgs e)
        {


        }

        private void EdMun_Load(object sender, EventArgs e)
        {
            mostrarDatos(); 
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
