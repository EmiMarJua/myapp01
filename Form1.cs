using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace MyApp01
{
    public partial class Form1 : Form
    {

        List<Persona> registros = new List<Persona>();


        public Form1()
        {
            InitializeComponent();
           

        }

        

        private void buttAgregar_Click(object sender, EventArgs e)
        {

            if(ofdCSV.ShowDialog() == DialogResult.OK)
            {
                
                var reader = new StreamReader(ofdCSV.FileName);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                registros = csv.GetRecords<Persona>().ToList();

                foreach (var r in registros)
                {

                    dgvRegistros.Rows.Add(r.id, r.name, r.email);

                }

            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            Form2 editar = new Form2(dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString(), 
                                    dgvRegistros.Rows[e.RowIndex].Cells[2].Value.ToString());

            if(editar.ShowDialog() == DialogResult.OK)
            {

                string nombre = editar.actNombre;
                string correo = editar.actCorreo;
                dgvRegistros.Rows[e.RowIndex].Cells[1].Value = nombre;
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value = correo;

            }

        }

        //

    }
}
