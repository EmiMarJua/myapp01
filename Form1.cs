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

        int contador = 0;
        int minutos = 0;

        bool bandera = false;

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            //hora minutos y am o pm
            // labReloj.Text = DateTime.Now.ToShortTimeString();// hora del sistema en el pc
            // labReloj.Text = DateTime.Now.ToLongTimeString(); //muestra los segundos y a hora

            contador++;

            DateTime tiempo = DateTime.Now;
            labReloj.Text = tiempo.ToString("HH:mm:ss");
            labFecha.Text = tiempo.ToString("MM-dd-yyyy");

            if(contador == 60)
            {
                minutos++;
                contador = 0;
            }

            labEjecucion.Text = "Tiempo en Ejecucion: " + minutos.ToString() + " minutos en ejecucion";

        }

        private void buttEncener_Click(object sender, EventArgs e)
        {
            if(bandera == false)
            {
                bandera = true;
                tmrReloj.Enabled = true;
                buttEncener.Text = "Apagar";

            }
            else
            {
                bandera = false;
                tmrReloj.Enabled = false; 
                buttEncener.Text = "Encender";  

            }

            
        }

        //autoguardado en notas 

    }
}
