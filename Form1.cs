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


    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
        }

        private void buttEncener_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Agregar ag =  new Agregar();
            ag.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_Informacion m = new Mostrar_Informacion();
            m.Show();
        }

        private void agregarToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Agregar ag = new Agregar();
            ag.Show();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void verEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void verEstadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Estados ed = new Estados();
            ed.Show();
        }

        private void verMunicipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Municipios m = new Municipios();
            m.Show();
        }

        private void verEstadosYMunicipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdMun ed = new EdMun();
            ed.Show();
        }
    }
}
