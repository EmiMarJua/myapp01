using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp01
{
    public partial class Mostrar_Informacion : Form
    {


        public Mostrar_Informacion()
        {
            InitializeComponent();
        }

        private void Mostrar_Informacion_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            DataSet ds = datos.Mostrar("SELECT * FROM Datos");

            if (ds != null)
            {
                // dgvMostrar.DataSource = ds.Tables[0];

                ActualizarDatos();

            }
            else
            {

                MessageBox.Show("No se pudo obtener la información de la base de datos","Sistema", 
                                    MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void menuClick(Object sender, ToolStripItemClickedEventArgs e)
        {

            string opcion = e.ClickedItem.Name.ToString();//obtener el nombre del que hace click

            if (opcion.Contains("Borrar"))
            {
                int pos = int.Parse(opcion.Replace("Borrar", ""));
                int  id = Convert.ToInt32(dgvMostrar.Rows[pos].Cells[0].Value);

                Datos datos = new Datos();

                if (datos.eliminar(id))
                {
                    MessageBox.Show("Registro eliminado correctamente");
                    ActualizarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar el Registro");
                }

            }
            else if (opcion.Contains("Modificar"))
            {
                int pos = int.Parse(opcion.Replace("Modificar", ""));

                Agregar actualizar = new Agregar(
                    dgvMostrar.Rows[pos].Cells[1].Value.ToString(),
                    dgvMostrar.Rows[pos].Cells[2].Value.ToString(),
                    dgvMostrar.Rows[pos].Cells[3].Value.ToString(),
                    dgvMostrar.Rows[pos].Cells[4].Value.ToString(),
                    dgvMostrar.Rows[pos].Cells[5].Value.ToString(),
                    Convert.ToInt32(dgvMostrar.Rows[pos].Cells[0].Value));

                actualizar.ShowDialog();

                ActualizarDatos();
            }


        }

       

        private void ActualizarDatos()
        {
            Datos datos = new Datos();
            DataSet ds = datos.Mostrar("SELECT * FROM Datos");

                dgvMostrar.AutoGenerateColumns = false;

                dgvMostrar.Columns[0].DataPropertyName = "ID";
                dgvMostrar.Columns[1].DataPropertyName = "Nombre";
                dgvMostrar.Columns[2].DataPropertyName = "Paterno";
                dgvMostrar.Columns[3].DataPropertyName = "Materno";
                dgvMostrar.Columns[4].DataPropertyName = "Telefono";
                dgvMostrar.Columns[5].DataPropertyName = "Correo";

                dgvMostrar.DataSource = ds.Tables[0];

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

        private void Mostrar_Informacion_Activated(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Agregar actualizar = new Agregar(
                dgvMostrar.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dgvMostrar.Rows[e.RowIndex].Cells[2].Value.ToString(),
                dgvMostrar.Rows[e.RowIndex].Cells[3].Value.ToString(),
                dgvMostrar.Rows[e.RowIndex].Cells[4].Value.ToString(),
                dgvMostrar.Rows[e.RowIndex].Cells[5].Value.ToString(),
                Convert.ToInt32(dgvMostrar.Rows[e.RowIndex].Cells[0].Value));
            actualizar.Show();

        }

        private void dgvMostrar_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();

                int pos = dgvMostrar.HitTest(e.X,e.Y).RowIndex; ///obtener el registro mediante la posicio

                if(pos > -1)
                {
                    menu.Items.Add("Borrar").Name = "Borrar" + pos;
                    menu.Items.Add("Modificar").Name = "Modificar" + pos;

                    menu.ItemClicked += new ToolStripItemClickedEventHandler(menuClick);

                    menu.Show(dgvMostrar, e.X, e.Y);

                }

            }
        }
    }
}
