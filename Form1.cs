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

        List<Persona> personas = new List<Persona>();


        public Form1()
        {
            InitializeComponent();
            personas.Add(new Persona(1,"Jose Luis","8714502555"));
            personas.Add(new Persona(2, "Jose Mario", "8712556220"));
            personas.Add(new Persona(3, "Dina Bonaparte", "8712555890"));
            personas.Add(new Persona(4, "Jose Emmanuel", "9712556220"));

        }

        

        private void buttAgregar_Click(object sender, EventArgs e)
        {

            dgvMostrar.Rows.Add();



            dgvMostrar[0,dgvMostrar.Rows.Count-1].Value = dgvMostrar.Rows.Count;
            dgvMostrar[1,dgvMostrar.Rows.Count-1].Value = textNombre.Text;
            dgvMostrar[2,dgvMostrar.Rows.Count-1].Value = textCorreo.Text;


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var persona in personas)//datos precargados con una clase mediante ubicacion en una  lista
                                            //usando get set y un bucle foreach
            {

                dgvMostrar.Rows.Add();
                dgvMostrar[0, dgvMostrar.Rows.Count - 1].Value = persona.id;
                dgvMostrar[1, dgvMostrar.Rows.Count - 1].Value = persona.nombre;
                dgvMostrar[2, dgvMostrar.Rows.Count - 1].Value = persona.telefono;

            }   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //

    }
}
